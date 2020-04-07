using System;
using Data;
using Helper;
using System.Threading;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLIENT");
            ITest test = WcfClient<ITest>.Channel("http://127.0.0.1:8080/bilgeadam");
            while (true)
            {
                var serverDate = test.GetServerTime();
                Console.WriteLine(serverDate);

                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
