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
using System.IO;
using System.Text.RegularExpressions;

namespace PeersAndRegistry {
    public partial class MainDisplay : Form {

        
        List<int> extList = new List<int>(); // list of extensions to check
        List<Label> upExtensions = new List<Label>(); // extensions that are up
        List<int> downExtensions = new List<int>(); // extensions that are down
        

        public MainDisplay(SshClient client, string ip, int port) {
            InitializeComponent();
            this.Text = ip;


            // check if client is connected
            if (client.IsConnected) {
                server_link_label.Text = ip;
            }
            else {
                server_link_label.Text = "Not connected, something went wrong.";
                this.Close();
                new GetCredentials();
            }

            // Get list of extensions to check updown
            extList = GetExtensions(client);

            // get a list of the extensions that are up (code in prog.cs)
            upExtensions = GetUpExtensions(client, extList, this, up_ext_panel);
            

            this.ShowDialog();
        }

        private void MainDisplay_Load(object sender, EventArgs e) {
            
        }

        private static List<int> GetExtensions(SshClient sshclient) {
            List<int> extList = new List<int>();

            using (var cmd1 = sshclient.CreateCommand("asterisk -rx 'database show' | grep cidnum")) {
                cmd1.Execute();
                string output = cmd1.Result.ToString();

                // read output from command line by line and regex the extensions from it
                using (StringReader reader = new StringReader(output)) {
                    Regex rx = new Regex(@"\d{3,6}");
                    string line;
                    while ((line = reader.ReadLine()) != null) {
                        Match match = rx.Match(line);
                        extList.Add(int.Parse(match.Value));
                    }
                }
            }

            Console.WriteLine("Got " + extList.Count + " extensions." );

            return extList;
        }

        private static List<Label> GetUpExtensions(SshClient sshclient, List<int> extList, Form frm, Panel up_ext_panel) {
            int startx = 0;
            int starty = 5;
            List<int> extUp = new List<int>();
            List<Label> upLabels = new List<Label>();
            Console.Write("Checking extensions");
            for (int i = 0; i < extList.Count; i++) {
                Console.Write(".");
                using (var cmd = sshclient.CreateCommand("asterisk -rx 'sip show peer " + extList[i] + "' | grep Status")) {
                    cmd.Execute();
                    string output = cmd.Result.ToString();
                    //Console.WriteLine(output);
                    if (output.Contains("OK")) { 

                        // Add to list of up extensions
                        extUp.Add(extList[i]);

                        // Draw the label
                        Label temp = new Label();
                        temp.Text = extList[i].ToString();
                        temp.ForeColor = System.Drawing.Color.Lime;
                        temp.Location = new Point(startx, starty);
                        starty += 25;
                        upLabels.Add(temp);

                        up_ext_panel.Controls.Add(temp);
                        
                    }
                }
            }
            return upLabels;
        }

        private static List<int> GetDownExtensions(SshClient sshclient, List<int> extList) {

            List<int> extDown = new List<int>();
            Console.Write("Checking extensions" +
                "");
            for (int i = 0; i < extList.Count; i++) {
                //Console.WriteLine("Checking >> " + extList[i]);
                Console.Write(".");
                using (var cmd = sshclient.CreateCommand("asterisk -rx 'sip show peer " + extList[i] + "' | grep Status")) {
                    cmd.Execute();
                    string output = cmd.Result.ToString();
                    if (output.Contains("UNKNOWN" )|| output.Contains("UNREACHABLE") || output.Contains("UNAVALIABLE")) {
                        extDown.Add(extList[i]);
                        //Console.WriteLine("Extension down");
                    }
                }
            }

            return extDown;
        }

        private static void DrawUpExtensions(List<int> extUp, int width, int height, Form frm) {
            // Could move this to GetUpExtensions(); for better readability / permormance.
            int startX = 0;
            int startY = 50;
            List<Label> up_ext_labels = new List<Label>();
            for (int i = 0; i < extUp.Count; i++) {
                // Draw label at next position
                Label temp = new Label();
                temp.Name = "ext" + i;
                temp.ForeColor = System.Drawing.Color.Lime;
                temp.Text = extUp[i].ToString();

                if (startX + 50 >= width) {
                    startY += 25;
                    startX = 50;
                }
                else {
                    startX += 50;
                }


                temp.Location = new Point(startX, startY);
                //temp.Show();
                
                up_ext_labels.Add(temp);
                frm.Controls.Add(up_ext_labels[i]);
                frm.Controls[i].Show();
                frm.Controls[i].BringToFront();
            }
        }

        private static void DrawDownExtensions(List<int> extDown, int width, int height, Form frm, int offset) {
            // Could move this to GetUpExtensions(); for better readability / permormance.
            int startX = 0;
            int startY = 0;
            List<Label> up_ext_labels = new List<Label>();
            for (int i = 0; i < extDown.Count; i++) {
                // Create new temp label
                Label temp = new Label();
                temp.Name = "ext" + i;
                temp.ForeColor = System.Drawing.Color.Red;
                temp.Text = extDown[i].ToString();
                // Draw at next position
                if (startX + 50 >= width) {
                    startY += 25;
                    startX = 50;
                }
                else {
                    startX += 50;
                }

                temp.Location = new Point(startX, startY);
                //temp.Show();

                up_ext_labels.Add(temp);
                frm.Controls.Add(up_ext_labels[i]);
                frm.Controls[i+offset].Show();
                frm.Controls[i+offset].BringToFront();
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e) {
           status_label.Text = "Clicked";
           // this.InitializeComponent();
        }

     
    }
}
