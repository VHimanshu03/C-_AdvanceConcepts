using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }

        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");  //waits until LongTask is finished.
        }

        public static void LongTask()
        {
            Thread.Sleep(20000);
        }
    }
    class Test
    {

    }
}
