using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
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

        public void SendPleb(Pleb pleb)
        {
            Writer.WriteLine(Commands.SendCharacter + ";" + JsonConvert.SerializeObject(pleb));
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
