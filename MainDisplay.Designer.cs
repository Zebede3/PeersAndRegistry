namespace PeersAndRegistry {
    partial class MainDisplay {
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
            this.server_link_label = new System.Windows.Forms.LinkLabel();
            this.up_ext_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_label = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server_link_label
            // 
            this.server_link_label.AutoSize = true;
            this.server_link_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.server_link_label.Location = new System.Drawing.Point(13, 13);
            this.server_link_label.Name = "server_link_label";
            this.server_link_label.Size = new System.Drawing.Size(0, 13);
            this.server_link_label.TabIndex = 0;
            // 
            // up_ext_panel
            // 
            this.up_ext_panel.AutoScroll = true;
            this.up_ext_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.up_ext_panel.Location = new System.Drawing.Point(12, 29);
            this.up_ext_panel.Name = "up_ext_panel";
            this.up_ext_panel.Size = new System.Drawing.Size(94, 397);
            this.up_ext_panel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(141, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 397);
            this.panel1.TabIndex = 3;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(688, 396);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(61, 13);
            this.status_label.TabIndex = 4;
            this.status_label.Text = "Not clicked";
            // 
            // refresh_btn
            // 
            this.refresh_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.refresh_btn.Location = new System.Drawing.Point(538, 380);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(144, 44);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.up_ext_panel);
            this.Controls.Add(this.server_link_label);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "MainDisplay";
            this.Text = "The VoIP Centre";
            this.Load += new System.EventHandler(this.MainDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel server_link_label;
        private System.Windows.Forms.Panel up_ext_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button refresh_btn;
    }
}