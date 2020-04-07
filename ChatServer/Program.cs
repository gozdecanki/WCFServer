using System;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHAT SERVER");
            Helper.WcfServer.Run<Data.ChatService, Data.IChat>("127.0.0.1",8383,"chatservice");

            Console.ReadLine();
        }
    }
}
