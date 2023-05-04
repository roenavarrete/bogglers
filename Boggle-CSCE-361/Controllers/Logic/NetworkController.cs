namespace Boggle_CSCE_361.Controllers.Controllers
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    public class NetworkController
    {
        private TcpListener listener;

        public void StartServer(string ipAddress, int port)
        {
            IPAddress localAddr = IPAddress.Parse(ipAddress);
            listener = new TcpListener(localAddr, port);
            listener.Start();

            Console.WriteLine("Server started on {0}:{1}", ipAddress, port);

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();

                Console.WriteLine("Client connected: {0}", client.Client.RemoteEndPoint);

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            // Handle client connection here

            client.Close();
        }

        public void ConnectToServer(string ipAddress, int port)
        {
            TcpClient client = new TcpClient();
            client.Connect(ipAddress, port);

            Console.WriteLine("Connected to server: {0}", client.Client.RemoteEndPoint);

            // Handle server connection here

            client.Close();
        }

    }
}
