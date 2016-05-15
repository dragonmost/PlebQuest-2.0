using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
            //DB request here
            if (true)
            {
                Console.WriteLine(data[1] + " as joined the Quest!");
            }
            else { }
        }

        private void ProcessData(GameClient gameClient, string data)
        {
            string[] parsedData = data.Split(';');

            switch (parsedData[0])
            {
                case Commands.PlayerConnection:
                    PlayerConnection(gameClient, parsedData);
                    break;
            }
        }
    }
}
