using HNInc.Communication.Library;
using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class SocketTest
    {
        static void Main(string[] args)
        {
            HNSocketIO hNSocketIO;
            hNSocketIO = new HNSocketIO(new Uri("http://9.8.100.153:8082/"), SocketIOClient.Transport.TransportProtocol.WebSocket, new TimeSpan(TimeSpan.TicksPerMinute), 4);
            //hNSocketIO = new HNSocketIO();
            hNSocketIO.Connect();
            hNSocketIO.SocketConnectedEvent += Test2;
            hNSocketIO.SocketConnectingEvent += Test3;
            hNSocketIO.SocketDisConnectedEvent += Test4;
            hNSocketIO.AnyDataEvent += Test1;
            hNSocketIO.ReceiveAnyData();
            void Test1(string a, Object b)
            {
                Console.WriteLine(b.ToString());
                Console.WriteLine(a);
            }
            void Test2(object a, object b)
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine(b.ToString());
                hNSocketIO.SendData(SocketEventNames.RTLoadData);
                hNSocketIO.SendData(SocketEventNames.RTLossData);
            }
            void Test3(object a, object b)
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine(b.ToString());
            }
            void Test4(object a, object b)
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine(b.ToString());
            }
            Console.ReadLine();
        }
    }
}
