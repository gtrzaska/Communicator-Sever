using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace server {
	public partial class Form1 : Form {

		private TcpListener server;
		private TcpClient client;
		private BinaryReader reader;
		private BinaryWriter writer;
		private bool activeCall = false;

		string lastMessage = "";

		public Form1() {
			InitializeComponent();
		}

		private void bStart_Click(object sender, EventArgs e) {
			IPAddress adresIP = null;
        //   bStop.Enabled = true;
        //    bStart.Enabled = false;
				
			

			try {
				adresIP = IPAddress.Parse(tbHostAddress.Text);
			}
			catch {
				MessageBox.Show("Błędny format adresu IP!", "Błąd");
				if (tbHostAddress.InvokeRequired || tbHostAddress.InvokeRequired) {
					tbHostAddress.Invoke(new MethodInvoker(delegate { tbHostAddress.Text = String.Empty; }));
				}
				return;
			}

			int port = System.Convert.ToInt16(nUDPort.Value);

			try {
                bStart.Enabled = false;
                bStop.Enabled = true;
				server = new TcpListener(adresIP, port);
				server.Start();
				client = server.AcceptTcpClient();
                
                NetworkStream ns = client.GetStream();
				reader = new BinaryReader(ns);
				writer = new BinaryWriter(ns);

				IPEndPoint IP = (IPEndPoint)client.Client.RemoteEndPoint;
				lb.Invoke(new MethodInvoker(delegate { lb.Items.Add("[" + IP.ToString() + "] Nawiązano połączenie"); }));
               
				if (reader.ReadString() == "password") {
					backgroundWorker1.RunWorkerAsync();
					activeCall = true;
				}
				else {
					client.Close();
					server.Stop();
					activeCall = false;
				}
			}
			catch (Exception ex) {
				lb.Invoke(new MethodInvoker(delegate { lb.Items.Add("Błąd inicjacji serwera!"); }));
				MessageBox.Show(ex.ToString(), "Błąd");
			}
		}

		private void bStop_Click(object sender, EventArgs e) {
			server.Stop();
			client.Close();

			backgroundWorker1.CancelAsync();

			lb.Items.Add("Zakończono pracę serwera.");
			bStart.Enabled = true;
			bStop.Enabled = false;
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
			if (activeCall) {
				string message ="";
				while (message != "END" ) {
                    message = reader.ReadString();
                    if (message != lastMessage) { 
					lb.Invoke(new MethodInvoker(delegate { lb.Items.Add(message); }));
					lastMessage = message;}
				}
			}
		}


		private void send_Click(object sender, EventArgs e) {
			string message = "Server: " + messageBox.Text;
			writer.Write(message);
			lb.Invoke(new MethodInvoker(delegate { lb.Items.Add(message); }));
		}
	}
}
