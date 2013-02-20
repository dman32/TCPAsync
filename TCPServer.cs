using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TCPAsync
{
    abstract class TCPServer
    {
        private static Server server;
        public static Socket heartbeatServer, heartbeatClient, dataServer, dataClient;
        public static Boolean heartbeatListening = false, dataListening = false;
        private static byte[] heartbeatBytes = new byte[1024], dataBytes = new byte[1024];
        private static System.Timers.Timer tmrHeartbeatBlip, tmrDataBlip;
        public static void init(Server pserver)
        {
            server = pserver;
            heartbeatServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            heartbeatServer.Bind(new IPEndPoint(IPAddress.Parse("10.0.64.211"), 2055));
            heartbeatServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
            heartbeatServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            tmrHeartbeatBlip = new System.Timers.Timer();
            tmrHeartbeatBlip.Interval = 250;
            tmrHeartbeatBlip.AutoReset = false;
            tmrHeartbeatBlip.Elapsed += new System.Timers.ElapsedEventHandler(tmrHeatbeatBlip_Elapsed);
            
            dataServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            dataServer.Bind(new IPEndPoint(IPAddress.Parse("10.0.64.211"), 2056));
            dataServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
            dataServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            tmrDataBlip = new System.Timers.Timer();
            tmrDataBlip.Interval = 250;
            tmrDataBlip.AutoReset = false;
            tmrDataBlip.Elapsed += new System.Timers.ElapsedEventHandler(tmrDataBlip_Elapsed);

            heartbeatListen();
            dataListen();
        }



        public static void heartbeatListen()
        {
            try
            {
                if (!heartbeatListening)
                {
                    heartbeatListening = true;
                    heartbeatServer.Listen(1);
                    heartbeatServer.BeginAccept(new AsyncCallback(heartbeatAccept), heartbeatServer);
                }
            }
            catch (Exception ex)
            {
                server.textBox1.Text += ex.Message + Environment.NewLine;
            }
        }
        private static void heartbeatAccept(IAsyncResult ar)
        {
            try
            {
                heartbeatListening = false;
                heartbeatClient = ((Socket)ar.AsyncState).EndAccept(ar);
                heartbeatClient.BeginReceive(heartbeatBytes, 0, heartbeatBytes.Length, SocketFlags.None, new AsyncCallback(heartbeatReceive), heartbeatClient);
            }
            catch (Exception ex)
            {
                server.textBox1.Text += ex.Message + Environment.NewLine;
            }
        }
        private static void heartbeatReceive(IAsyncResult ar)
        {
            try
            {
                heartbeatClient = (Socket)ar.AsyncState;
                if (heartbeatClient.EndReceive(ar) > 0)
                {
                    server.heartbeatCnt++;
                    heartbeatClient.BeginReceive(heartbeatBytes, 0, heartbeatBytes.Length, SocketFlags.None, new AsyncCallback(heartbeatReceive), heartbeatClient);
                    //server.textBox1.Text += System.Text.Encoding.UTF8.GetString(heartbeatBytes);
                    server.pnlHeartbeat.BackColor = System.Drawing.Color.GreenYellow;
                    tmrHeartbeatBlip.Start();
                }
                else
                {
                    heartbeatClient.Shutdown(SocketShutdown.Both);
                    heartbeatClient.Close();
                }
            }
            catch(Exception ex)
            {
                server.textBox1.Text += ex.Message + Environment.NewLine;
            }
        }
        static void tmrHeatbeatBlip_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            server.pnlHeartbeat.BackColor = System.Drawing.Color.Green;
        }

        public static void dataListen()
        {
            try
            {
                if (!dataListening)
                {
                    dataListening = true;
                    dataServer.Listen(1);
                    dataServer.BeginAccept(new AsyncCallback(dataAccept), dataServer);
                }
            }
            catch (Exception ex)
            {
                server.textBox1.Text += ex.Message + Environment.NewLine;
            }
        }
        private static void dataAccept(IAsyncResult ar)
        {
            try
            {
                dataListening = false;
                dataClient = ((Socket)ar.AsyncState).EndAccept(ar);
                dataClient.BeginReceive(dataBytes, 0, dataBytes.Length, SocketFlags.None, new AsyncCallback(dataReceive), dataClient);
            }
            catch (Exception ex)
            {
                server.textBox1.Text += ex.Message + Environment.NewLine;
            }
        }
        private static void dataReceive(IAsyncResult ar)
        {
            try
            {
                dataClient = (Socket)ar.AsyncState;
                if (dataClient.EndReceive(ar) > 0)
                {
                    server.dataCnt++;
                    dataClient.BeginReceive(dataBytes, 0, dataBytes.Length, SocketFlags.None, new AsyncCallback(dataReceive), dataClient);
                    server.pnlData.BackColor = System.Drawing.Color.GreenYellow;
                    tmrDataBlip.Start();
                }
                else
                {
                    dataClient.Shutdown(SocketShutdown.Both);
                    dataClient.Close();
                }
            }
            catch (Exception ex)
            {
                server.textBox1.Text += ex.StackTrace + Environment.NewLine;
            }
        }
        static void tmrDataBlip_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            server.pnlData.BackColor = System.Drawing.Color.Green;
        }
    }
}
