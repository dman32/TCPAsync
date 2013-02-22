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
    public partial class ServerSettings : Form
    {
        public ServerSettings()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            numDisplayDelay.Value = int.Parse(Configuration.get("serverupdatedelay"));
            numDataDelay.Value = int.Parse(Configuration.get("serverdatadelay"));
            numHeartbeatDelay.Value = int.Parse(Configuration.get("serverheartbeatdelay"));
            numDataPort.Value = int.Parse(Configuration.get("dataport"));
            numHeartbeatPort.Value = int.Parse(Configuration.get("heartbeatport"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration.set("serverupdatedelay", numDisplayDelay.Value.ToString());
            Configuration.set("serverdatadelay",numDataDelay.Value.ToString());
            Configuration.set("serverheartbeatdelay",numHeartbeatDelay.Value.ToString());
            Configuration.set("dataport",numDataPort.Value.ToString());
            Configuration.set("heartbeatport",numHeartbeatPort.Value.ToString());
            Configuration.save();
            this.Close();
        }
    }
}
