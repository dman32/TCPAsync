using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TCPAsync
{
    abstract class TCPClient
    {
        public static Client client;
        private static System.Timers.Timer tmrHeartbeat, tmrHeartbeatBlip, tmrData, tmrDataBlip;
        public static Socket heartbeatClient, dataClient;
        public static byte[] heartbeatBytes = new byte[] { (byte)'h', (byte)'a', (byte)'r', (byte)'t', (byte)'b', (byte)'e', (byte)'a', (byte)'t' }, dataBytes= new byte[]{(byte)'h',(byte)'i'};
        public static void init(Client pclient)
        {
            client = pclient;

            tmrHeartbeat = new System.Timers.Timer();
            tmrHeartbeat.Interval = 200;
            tmrHeartbeat.Elapsed += new System.Timers.ElapsedEventHandler(tmrHeartbeat_Elapsed);

            tmrHeartbeatBlip = new System.Timers.Timer();
            tmrHeartbeatBlip.Interval = 250;
            tmrHeartbeatBlip.AutoReset = false;
            tmrHeartbeatBlip.Elapsed += new System.Timers.ElapsedEventHandler(tmrHeatbeatBlip_Elapsed);

            tmrData = new System.Timers.Timer();
            tmrData.Interval = 100;
            tmrData.Elapsed += new System.Timers.ElapsedEventHandler(tmrData_Elapsed);

            tmrDataBlip = new System.Timers.Timer();
            tmrDataBlip.Interval = 250;
            tmrDataBlip.AutoReset = false;
            tmrDataBlip.Elapsed += new System.Timers.ElapsedEventHandler(tmrDataBlip_Elapsed);
        }
        public static void connect()
        {
            try
            {
                heartbeatClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                heartbeatClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                heartbeatClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
                heartbeatClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                heartbeatClient.BeginConnect(new IPEndPoint(IPAddress.Parse("10.0.64.211"), 2055), new AsyncCallback(heartbeatConnect), heartbeatClient);

                dataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                dataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                dataClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
                dataClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                dataClient.BeginConnect(new IPEndPoint(IPAddress.Parse("10.0.64.211"), 2056), new AsyncCallback(dataConnect), dataClient);
            }
            catch { }
        }
        public static void disconnect()
        {
            try
            {
                heartbeatClient.Shutdown(SocketShutdown.Both);
                heartbeatClient.Disconnect(true);
                dataClient.Shutdown(SocketShutdown.Both);
                dataClient.Disconnect(true);
            }
            catch
            {

            }
        }

        static void tmrData_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                dataClient.BeginSend(dataBytes, 0, dataBytes.Length, SocketFlags.None, new AsyncCallback(dataSend), null);
            }
            catch { }
        }
        public static void dataConnect(IAsyncResult ar)
        {
            try
            {
                dataClient.EndConnect(ar);
                tmrData.Start();
            }
            catch { }
        }
        private static void dataSend(IAsyncResult ar)
        {
            try
            {
                client.pnlData.BackColor = System.Drawing.Color.GreenYellow;
                tmrDataBlip.Start();
                dataClient.EndSend(ar);
                client.dataCnt++;
            }
            catch { }
        }
        static void tmrDataBlip_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                client.pnlData.BackColor = System.Drawing.Color.Green;
            }
            catch { }
        }
        
        static void tmrHeatbeatBlip_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try{
                client.pnlHeartbeat.BackColor = System.Drawing.Color.Green;
            }
            catch { }
        }
        static void tmrHeartbeat_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try{
                heartbeatClient.BeginSend(heartbeatBytes, 0, heartbeatBytes.Length, SocketFlags.None, new AsyncCallback(heartbeatSend), null);
            }
            catch { }
        }
        public static void heartbeatConnect(IAsyncResult ar)
        {
            try
            {
                heartbeatClient.EndConnect(ar);
                tmrHeartbeat.Start();
            }
            catch { }
        }
        private static void heartbeatSend(IAsyncResult ar)
        {
            try
            {
                client.pnlHeartbeat.BackColor = System.Drawing.Color.GreenYellow;
                tmrHeartbeatBlip.Start();
                heartbeatClient.EndSend(ar);
                client.heartbeatCnt++;
            }
            catch { }
        }
        
    }
}
