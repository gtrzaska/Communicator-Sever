namespace server {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.l1 = new System.Windows.Forms.Label();
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.nUDPort = new System.Windows.Forms.NumericUpDown();
            this.lb = new System.Windows.Forms.ListBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(12, 24);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(45, 13);
            this.l1.TabIndex = 0;
            this.l1.Text = "Address";
            // 
            // tbHostAddress
            // 
            this.tbHostAddress.Location = new System.Drawing.Point(74, 21);
            this.tbHostAddress.Name = "tbHostAddress";
            this.tbHostAddress.Size = new System.Drawing.Size(212, 20);
            this.tbHostAddress.TabIndex = 1;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(348, 24);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(26, 13);
            this.l2.TabIndex = 2;
            this.l2.Text = "Port";
            // 
            // nUDPort
            // 
            this.nUDPort.Location = new System.Drawing.Point(390, 21);
            this.nUDPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nUDPort.Name = "nUDPort";
            this.nUDPort.Size = new System.Drawing.Size(120, 20);
            this.nUDPort.TabIndex = 3;
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(15, 92);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(516, 199);
            this.lb.TabIndex = 4;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(160, 323);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(95, 23);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(288, 323);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(95, 23);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 297);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(411, 20);
            this.messageBox.TabIndex = 7;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(456, 297);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 8;
            this.send.Text = "wyslij";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 349);
            this.Controls.Add(this.send);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.nUDPort);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.tbHostAddress);
            this.Controls.Add(this.l1);
            this.Name = "Form1";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label l1;
		private System.Windows.Forms.TextBox tbHostAddress;
		private System.Windows.Forms.Label l2;
		private System.Windows.Forms.NumericUpDown nUDPort;
		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.Button bStart;
		private System.Windows.Forms.Button bStop;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox messageBox;
		private System.Windows.Forms.Button send;
	}
}

