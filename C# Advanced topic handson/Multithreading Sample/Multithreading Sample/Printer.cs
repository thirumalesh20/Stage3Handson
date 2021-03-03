using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Sample
{
    public class Printer
    {
        private object lockToken = new object();
        public void printNumbers()
        {
            lock(lockToken)
            {
                Console.WriteLine("Thread->{0} strated @{1} and executing PrintNumbers() method", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToLongDateString());

                Console.Write("Your numbers:");
                for(int i=0; i<10; i++)
                {
                    Console.Write("{0},", i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine();

            }
        }
    }
}
