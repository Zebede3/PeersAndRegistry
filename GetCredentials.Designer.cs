namespace PeersAndRegistry {
    partial class GetCredentials {
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
            this.ipaddr_box = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.test_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.port_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipaddr_box
            // 
            this.ipaddr_box.Location = new System.Drawing.Point(12, 25);
            this.ipaddr_box.Name = "ipaddr_box";
            this.ipaddr_box.Size = new System.Drawing.Size(124, 20);
            this.ipaddr_box.TabIndex = 0;
            this.ipaddr_box.Text = "thevoipcentrepbx.co.uk";
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(12, 77);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(124, 20);
            this.login_box.TabIndex = 2;
            this.login_box.Text = "root";
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(12, 103);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(124, 20);
            this.pass_box.TabIndex = 3;
            this.pass_box.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // test_button
            // 
            this.test_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.test_button.Location = new System.Drawing.Point(145, 129);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(55, 23);
            this.test_button.TabIndex = 4;
            this.test_button.Text = "Test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.Test_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.connect_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connect_button.Location = new System.Drawing.Point(12, 129);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(124, 23);
            this.connect_button.TabIndex = 5;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = false;
            this.connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // port_box
            // 
            this.port_box.Location = new System.Drawing.Point(12, 51);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(124, 20);
            this.port_box.TabIndex = 1;
            this.port_box.Text = "9522";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "SSH Connection";
            // 
            // GetCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(225, 169);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.port_box);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.ipaddr_box);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "GetCredentials";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipaddr_box;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
