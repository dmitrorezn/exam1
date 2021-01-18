using System;
using System.Threading;
using System.Threading.Tasks;

namespace examLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new LIFO(10);

            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    PushAndGet(stack);
                });
            }
            Thread.Sleep(1000);
            Console.WriteLine(stack.Count());

            Console.ReadLine();
        }
        private static void PushAndGet(LIFO stack)
        {
            for (int i = 0; i < stack.Length; i++)
            {
                stack.Push(i);
                stack.Get();
                Console.WriteLine("pushed got");
            }

            Console.WriteLine("Finished");
        }
    }
}