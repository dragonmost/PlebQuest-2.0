using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PlebServer;

namespace PlebQuest
{
    class Client
    {
        private static Client instance;

        private string IP;
        private TcpClient client;   
        private StreamWriter Writer;

        private Action responseAction;      //only works if there are 1 action at a time.
        public string ResponseData { get; private set; }

        private Client(string IP)
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
                MessageBox.Show("No host server found.");
                Debug.Write(ex);
                LogService.SilentLog(ex);
            }
        }

        public static Client Instance
        {
            get
            {
                if (instance == null)
                    instance = new Client(Config.IP);

                return instance;
            }
        }

        public bool Connected
        {
            get
            {
                return this.client.Connected;
            }
        }

        private void SendData(string data)
        {
            Writer.WriteLineAsync(data);
        }

        public void SendData(string[] data)
        {
            string dataToSend = string.Empty;

            foreach (string str in data)
            {
                str.Replace(';', ',');  //temp security
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

                    if (responseAction == null)
                    {
                        ProcessData(strData);                        
                    }
                    else
                    {
                        ResponseData = strData;

                        responseAction.Invoke();

                        responseAction = null;
                    }
                }
            }
            catch (Exception ex)
            {
                //Disconnected
                Debug.WriteLine(ex.Message);
                LogService.SilentLog(ex);
            }
        }

        public void SendDataWithResponse(string[] data, Action action)
        {
            this.SendData(data);
            this.responseAction = action;
        }

        private void ProcessData(string data)
        {
            string[] parsedData = data.Split(';');

            switch (parsedData[0])
            {

                case Commands.ConnectionAccepted:
                    Pleb pleb = JsonConvert.DeserializeObject<Pleb>(parsedData[1]);
                    break;
                case Commands.ConnectionRefused:
                    this.ConnectionRefused();
                    break;
            }
        }

        private void ProcessResponse(string data)
        {

        }

        private void ConnectionRefused()
        {
            MessageBox.Show("Invalid Username and Password");
        }

        public T[] GetDBOjects<T>(string tableName)
        {
            return DataBase.GetDBObjects<T>(tableName);
        }
    }
}
