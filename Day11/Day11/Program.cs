using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    internal class Program
    {
        static List<Client> Clients = new List<Client>();


        static async Task Start()
        {
            IPAddress iPAddress = IPAddress.Parse("192.168.1.3");
            TcpListener tcpListener = new TcpListener(iPAddress, 5500);
            tcpListener.Start();
            Console.WriteLine("Server started. Waiting for a connection...");

            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
                Console.WriteLine("Client connected.");

                Client client = new Client(tcpClient);
                Clients.Add(client);

                _ = Task.Run(() => client.HandleCommunication()); // Start communication loop
            }
        }
        static async Task Main(string[] args)
        {
           await Start();
        }
    }
}
