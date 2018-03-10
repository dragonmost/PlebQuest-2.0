using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using PlebQuest;
using System.Reflection;

namespace PlebServer
{
    class Server : ICommands
    {
        static List<Task> receiveTask = new List<Task>();
        public List<GameClient> lstClient = new List<GameClient>();

        public Server()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, Config.Port);

            tcpListener.Start();

            Task listenerTask = AcceptClient(tcpListener);

            //while(true);
        }

        private async Task AcceptClient(TcpListener listener)
        {
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();

                GameClient gameClient = new GameClient(client);

                receiveTask.Add(ReceiveData(gameClient));
                lstClient.Add(gameClient);
                Console.WriteLine("New Connection: " + gameClient.RemoteEndPoint.ToString());
            }
        }        

        private async Task ReceiveData(GameClient gameClient)
        {
            try
            {
                while (true)
                {
                    string data = await gameClient.Reader.ReadLineAsync();

                    Packet packet = JsonConvert.DeserializeObject<Packet>(data);

                    MethodInfo method = this.GetType().GetMethod(packet.CommandName);
                    object response = method.Invoke(this, packet.Parameters);

                    gameClient.Writer.WriteLine(JsonConvert.SerializeObject(response));
                }
            }
            catch (IOException ex)
            {
                //disconnected
                lstClient.Remove(gameClient);
                Console.WriteLine("Player disconnected: " + gameClient.RemoteEndPoint.ToString());
            }
        }

        public Response PlayerConnection(GameClient gameClient, string[] data)
        {
            //DataBase.DbExecute("INSERT INTO items(name, gold_value, weight) VALUES('Goblin ear', 10, 1)");
            Pleb pleb = DataBase.GetPleb(data[1], data[2]);

            string dataToSend = string.Empty;
            //DB request here
            if (pleb != null)
            {
                Console.WriteLine(data[1] + " as joined the Quest!");
                string plebData = JsonConvert.SerializeObject(pleb);
                dataToSend = Commands.ConnectionAccepted + ";" + plebData;//send character
            }
            else
            {
                this.lstClient.Remove(gameClient);
                Console.WriteLine(gameClient.RemoteEndPoint.ToString() + ": used invalid credentials");
                dataToSend = Commands.ConnectionRefused;
            }

            using (StreamWriter streamWriter = new StreamWriter(gameClient.client.GetStream()))
            {
                streamWriter.AutoFlush = true;
                streamWriter.WriteLine(dataToSend);//send character
            }

            return null;//pls
        }

        //private void ProcessData(GameClient gameClient, string data)
        //{
        //    string[] parsedData = data.Split(';');
        //
        //    switch (parsedData[0])
        //    {
        //        case Commands.CreateUser:
        //            this.UserCreation(gameClient, parsedData[1], parsedData[2]);
        //            break;
        //        case Commands.PlayerConnection:
        //            PlayerConnection(gameClient, parsedData);
        //            break;
        //        case Commands.SendCharacter:
        //            string strPleb = data.Substring(Commands.SendCharacter.Length + 1);
        //            try
        //            {
        //                Pleb pleb = JsonConvert.DeserializeObject<Pleb>(strPleb);
        //            }
        //            catch (Exception ex)
        //            { }
        //            break;
        //    }
        //}

        public Response UserCreation(GameClient client, string username, string pw)
        {
            bool created = DataBase.DbExecute(
                "INSERT INTO users(username,password) VALUES("
                + "'" + username + "'" + "," + "'" + pw + "'" + ")");

            client.Writer.WriteLine(Commands.UserCreationResponse + ";" + created.ToString());

            return new Response
            {
                CommandName = "UserCreation",
                Parameters = new object[] { created }
            };
        }

        public static String sha256_hash(String value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Join("", hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("x2")));
            }
        }
    }
}
