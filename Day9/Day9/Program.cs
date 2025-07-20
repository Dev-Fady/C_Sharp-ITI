using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Day9
{
    internal class Program
    {
        static bool finish = false;
        static bool printed = false;
        static object thisLock = new object();
        static int printY()
        {
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                
                Console.Write("Y");
                if (i %2==0 )
                {
                  count++;
                }
            }
              return count; 
        }

        static void printNum(int maxnum)
        {
            //for (int i = 0; i < maxnum; i++)
            //{
            //    Console.Write(i);
            //}
            while(!finish)
            {
                for (int i = 0; i < maxnum; i++)
                {
                    Console.Write(i);
                }
                finish = true; // Set finish to true to stop the loop after one iteration
            }
        }

        static void PrintMsg()
        {
            lock (thisLock)
            {
                if (!printed)
                 {
                Console.WriteLine("This is a message from the thread.");
                printed = true;
                 }
            }
            
        }

        static void BeginTask()
        {
            //Task<int> task = Task.Run(() => printY());

            ////int res = task.Result;
            ////Console.WriteLine($"Task completed with result: {res}");
            //TaskAwaiter<int> awaiter = task.GetAwaiter();
            ////awaiter.OnCompleted(() => TaskFinished(task.Result));
            //awaiter.OnCompleted(()=> Console.WriteLine("Task is completed!"));
            ////TaskFinished(task);

            //int result = await Task.Run(() => printY());
            //Console.WriteLine($"Task is completed result is {result}");

            print();
        }
        static async Task<int> print()
        {
            int res=await Task.Run(() => printY());
            Console.WriteLine($"\n Task is completed result is {res}");
            return res;
        }
        static void TaskFinished(int task)
        {
            Console.WriteLine($"Task completed with result: {task}");
        }
        static void Main(string[] args)
        {
            #region Thread
            //ThreadStart threadStart = new ThreadStart(printY);
            //Thread th = new Thread(threadStart);

            //Thread th = new Thread(printY);
            //th.Start();
            //th.IsBackground = true;
            //string? x = Console.ReadLine();
            //int z=  int.Parse(x!);
            //Thread th = new Thread(()=>printNum(z));
            //th.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i==5)
            //    {
            //        th.Join();
            //    }
            //    Console.Write("X");
            //}
            //th.Join(); //make the main thread wait for the 'th' thread to finish.
            //Console.WriteLine("FINISHHHHHHHHHHHHHHH");

            //Thread th = new Thread(PrintMsg);
            //th.Start();
            ////th.Join(); // Wait for the thread to finish before proceeding
            //PrintMsg(); 
            #endregion

            //Task  task=  Task.Run(() => printY());

            #region Task
            //BeginTask()
            // for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(i);
            //    //if (i==1)
            //    //{
            //    //    task.Wait(); // Wait for the task to finish before proceeding
            //    //}
            //} 
            #endregion

        }
    }
}
