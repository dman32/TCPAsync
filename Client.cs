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
        public void updateLabelDelegate(Control control, String value, Boolean concatenate)
        {
            try{
                if (control.InvokeRequired)
                    control.Invoke(new MethodInvoker(delegate
                    {
                        if (concatenate)
                            control.Text += value;
                        else
                            control.Text = value;
                    }));
                else
                    if (concatenate)
                        control.Text += value;
                    else
                        control.Text = value;
            }catch{}
        }
        public void updatePanelDelegate(Control control, Color value)
        {
            try
            {
                if (control.InvokeRequired)
                    control.Invoke(new MethodInvoker(delegate
                    {
                        control.BackColor = value;
                    }));
                else
                    control.BackColor = value;
            }
            catch { }
        }
        public Client()
        {

            InitializeComponent();
            try
            {
                TCPClient.init(this);
                tmrUpdate.Interval = 100;
                tmrUpdate.Elapsed += new System.Timers.ElapsedEventHandler(update_Elapsed);
                tmrUpdate.Start();
            }
            catch { }
        }

        void update_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                updateCnt++;
                updateLabelDelegate(lblUpdate, updateCnt.ToString(), false);
                updateLabelDelegate(lblDataCnt, dataCnt.ToString(), false);
                updateLabelDelegate(lblHeartbeatCnt, heartbeatCnt.ToString(), false);
            }
            catch { }
            try
            {
                updateLabelDelegate(lblHeartbeatBufferSize, TCPServer.heartbeatClient.ReceiveBufferSize.ToString(), false);
            }
            catch { updateLabelDelegate(lblHeartbeatBufferSize, "n/a", false); }
            try
            {
                updateLabelDelegate(lblDataBufferSize, TCPServer.dataClient.ReceiveBufferSize.ToString(), false);
            }
            catch { updateLabelDelegate(lblDataBufferSize, "n/a", false); }
            try
            {
                if (TCPClient.heartbeatClient.Connected)
                    updatePanelDelegate(pnlHeartbeat, Color.Green);
                else
                    updatePanelDelegate(pnlHeartbeat, Color.Red);
            }
            catch { updatePanelDelegate(pnlHeartbeat, Color.Gray); }
            try
            {
                if (TCPClient.dataClient.Connected)
                    updatePanelDelegate(pnlData, Color.Green);
                else
                    updatePanelDelegate(pnlData, Color.Red);
            }
            catch { updatePanelDelegate(pnlData, Color.Gray); }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (TCPClient.heartbeatClient == null && TCPClient.dataClient == null)
                    TCPClient.connect("10.0.64.211", 2055, 2056);
                else if (!TCPClient.heartbeatClient.Connected && !TCPClient.dataClient.Connected)
                    TCPClient.connect("10.0.64.211", 2055, 2056);
                else
                    TCPClient.disconnect();
            }
            catch { }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            TCPClient.disconnect();
        }
    }
}
