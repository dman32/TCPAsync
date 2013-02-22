using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace TCPAsync
{
    abstract class TCPServer
    {
        private static Server server;
        public static Socket heartbeatServer, heartbeatClient, dataServer, dataClient;
        public static Boolean heartbeatListening = false, dataListening = false;
        private static byte[] heartbeatBytes, dataBytes;
        
        private static String msg = String.Empty, startInd = "##START##", endInd = "##END##";

        private static System.Timers.Timer tmrHeartbeatBlip, tmrDataBlip;
        public static void init(Server pserver, String ipAddress, int heartbeatPort, int dataPort)
        {
            try
            {
                server = pserver;
                heartbeatServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                heartbeatServer.Bind(new IPEndPoint(IPAddress.Parse(ipAddress), heartbeatPort));
                heartbeatServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
                heartbeatServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                heartbeatServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, true);

                tmrHeartbeatBlip = new System.Timers.Timer();
                tmrHeartbeatBlip.Interval = 25;
                tmrHeartbeatBlip.AutoReset = false;
                tmrHeartbeatBlip.Elapsed += new System.Timers.ElapsedEventHandler(tmrHeatbeatBlip_Elapsed);

                dataServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                dataServer.Bind(new IPEndPoint(IPAddress.Parse(ipAddress), dataPort));
                dataServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
                dataServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                dataServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, true);

                tmrDataBlip = new System.Timers.Timer();
                tmrDataBlip.Interval = 25;
                tmrDataBlip.AutoReset = false;
                tmrDataBlip.Elapsed += new System.Timers.ElapsedEventHandler(tmrDataBlip_Elapsed);

                heartbeatListen();
                dataListen();
            }
            catch { }
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
                heartbeatBytes = new byte[heartbeatClient.ReceiveBufferSize];
                heartbeatClient.BeginReceive(heartbeatBytes, 0, heartbeatBytes.Length, SocketFlags.None, new AsyncCallback(heartbeatReceived), heartbeatClient);
            }
            catch (Exception ex)
            {
                server.textBox1.Text += ex.Message + Environment.NewLine;
            }
        }
        private static void heartbeatReceived(IAsyncResult ar)
        {
            try
            {
                heartbeatClient = (Socket)ar.AsyncState;
                if (heartbeatClient.EndReceive(ar) > 0)
                {
                    server.heartbeatCnt++;
                    heartbeatClient.BeginReceive(heartbeatBytes, 0, heartbeatBytes.Length, SocketFlags.None, new AsyncCallback(heartbeatReceived), heartbeatClient);
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
                dataBytes = new byte[dataClient.ReceiveBufferSize];
                dataClient.BeginReceive(dataBytes, 0, dataBytes.Length, SocketFlags.None, new AsyncCallback(dataReceived), dataClient);
            }
            catch (Exception ex)
            {
                server.textBox1.Text += ex.Message + Environment.NewLine;
            }
        }
        private static void dataReceived(IAsyncResult ar)
        {
            try
            {
                dataClient = (Socket)ar.AsyncState;
                int rec = dataClient.EndReceive(ar);
                if (rec > 0)
                {
                    server.pnlData.BackColor = System.Drawing.Color.GreenYellow;
                    tmrDataBlip.Start();
                    server.dataCnt++;
                    String str = Utilities.GetStringFromBytes(dataBytes).Substring(0, rec);
                    msg += str;
                    parse();
                    dataClient.BeginReceive(dataBytes, 0, dataBytes.Length, SocketFlags.None, new AsyncCallback(dataReceived), dataClient);
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
        private static void parse()
        {
            int start = msg.IndexOf(startInd);
            if (start >= 0)
            {
                int end = msg.IndexOf(endInd, start);
                if (end >= 0)
                {
                    server.textBox1.Text += msg.Substring(start + startInd.Length, end - start - startInd.Length).Length.ToString();
                    msg = msg.Remove(0, end + endInd.Length);
                }
            }
        }
        static void tmrDataBlip_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            server.pnlData.BackColor = System.Drawing.Color.Green;
        }
    }
}
