namespace TCPAsync
{
    partial class ServerSettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numDisplayDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numHeartbeatDelay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numHeartbeatPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numDataDelay = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numDataPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDisplayDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeartbeatDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeartbeatPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDataDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Update Delay:";
            // 
            // numDisplayDelay
            // 
            this.numDisplayDelay.Location = new System.Drawing.Point(267, 12);
            this.numDisplayDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDisplayDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDisplayDelay.Name = "numDisplayDelay";
            this.numDisplayDelay.Size = new System.Drawing.Size(107, 20);
            this.numDisplayDelay.TabIndex = 2;
            this.numDisplayDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Send Delay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ms";
            // 
            // numHeartbeatDelay
            // 
            this.numHeartbeatDelay.Location = new System.Drawing.Point(77, 19);
            this.numHeartbeatDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHeartbeatDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeartbeatDelay.Name = "numHeartbeatDelay";
            this.numHeartbeatDelay.Size = new System.Drawing.Size(107, 20);
            this.numHeartbeatDelay.TabIndex = 2;
            this.numHeartbeatDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ms";
            // 
            // numHeartbeatPort
            // 
            this.numHeartbeatPort.Location = new System.Drawing.Point(77, 45);
            this.numHeartbeatPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHeartbeatPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeartbeatPort.Name = "numHeartbeatPort";
            this.numHeartbeatPort.Size = new System.Drawing.Size(107, 20);
            this.numHeartbeatPort.TabIndex = 2;
            this.numHeartbeatPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numHeartbeatDelay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numHeartbeatPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heartbeat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numDataDelay);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numDataPort);
            this.groupBox2.Location = new System.Drawing.Point(287, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // numDataDelay
            // 
            this.numDataDelay.Location = new System.Drawing.Point(77, 19);
            this.numDataDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDataDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDataDelay.Name = "numDataDelay";
            this.numDataDelay.Size = new System.Drawing.Size(107, 20);
            this.numDataDelay.TabIndex = 2;
            this.numDataDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Send Delay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Port:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ms";
            // 
            // numDataPort
            // 
            this.numDataPort.Location = new System.Drawing.Point(77, 45);
            this.numDataPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDataPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDataPort.Name = "numDataPort";
            this.numDataPort.Size = new System.Drawing.Size(107, 20);
            this.numDataPort.TabIndex = 2;
            this.numDataPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 187);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numDisplayDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerSettings";
            this.Text = "ServerSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numDisplayDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeartbeatDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeartbeatPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDataDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDisplayDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHeartbeatDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numHeartbeatPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numDataDelay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDataPort;
    }
}