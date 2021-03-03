using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading_Sample
{
    class Program
    {
        static void PrintTheNmbers(object state)
        {
            Printer task = (Printer)state;
            task.printNumbers();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*****Multithreading Program*****\n");
            Console.WriteLine("main thread started.ThreadId ={0}", Thread.CurrentThread.ManagedThreadId);
            Printer p = new Printer();
            WaitCallback workItem = new WaitCallback(PrintTheNmbers);

            for(int i=0; i<10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }
            Console.WriteLine("All tasks queued");
            Console.ReadLine();

        }
    }
}
