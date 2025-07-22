using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace chat_client
{
    internal class Program
    {
        static async Task Connect()
        {
            TcpClient client = new TcpClient();
            try
            {
                await client.ConnectAsync("192.168.1.3", 5500);
                Console.WriteLine("Connected to server.");

                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                // Task to receive messages
                _ = Task.Run(async () =>
                {
                    while (true)
                    {
                        try
                        {
                            string msg = await reader.ReadLineAsync();
                            if (msg == null) break;
                            Console.WriteLine("Server says: " + msg);
                        }
                        catch
                        {
                            Console.WriteLine("Disconnected from server.");
                            break;
                        }
                    }
                });

                // Loop to send messages
                while (true)
                {
                    Console.Write("Client: ");
                    string input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                        await writer.WriteLineAsync(input);
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"Error connecting to server: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        static async Task Main(string[] args)
        {
          await Connect();
        }
    }
}
