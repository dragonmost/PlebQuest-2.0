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

namespace PlebServer
{
    class Server
    {
        static List<Task> receiveTask = new List<Task>();                   // liste d'action a faire
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
                //connected
                lstClient.Add(gameClient);
                Console.WriteLine("New Connection: " + gameClient.RemoteEndPoint.ToString());

                /*using (StreamWriter streamWriter = new StreamWriter(client.GetStream()))
                {
                    streamWriter.AutoFlush = true;
                    //PlayerConnection(streamWriter);
                }*/                
            }
        }

        private async Task ReceiveData(GameClient gameClient)
        {
            try
            {
                while (true)
                {
                    string strData = await gameClient.Reader.ReadLineAsync();  // donné recu par le client
                    ProcessData(gameClient, strData);
                }
            }
            catch (IOException ex)
            {
                //disconnected
                lstClient.Remove(gameClient);
                Console.WriteLine("Player disconnected: " + gameClient.RemoteEndPoint.ToString());
            }
        }

        private void PlayerConnection(GameClient gameClient, string[] data)
        {
            try
            {
                MySqlConnectionStringBuilder connString = new MySqlConnectionStringBuilder();
                connString.Server = "localhost";
                connString.UserID = "root";
                //connString.Password = "123";
                connString.Database = "plebquest";

                using (MySqlConnection conn = new MySqlConnection(connString.ToString()))
                using (MySqlCommand cmd = conn.CreateCommand())
                {    //watch out for this SQL injection vulnerability below
                    cmd.CommandText = "INSERT INTO items (name, gold_value, weight) VALUES('Goblin ear', 10, 1)";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            { }


            string dataToSend = string.Empty;
            //DB request here
            if (data[1] == "dragonmost")
            {
                Console.WriteLine(data[1] + " as joined the Quest!");
                dataToSend = Commands.ConnectionAccepted + ";";//send character
            }
            else
            {
                this.lstClient.Remove(gameClient);
                Console.WriteLine(gameClient.RemoteEndPoint.ToString() + ": used invalid credentials");
                dataToSend = Commands.ConnectionRefused + ";";
            }

            using (StreamWriter streamWriter = new StreamWriter(gameClient.client.GetStream()))
            {
                streamWriter.AutoFlush = true;
                streamWriter.WriteLine(dataToSend);//send character
            }
        }

        private void ProcessData(GameClient gameClient, string data)
        {
            string[] parsedData = data.Split(';');

            switch (parsedData[0])
            {
                case Commands.PlayerConnection:
                    PlayerConnection(gameClient, parsedData);
                    break;
                case Commands.SendCharacter:
                    string strPleb = data.Substring(Commands.SendCharacter.Length + 1);
                    try
                    {
                        Pleb pleb = JsonConvert.DeserializeObject<Pleb>(strPleb);
                    }
                    catch(Exception ex)
                    { }
                    break;
            }
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
