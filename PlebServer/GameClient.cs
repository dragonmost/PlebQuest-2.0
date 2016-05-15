using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using PlebQuest;

namespace PlebServer
{
    class GameClient
    {
        public TcpClient client { get; private set; }                                   //client
        public StreamReader Reader { get; private set; }                                //lit les données
        public StreamWriter Writer { get; private set; }                                //envoie les données
        public NetworkStream Stream { get { return client.GetStream(); } }
        public EndPoint RemoteEndPoint { get { return client.Client.RemoteEndPoint; } }
        public Pleb Pleb { get; private set; }

        public GameClient(TcpClient _client)
        {
            client = _client;

            Writer = new StreamWriter(Stream);
            Writer.AutoFlush = true;

            Reader = new StreamReader(Stream);
        }

        public void AssignPleb(Pleb pleb)
        {
            this.Pleb = pleb;
        }

        public bool isConnected
        {
            get
            {
                return this.Pleb != null;
            }
        }
    }
}
