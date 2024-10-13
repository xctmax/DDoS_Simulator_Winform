namespace DDoS_Simulator
{
    partial class DNS_Amplification
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
            this.label_Ping = new System.Windows.Forms.Label();
            this.btn_checkURL = new System.Windows.Forms.Button();
            this.txt_dnsURL = new System.Windows.Forms.TextBox();
            this.label_URL = new System.Windows.Forms.Label();
            this.panel_dns = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_dnsStatus = new System.Windows.Forms.ListBox();
            this.btn_dnsStop = new System.Windows.Forms.Button();
            this.btn_dnsStart = new System.Windows.Forms.Button();
            this.btn_openListDNS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_pathToListDNS = new System.Windows.Forms.Label();
            this.panel_dns.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Ping
            // 
            this.label_Ping.AutoSize = true;
            this.label_Ping.Location = new System.Drawing.Point(609, 60);
            this.label_Ping.Name = "label_Ping";
            this.label_Ping.Size = new System.Drawing.Size(34, 13);
            this.label_Ping.TabIndex = 44;
            this.label_Ping.Text = "Ping: ";
            // 
            // btn_checkURL
            // 
            this.btn_checkURL.Location = new System.Drawing.Point(503, 55);
            this.btn_checkURL.Name = "btn_checkURL";
            this.btn_checkURL.Size = new System.Drawing.Size(100, 23);
            this.btn_checkURL.TabIndex = 43;
            this.btn_checkURL.Text = "Checking URL";
            this.btn_checkURL.UseVisualStyleBackColor = true;
            // 
            // txt_dnsURL
            // 
            this.txt_dnsURL.Location = new System.Drawing.Point(160, 57);
            this.txt_dnsURL.Name = "txt_dnsURL";
            this.txt_dnsURL.Size = new System.Drawing.Size(330, 20);
            this.txt_dnsURL.TabIndex = 42;
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(12, 60);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(106, 13);
            this.label_URL.TabIndex = 41;
            this.label_URL.Text = "Target Address/URL";
            // 
            // panel_dns
            // 
            this.panel_dns.Controls.Add(this.label6);
            this.panel_dns.Controls.Add(this.listBox_dnsStatus);
            this.panel_dns.Location = new System.Drawing.Point(127, 238);
            this.panel_dns.Name = "panel_dns";
            this.panel_dns.Size = new System.Drawing.Size(561, 221);
            this.panel_dns.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Status";
            // 
            // listBox_dnsStatus
            // 
            this.listBox_dnsStatus.FormattingEnabled = true;
            this.listBox_dnsStatus.Location = new System.Drawing.Point(1, 19);
            this.listBox_dnsStatus.Name = "listBox_dnsStatus";
            this.listBox_dnsStatus.Size = new System.Drawing.Size(557, 199);
            this.listBox_dnsStatus.TabIndex = 0;
            // 
            // btn_dnsStop
            // 
            this.btn_dnsStop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_dnsStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dnsStop.Location = new System.Drawing.Point(12, 293);
            this.btn_dnsStop.Name = "btn_dnsStop";
            this.btn_dnsStop.Size = new System.Drawing.Size(103, 49);
            this.btn_dnsStop.TabIndex = 46;
            this.btn_dnsStop.Text = "STOP";
            this.btn_dnsStop.UseVisualStyleBackColor = false;
            // 
            // btn_dnsStart
            // 
            this.btn_dnsStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dnsStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dnsStart.Location = new System.Drawing.Point(12, 238);
            this.btn_dnsStart.Name = "btn_dnsStart";
            this.btn_dnsStart.Size = new System.Drawing.Size(103, 49);
            this.btn_dnsStart.TabIndex = 45;
            this.btn_dnsStart.Text = "STAR";
            this.btn_dnsStart.UseVisualStyleBackColor = false;
            // 
            // btn_openListDNS
            // 
            this.btn_openListDNS.Location = new System.Drawing.Point(160, 93);
            this.btn_openListDNS.Name = "btn_openListDNS";
            this.btn_openListDNS.Size = new System.Drawing.Size(167, 23);
            this.btn_openListDNS.TabIndex = 48;
            this.btn_openListDNS.Text = "Mở tệp";
            this.btn_openListDNS.UseVisualStyleBackColor = true;
            this.btn_openListDNS.Click += new System.EventHandler(this.btn_openListDNS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mở danh sách máy chủ DNS.";
            // 
            // label_pathToListDNS
            // 
            this.label_pathToListDNS.AutoSize = true;
            this.label_pathToListDNS.Location = new System.Drawing.Point(12, 133);
            this.label_pathToListDNS.Name = "label_pathToListDNS";
            this.label_pathToListDNS.Size = new System.Drawing.Size(88, 13);
            this.label_pathToListDNS.TabIndex = 49;
            this.label_pathToListDNS.Text = "Path to DNS list: ";
            // 
            // DNS_Amplification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 463);
            this.Controls.Add(this.label_pathToListDNS);
            this.Controls.Add(this.btn_openListDNS);
            this.Controls.Add(this.panel_dns);
            this.Controls.Add(this.btn_dnsStop);
            this.Controls.Add(this.btn_dnsStart);
            this.Controls.Add(this.label_Ping);
            this.Controls.Add(this.btn_checkURL);
            this.Controls.Add(this.txt_dnsURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_URL);
            this.Name = "DNS_Amplification";
            this.Text = "DNS_Amplification";
            this.Load += new System.EventHandler(this.DNS_Amplification_Load);
            this.panel_dns.ResumeLayout(false);
            this.panel_dns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Ping;
        private System.Windows.Forms.Button btn_checkURL;
        private System.Windows.Forms.TextBox txt_dnsURL;
        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.Panel panel_dns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_dnsStatus;
        private System.Windows.Forms.Button btn_dnsStop;
        private System.Windows.Forms.Button btn_dnsStart;
        private System.Windows.Forms.Button btn_openListDNS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_pathToListDNS;
    }
}