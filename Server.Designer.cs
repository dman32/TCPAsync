namespace TCPAsync
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUpdate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHeartbeat = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblHeartbeatCnt = new System.Windows.Forms.Label();
            this.lblDataCnt = new System.Windows.Forms.Label();
            this.lblHeartbeatBufferSize = new System.Windows.Forms.Label();
            this.lblDataBufferSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(89, 9);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblUpdate.TabIndex = 0;
            this.lblUpdate.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(268, 184);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update Timer:";
            // 
            // pnlHeartbeat
            // 
            this.pnlHeartbeat.Location = new System.Drawing.Point(12, 25);
            this.pnlHeartbeat.Name = "pnlHeartbeat";
            this.pnlHeartbeat.Size = new System.Drawing.Size(20, 20);
            this.pnlHeartbeat.TabIndex = 2;
            // 
            // pnlData
            // 
            this.pnlData.Location = new System.Drawing.Point(12, 51);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(20, 20);
            this.pnlData.TabIndex = 2;
            // 
            // lblHeartbeatCnt
            // 
            this.lblHeartbeatCnt.AutoSize = true;
            this.lblHeartbeatCnt.Location = new System.Drawing.Point(38, 29);
            this.lblHeartbeatCnt.Name = "lblHeartbeatCnt";
            this.lblHeartbeatCnt.Size = new System.Drawing.Size(35, 13);
            this.lblHeartbeatCnt.TabIndex = 0;
            this.lblHeartbeatCnt.Text = "label1";
            // 
            // lblDataCnt
            // 
            this.lblDataCnt.AutoSize = true;
            this.lblDataCnt.Location = new System.Drawing.Point(38, 55);
            this.lblDataCnt.Name = "lblDataCnt";
            this.lblDataCnt.Size = new System.Drawing.Size(35, 13);
            this.lblDataCnt.TabIndex = 0;
            this.lblDataCnt.Text = "label1";
            // 
            // lblHeartbeatBufferSize
            // 
            this.lblHeartbeatBufferSize.AutoSize = true;
            this.lblHeartbeatBufferSize.Location = new System.Drawing.Point(79, 29);
            this.lblHeartbeatBufferSize.Name = "lblHeartbeatBufferSize";
            this.lblHeartbeatBufferSize.Size = new System.Drawing.Size(35, 13);
            this.lblHeartbeatBufferSize.TabIndex = 0;
            this.lblHeartbeatBufferSize.Text = "label1";
            // 
            // lblDataBufferSize
            // 
            this.lblDataBufferSize.AutoSize = true;
            this.lblDataBufferSize.Location = new System.Drawing.Point(79, 55);
            this.lblDataBufferSize.Name = "lblDataBufferSize";
            this.lblDataBufferSize.Size = new System.Drawing.Size(35, 13);
            this.lblDataBufferSize.TabIndex = 0;
            this.lblDataBufferSize.Text = "label1";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlHeartbeat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDataCnt);
            this.Controls.Add(this.lblDataBufferSize);
            this.Controls.Add(this.lblHeartbeatBufferSize);
            this.Controls.Add(this.lblHeartbeatCnt);
            this.Controls.Add(this.lblUpdate);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdate;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel pnlHeartbeat;
        public System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblHeartbeatCnt;
        private System.Windows.Forms.Label lblDataCnt;
        private System.Windows.Forms.Label lblHeartbeatBufferSize;
        private System.Windows.Forms.Label lblDataBufferSize;

    }
}

