using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Queues Q = new Queues(10);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);
            Q.insert(60);
            Q.insert(70);
            Q.insert(80);
            Q.insert(90);
            Q.insert(100);

            Console.WriteLine(Q.printQueues());

            Q.delete();
            Q.delete();

            Console.WriteLine(Q.printQueues());
            Console.ReadKey();
        }

    }
}
