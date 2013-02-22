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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(247, 12);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblUpdate.TabIndex = 0;
            this.lblUpdate.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(424, 199);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update Timer:";
            // 
            // pnlHeartbeat
            // 
            this.pnlHeartbeat.Location = new System.Drawing.Point(6, 19);
            this.pnlHeartbeat.Name = "pnlHeartbeat";
            this.pnlHeartbeat.Size = new System.Drawing.Size(20, 20);
            this.pnlHeartbeat.TabIndex = 2;
            // 
            // pnlData
            // 
            this.pnlData.Location = new System.Drawing.Point(6, 19);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(20, 20);
            this.pnlData.TabIndex = 2;
            // 
            // lblHeartbeatCnt
            // 
            this.lblHeartbeatCnt.AutoSize = true;
            this.lblHeartbeatCnt.Location = new System.Drawing.Point(32, 23);
            this.lblHeartbeatCnt.Name = "lblHeartbeatCnt";
            this.lblHeartbeatCnt.Size = new System.Drawing.Size(35, 13);
            this.lblHeartbeatCnt.TabIndex = 0;
            this.lblHeartbeatCnt.Text = "label1";
            // 
            // lblDataCnt
            // 
            this.lblDataCnt.AutoSize = true;
            this.lblDataCnt.Location = new System.Drawing.Point(32, 23);
            this.lblDataCnt.Name = "lblDataCnt";
            this.lblDataCnt.Size = new System.Drawing.Size(35, 13);
            this.lblDataCnt.TabIndex = 0;
            this.lblDataCnt.Text = "label1";
            // 
            // lblHeartbeatBufferSize
            // 
            this.lblHeartbeatBufferSize.AutoSize = true;
            this.lblHeartbeatBufferSize.Location = new System.Drawing.Point(73, 23);
            this.lblHeartbeatBufferSize.Name = "lblHeartbeatBufferSize";
            this.lblHeartbeatBufferSize.Size = new System.Drawing.Size(35, 13);
            this.lblHeartbeatBufferSize.TabIndex = 0;
            this.lblHeartbeatBufferSize.Text = "label1";
            // 
            // lblDataBufferSize
            // 
            this.lblDataBufferSize.AutoSize = true;
            this.lblDataBufferSize.Location = new System.Drawing.Point(73, 23);
            this.lblDataBufferSize.Name = "lblDataBufferSize";
            this.lblDataBufferSize.Size = new System.Drawing.Size(35, 13);
            this.lblDataBufferSize.TabIndex = 0;
            this.lblDataBufferSize.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlHeartbeat);
            this.groupBox1.Controls.Add(this.lblHeartbeatCnt);
            this.groupBox1.Controls.Add(this.lblHeartbeatBufferSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heartbeat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlData);
            this.groupBox2.Controls.Add(this.lblDataBufferSize);
            this.groupBox2.Controls.Add(this.lblDataCnt);
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Server";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;

    }
}

