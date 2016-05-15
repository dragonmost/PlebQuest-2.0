using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlebServer;

namespace PlebQuest
{
    class Client
    {
        string IP;
        TcpClient client;           // le client connecter au serveur
        StreamWriter Writer;        // envoi les informations au serveur

        public Client(string IP)
        {
            this.IP = IP;
            try
            {
                client = new TcpClient(IP, Config.Port);
                Writer = new StreamWriter(client.GetStream());
                Writer.AutoFlush = true;
                Task receiveTask = ReceiveData(client);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("No host server found.");
            }

        }

        public void SendData(string data)
        {
            Writer.WriteLineAsync(data);
        }

        public void SendData(string[] data)
        {
            string dataToSend = string.Empty;

            foreach (string str in data)
            {
                dataToSend += str + ";";
            }

            SendData(dataToSend);
        }

        private async Task ReceiveData(TcpClient client)
        {
            StreamReader reader = new StreamReader(client.GetStream());

            try
            {
                while (true)
                {
                    string strData = await reader.ReadLineAsync();
                    ProcessData(strData);
                }
            }
            catch (Exception ex)
            {
                //Disconnected
                //Debug.WriteLine(ex.Message);
            }
        }

        private void ProcessData(string data)
        {
            string[] parsedData = data.Split(';');

            switch (parsedData[0])
            {
                case Commands.ConnectionAccepted:
                    
                    break;
                case Commands.ConnectionRefused:
                    this.ConnectionRefused();
                    break;
            }
        }

        private void ConnectionRefused()
        {
            MessageBox.Show("Invalid Username and Password");
        }
    }
}
