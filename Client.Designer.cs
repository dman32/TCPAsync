namespace TCPAsync
{
    partial class Client
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
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlHeartbeat = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblHeartbeatCnt = new System.Windows.Forms.Label();
            this.lblDataCnt = new System.Windows.Forms.Label();
            this.lblHeartbeatBufferSize = new System.Windows.Forms.Label();
            this.lblDataBufferSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Location = new System.Drawing.Point(12, 51);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(20, 20);
            this.pnlData.TabIndex = 6;
            // 
            // pnlHeartbeat
            // 
            this.pnlHeartbeat.Location = new System.Drawing.Point(12, 25);
            this.pnlHeartbeat.Name = "pnlHeartbeat";
            this.pnlHeartbeat.Size = new System.Drawing.Size(20, 20);
            this.pnlHeartbeat.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(268, 184);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Update Timer:";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(89, 9);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblUpdate.TabIndex = 4;
            this.lblUpdate.Text = "label1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(205, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblHeartbeatCnt
            // 
            this.lblHeartbeatCnt.AutoSize = true;
            this.lblHeartbeatCnt.Location = new System.Drawing.Point(38, 29);
            this.lblHeartbeatCnt.Name = "lblHeartbeatCnt";
            this.lblHeartbeatCnt.Size = new System.Drawing.Size(35, 13);
            this.lblHeartbeatCnt.TabIndex = 4;
            this.lblHeartbeatCnt.Text = "label1";
            // 
            // lblDataCnt
            // 
            this.lblDataCnt.AutoSize = true;
            this.lblDataCnt.Location = new System.Drawing.Point(38, 55);
            this.lblDataCnt.Name = "lblDataCnt";
            this.lblDataCnt.Size = new System.Drawing.Size(35, 13);
            this.lblDataCnt.TabIndex = 4;
            this.lblDataCnt.Text = "label1";
            // 
            // lblHeartbeatBufferSize
            // 
            this.lblHeartbeatBufferSize.AutoSize = true;
            this.lblHeartbeatBufferSize.Location = new System.Drawing.Point(79, 29);
            this.lblHeartbeatBufferSize.Name = "lblHeartbeatBufferSize";
            this.lblHeartbeatBufferSize.Size = new System.Drawing.Size(35, 13);
            this.lblHeartbeatBufferSize.TabIndex = 4;
            this.lblHeartbeatBufferSize.Text = "label1";
            // 
            // lblDataBufferSize
            // 
            this.lblDataBufferSize.AutoSize = true;
            this.lblDataBufferSize.Location = new System.Drawing.Point(79, 55);
            this.lblDataBufferSize.Name = "lblDataBufferSize";
            this.lblDataBufferSize.Size = new System.Drawing.Size(35, 13);
            this.lblDataBufferSize.TabIndex = 4;
            this.lblDataBufferSize.Text = "label1";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlHeartbeat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDataCnt);
            this.Controls.Add(this.lblDataBufferSize);
            this.Controls.Add(this.lblHeartbeatBufferSize);
            this.Controls.Add(this.lblHeartbeatCnt);
            this.Controls.Add(this.lblUpdate);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlData;
        public System.Windows.Forms.Panel pnlHeartbeat;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblHeartbeatCnt;
        private System.Windows.Forms.Label lblDataCnt;
        private System.Windows.Forms.Label lblHeartbeatBufferSize;
        private System.Windows.Forms.Label lblDataBufferSize;
    }
}