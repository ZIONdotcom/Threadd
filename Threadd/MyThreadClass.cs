using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threadd
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 1; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Nmae of thread: " + thread.Name + " = " + i);
                Thread.Sleep(500);
            }

            
        }
        public static void Thread2()
        {
            for (int i = 1; i <= 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Nmae of thread: " + thread.Name + " = "+ i);
                Thread.Sleep(1500);
            }
           
        }
    }
}
