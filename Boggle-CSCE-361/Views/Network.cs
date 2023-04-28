using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

static async Task StartServerAsync()
{
    TcpListener listener = null;
    try
    {
        // Set the IP address and port number
        IPAddress ipAddress = IPAddress.Parse("10.69.255.254");
        int port = 5555;

        // Create the TCP listener
        listener = new TcpListener(ipAddress, port);

        // Start listening for incoming client requests
        listener.Start();

        Console.WriteLine("Server started. Waiting for connections...");

        while (true)
        {
            // Accept a client connection
            TcpClient client = await listener.AcceptTcpClientAsync();

            Console.WriteLine("Client connected. Waiting for data...");

            // Start a new task to handle the client connection
            Task.Run(() => HandleClientAsync(client));
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception: {0}", ex.Message);
    }
    finally
    {
        // Stop listening for new clients
        listener.Stop();
    }
}

static async Task HandleClientAsync(TcpClient client)
{
    try
    {
        // Get a stream object for reading and writing
        NetworkStream stream = client.GetStream();

        byte[] buffer = new byte[1024];
        int bytesRead;

        // Loop to receive all the data sent by the client
        while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
        {
            // Convert the data to a string and display it
            string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received: {0}", data);

            // Send a response back to the client
            byte[] msg = Encoding.ASCII.GetBytes("Received your message.");
            await stream.WriteAsync(msg, 0, msg.Length);
            Console.WriteLine("Sent: {0}", Encoding.ASCII.GetString(msg));
        }

        // Shutdown and close the connection
        client.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception: {0}", ex.Message);
    }
}

static void StartClient()
{
    try
    {
        // Set the IP address and port number
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        int port = 5555;

        // Create a TCP client
        TcpClient client = new TcpClient(ipAddress.ToString(), port);

        Console.WriteLine("Connected to server. Enter message to send:");

        while (true)
        {
            // Get a message from the console
            string message = Console.ReadLine();

            // Exit the loop if the user types "exit"
            if (message.ToLower() == "exit")
            {
                break;
            }

            // Convert the message to a byte array and send it to the server
            byte[] data = Encoding.ASCII.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            // Receive a response from the server
            data = new byte[1024];
            int bytes = stream.Read(data, 0, data.Length);
            string response = Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine("Server response: {0}", response);
        }

        // Shutdown and close the connection
        client.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception: {0}", ex.Message);
    }
}