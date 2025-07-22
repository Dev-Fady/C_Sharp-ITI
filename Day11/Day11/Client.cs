using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    internal class Client
    {
        TcpClient tcpClient;
        StreamReader streamReader;
        StreamWriter streamWriter;

        public Client(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            NetworkStream stream = tcpClient.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream) { AutoFlush = true };
        }

        public async Task HandleCommunication()
        {
            await Send("HELLO I'm SERVER");

            while (true)
            {
                try
                {
                    string msgFromClient = await streamReader.ReadLineAsync();
                    if (msgFromClient == null) break;

                    Console.WriteLine($"Client says: {msgFromClient}");

                    Console.Write("Server: ");
                    string reply = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(reply))
                        await Send(reply);
                }
                catch
                {
                    Console.WriteLine("Client disconnected.");
                    break;
                }
            }
        }

        public async Task Send(string msg)
        {
            await streamWriter.WriteLineAsync(msg);
        }
    }
}
