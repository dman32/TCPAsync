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
        public void updateLabelDelegate(Control control, String value, Boolean concatenate)
        {
            try
            {
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
            }
            catch { }
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
        public Server()
        {
            InitializeComponent();
            try
            {
                TCPServer.init(this, "10.0.64.211", 2055, 2056);
                update = new System.Timers.Timer();
                update.Interval = 100;
                update.Elapsed += new System.Timers.ElapsedEventHandler(update_Elapsed);
                update.Start();
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
            if (TCPServer.heartbeatListening)
                updatePanelDelegate(pnlHeartbeat, Color.Blue);
            else
                try
                {
                    if (TCPServer.heartbeatClient != null)
                        if (!TCPServer.heartbeatClient.Connected)
                        {
                            updatePanelDelegate(pnlHeartbeat, Color.Red);
                            if (!TCPServer.heartbeatListening)
                                TCPServer.heartbeatListen();
                        }else
                            updatePanelDelegate(pnlHeartbeat, Color.Green);
                }
                catch { updatePanelDelegate(pnlHeartbeat, Color.Gray); }
            if (TCPServer.dataListening)
                updatePanelDelegate(pnlData, Color.Blue);
            else
                try
                {
                    if (TCPServer.dataClient != null)
                        if (!TCPServer.dataClient.Connected)
                        {
                            updatePanelDelegate(pnlData, Color.Red);
                            if (!TCPServer.dataListening)
                                TCPServer.dataListen();
                        }
                        else
                            updatePanelDelegate(pnlData, Color.Green);
                }
                catch { updatePanelDelegate(pnlData, Color.Gray); }
        }
    }
}
