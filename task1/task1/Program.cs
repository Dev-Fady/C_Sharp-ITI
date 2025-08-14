namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("========================================================");
            }
        }
    }
}
