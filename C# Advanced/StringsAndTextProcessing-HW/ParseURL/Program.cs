namespace ParseURL
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string address = Console.ReadLine();
            int protocolIndex = address.IndexOf(":");
            string protocol = address.Substring(0, protocolIndex);
            Console.WriteLine("[protocol] = {0}", protocol);
            int serverIndex = address.IndexOf("/", protocolIndex + 3);
            //Console.WriteLine(serverIndex);
            string server = address.Substring((protocolIndex + 3), (serverIndex - protocolIndex - 3));
            Console.WriteLine("[server] = {0}", server);
            string resource = address.Substring(serverIndex, address.Length - serverIndex);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
