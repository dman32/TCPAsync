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
    public partial class ClientSettings : Form
    {
        public ClientSettings()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            txtIPAddress.Text = Configuration.get("serveripaddress");
            numDisplayDelay.Value = int.Parse(Configuration.get("clientupdatedelay"));
            numDataDelay.Value = int.Parse(Configuration.get("clientdatadelay"));
            numHeartbeatDelay.Value = int.Parse(Configuration.get("clientheartbeatdelay"));
            numDataPort.Value = int.Parse(Configuration.get("dataport"));
            numHeartbeatPort.Value = int.Parse(Configuration.get("heartbeatport"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration.set("serveripaddress",txtIPAddress.Text);
            Configuration.set("clientupdatedelay", numDisplayDelay.Value.ToString());
            Configuration.set("clientdatadelay",numDataDelay.Value.ToString());
            Configuration.set("clientheartbeatdelay",numHeartbeatDelay.Value.ToString());
            Configuration.set("dataport",numDataPort.Value.ToString());
            Configuration.set("heartbeatport",numHeartbeatPort.Value.ToString());
            Configuration.save();
            this.Close();
        }
    }
}
