using System;
using System.Threading.Tasks;

namespace WorkingWithThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();
            //Method2();
            M1M2();
            Console.WriteLine("######### END OF MAIN THREAD ##########");
        }

        static void M1M2()
        {
            Method1();
            Method2();
        }

        public static async Task Method1()
        {
            //await Method2();
            await Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"Method 1: {i}");
                }
            });
        }

        public static void Method2()
        {
            for (int i = 2000; i < 3000; i++)
            {
                Console.WriteLine($"Method 2: {i}");
            }
        }
    }
}
