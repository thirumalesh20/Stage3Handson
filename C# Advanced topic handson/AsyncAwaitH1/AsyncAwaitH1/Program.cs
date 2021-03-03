using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.FirstMethod();
            Console.ReadKey();
        }

        public async Task FirstMethod()
        {
            string res = await SecondMethod();
            Console.WriteLine(res);
        }
        public async Task<string> SecondMethod()
        {
            Console.WriteLine("Returning string.. Please wait...");
            Thread.Sleep(5000);
            return "Method 2 Executed";
        }
    }
}