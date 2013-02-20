using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCPAsync
{
    public partial class Server : Form
    {
        System.Timers.Timer update;
        public int updateCnt = 0, heartbeatCnt = 0, dataCnt = 0;
        public Server()
        {
            InitializeComponent();
            TCPServer.init(this);
            update = new System.Timers.Timer();
            update.Interval = 100;
            update.Elapsed += new System.Timers.ElapsedEventHandler(update_Elapsed);
            update.Start();
        }

        void update_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            updateCnt++;
            lblUpdate.Text = updateCnt.ToString();
            lblDataCnt.Text = dataCnt.ToString();
            lblHeartbeatCnt.Text = heartbeatCnt.ToString();

            if (TCPServer.heartbeatListening)
                pnlHeartbeat.BackColor = Color.Blue;
            else
                try
                {
                    if (TCPServer.heartbeatClient != null)
                        if (!TCPServer.heartbeatClient.Connected)
                        {
                            pnlHeartbeat.BackColor = Color.Red;
                            if (!TCPServer.heartbeatListening)
                                TCPServer.heartbeatListen();
                        }else
                            pnlHeartbeat.BackColor = Color.Green;
                }
                catch { pnlHeartbeat.BackColor = Color.Gray; }
            if (TCPServer.dataListening)
                pnlData.BackColor = Color.Blue;
            else
                try
                {
                    if (TCPServer.dataClient != null)
                        if (!TCPServer.dataClient.Connected)
                        {
                            pnlData.BackColor = Color.Red;
                            if (!TCPServer.dataListening)
                                TCPServer.dataListen();
                        }
                        else
                            pnlData.BackColor = Color.Green;
                }
                catch { pnlData.BackColor = Color.Gray; }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Show();
        }
    }
}
