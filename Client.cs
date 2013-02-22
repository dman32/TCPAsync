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
    public partial class Client : Form
    {
        System.Timers.Timer tmrUpdate = new System.Timers.Timer();
        public int updateCnt = 0, heartbeatCnt = 0, dataCnt = 0;
        public Client()
        {
            InitializeComponent();
            TCPClient.init(this);
            tmrUpdate.Interval = 100;
            tmrUpdate.Elapsed += new System.Timers.ElapsedEventHandler(update_Elapsed);
            tmrUpdate.Start();
        }

        void update_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            updateCnt++;
            lblUpdate.Text = updateCnt.ToString();
            lblDataCnt.Text = dataCnt.ToString();
            lblHeartbeatCnt.Text = heartbeatCnt.ToString();
            try
            {
                lblHeartbeatBufferSize.Text = TCPServer.heartbeatClient.ReceiveBufferSize.ToString();
            }
            catch { lblHeartbeatBufferSize.Text = "n/a"; }
            try
            {
                lblDataBufferSize.Text = TCPServer.dataClient.ReceiveBufferSize.ToString();
            }
            catch { lblDataBufferSize.Text = "n/a"; }
            try
            {
                if (TCPClient.heartbeatClient.Connected)
                    pnlHeartbeat.BackColor = Color.Green;
                else
                    pnlHeartbeat.BackColor = Color.Red;
            }
            catch { pnlHeartbeat.BackColor = Color.Gray; }
            try
            {
                if (TCPClient.dataClient.Connected)
                    pnlData.BackColor = Color.Green;
                else
                    pnlData.BackColor = Color.Red;
            }
            catch { pnlData.BackColor = Color.Gray; }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (TCPClient.heartbeatClient == null)
                TCPClient.connect("195.0.0.187", 2055, 2056);
            else if (!TCPClient.heartbeatClient.Connected)
                TCPClient.connect("195.0.0.187", 2055, 2056);
            else
                TCPClient.disconnect();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            TCPClient.disconnect();
        }
    }
}
