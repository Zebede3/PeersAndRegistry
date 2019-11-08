using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace PeersAndRegistry {
    public partial class GetCredentials : Form {

        string ip;
        string user;
        string pass;
        int port;


        public GetCredentials() {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void Test_button_Click(object sender, EventArgs e) {
            // Quick test to see if the ssh connection will be completed

            port = int.Parse(port_box.Text);

            ConnectionInfo connectionInfo = new ConnectionInfo(ipaddr_box.Text, port, login_box.Text,
                    new PasswordAuthenticationMethod(login_box.Text, pass_box.Text)
                );

            using (var client = new SshClient(connectionInfo)) {
                try {
                    client.Connect();
                    MessageBox.Show("Connected to " + ipaddr_box.Text);
                }
                catch {
                    MessageBox.Show("Could not connect to host at this time. ");
                }

                client.Disconnect();
            }
        }

        private void Connect_button_Click(object sender, EventArgs e) {
            port = int.Parse(port_box.Text);

            // TODO catch port box not filled in error handling
            
            ConnectionInfo connectionInfo = new ConnectionInfo(ipaddr_box.Text, port, login_box.Text,
                    new PasswordAuthenticationMethod(login_box.Text, pass_box.Text)
                );

            using (var client = new SshClient(connectionInfo)) {

                

                try {
                    client.Connect();
                }
                catch {
                    MessageBox.Show("Unable to connect, please check your credentials");
                    Console.WriteLine("Failed to connect");
                }

                if (client.IsConnected) {
                    MainDisplay mdisp = new MainDisplay(client, ipaddr_box.Text, port);
                    //mdisp.Show();
                    Console.WriteLine("Opening new main display to, connected to : " + ipaddr_box.Text);
                    this.Close();
                }
            }


        }
    }
}
