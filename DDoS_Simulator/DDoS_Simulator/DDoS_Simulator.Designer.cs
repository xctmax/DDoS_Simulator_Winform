namespace DDoS_Simulator
{
    partial class DDoS_Simulator
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
            this.label_URL = new System.Windows.Forms.Label();
            this.label_Method = new System.Windows.Forms.Label();
            this.label_proxy = new System.Windows.Forms.Label();
            this.label_pathToListProxy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.radioButton_ccAttack = new System.Windows.Forms.RadioButton();
            this.radioButton_slow = new System.Windows.Forms.RadioButton();
            this.radioButton_POST = new System.Windows.Forms.RadioButton();
            this.radioButton_HEAD = new System.Windows.Forms.RadioButton();
            this.btn_downProxy = new System.Windows.Forms.Button();
            this.btn_openFileProxy = new System.Windows.Forms.Button();
            this.checkBox_downProxy = new System.Windows.Forms.CheckBox();
            this.checkBox_availableUseProxy = new System.Windows.Forms.CheckBox();
            this.btn_checkProxy = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_checkURL = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_Status = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.label_Ping = new System.Windows.Forms.Label();
            this.listBox_checkProxy = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(16, 73);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(106, 13);
            this.label_URL.TabIndex = 0;
            this.label_URL.Text = "Target Address/URL";
            // 
            // label_Method
            // 
            this.label_Method.AutoSize = true;
            this.label_Method.Location = new System.Drawing.Point(16, 108);
            this.label_Method.Name = "label_Method";
            this.label_Method.Size = new System.Drawing.Size(43, 13);
            this.label_Method.TabIndex = 1;
            this.label_Method.Text = "Method";
            // 
            // label_proxy
            // 
            this.label_proxy.AutoSize = true;
            this.label_proxy.Location = new System.Drawing.Point(16, 143);
            this.label_proxy.Name = "label_proxy";
            this.label_proxy.Size = new System.Drawing.Size(33, 13);
            this.label_proxy.TabIndex = 2;
            this.label_proxy.Text = "Proxy";
            // 
            // label_pathToListProxy
            // 
            this.label_pathToListProxy.AutoSize = true;
            this.label_pathToListProxy.Location = new System.Drawing.Point(16, 203);
            this.label_pathToListProxy.Name = "label_pathToListProxy";
            this.label_pathToListProxy.Size = new System.Drawing.Size(90, 13);
            this.label_pathToListProxy.TabIndex = 3;
            this.label_pathToListProxy.Text = "Path to proxy list: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "DDoS Attack Simulator";
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(134, 70);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(350, 20);
            this.txt_URL.TabIndex = 5;
            // 
            // radioButton_ccAttack
            // 
            this.radioButton_ccAttack.AutoSize = true;
            this.radioButton_ccAttack.Location = new System.Drawing.Point(134, 106);
            this.radioButton_ccAttack.Name = "radioButton_ccAttack";
            this.radioButton_ccAttack.Size = new System.Drawing.Size(73, 17);
            this.radioButton_ccAttack.TabIndex = 6;
            this.radioButton_ccAttack.TabStop = true;
            this.radioButton_ccAttack.Text = "CC Attack";
            this.radioButton_ccAttack.UseVisualStyleBackColor = true;
            // 
            // radioButton_slow
            // 
            this.radioButton_slow.AutoSize = true;
            this.radioButton_slow.Location = new System.Drawing.Point(244, 106);
            this.radioButton_slow.Name = "radioButton_slow";
            this.radioButton_slow.Size = new System.Drawing.Size(57, 17);
            this.radioButton_slow.TabIndex = 6;
            this.radioButton_slow.TabStop = true;
            this.radioButton_slow.Text = "SLOW";
            this.radioButton_slow.UseVisualStyleBackColor = true;
            // 
            // radioButton_POST
            // 
            this.radioButton_POST.AutoSize = true;
            this.radioButton_POST.Location = new System.Drawing.Point(338, 106);
            this.radioButton_POST.Name = "radioButton_POST";
            this.radioButton_POST.Size = new System.Drawing.Size(54, 17);
            this.radioButton_POST.TabIndex = 6;
            this.radioButton_POST.TabStop = true;
            this.radioButton_POST.Text = "POST";
            this.radioButton_POST.UseVisualStyleBackColor = true;
            // 
            // radioButton_HEAD
            // 
            this.radioButton_HEAD.AutoSize = true;
            this.radioButton_HEAD.Location = new System.Drawing.Point(429, 106);
            this.radioButton_HEAD.Name = "radioButton_HEAD";
            this.radioButton_HEAD.Size = new System.Drawing.Size(55, 17);
            this.radioButton_HEAD.TabIndex = 6;
            this.radioButton_HEAD.TabStop = true;
            this.radioButton_HEAD.Text = "HEAD";
            this.radioButton_HEAD.UseVisualStyleBackColor = true;
            // 
            // btn_downProxy
            // 
            this.btn_downProxy.Enabled = false;
            this.btn_downProxy.Location = new System.Drawing.Point(317, 138);
            this.btn_downProxy.Name = "btn_downProxy";
            this.btn_downProxy.Size = new System.Drawing.Size(167, 23);
            this.btn_downProxy.TabIndex = 8;
            this.btn_downProxy.Text = "Tải xuống";
            this.btn_downProxy.UseVisualStyleBackColor = true;
            this.btn_downProxy.Click += new System.EventHandler(this.btn_downProxy_Click);
            // 
            // btn_openFileProxy
            // 
            this.btn_openFileProxy.Enabled = false;
            this.btn_openFileProxy.Location = new System.Drawing.Point(317, 168);
            this.btn_openFileProxy.Name = "btn_openFileProxy";
            this.btn_openFileProxy.Size = new System.Drawing.Size(167, 23);
            this.btn_openFileProxy.TabIndex = 9;
            this.btn_openFileProxy.Text = "Mở tệp";
            this.btn_openFileProxy.UseVisualStyleBackColor = true;
            this.btn_openFileProxy.Click += new System.EventHandler(this.btn_openFileProxy_Click);
            // 
            // checkBox_downProxy
            // 
            this.checkBox_downProxy.AutoSize = true;
            this.checkBox_downProxy.Location = new System.Drawing.Point(134, 142);
            this.checkBox_downProxy.Name = "checkBox_downProxy";
            this.checkBox_downProxy.Size = new System.Drawing.Size(153, 17);
            this.checkBox_downProxy.TabIndex = 10;
            this.checkBox_downProxy.Text = "Tải xuống nguồn proxy mới";
            this.checkBox_downProxy.UseVisualStyleBackColor = true;
            this.checkBox_downProxy.CheckedChanged += new System.EventHandler(this.checkBox_downProxy_CheckedChanged);
            // 
            // checkBox_availableUseProxy
            // 
            this.checkBox_availableUseProxy.AutoSize = true;
            this.checkBox_availableUseProxy.Location = new System.Drawing.Point(134, 174);
            this.checkBox_availableUseProxy.Name = "checkBox_availableUseProxy";
            this.checkBox_availableUseProxy.Size = new System.Drawing.Size(148, 17);
            this.checkBox_availableUseProxy.TabIndex = 10;
            this.checkBox_availableUseProxy.Text = "Dùng nguồn proxy có sẵn";
            this.checkBox_availableUseProxy.UseVisualStyleBackColor = true;
            this.checkBox_availableUseProxy.CheckedChanged += new System.EventHandler(this.checkBox_availableUseProxy_CheckedChanged);
            // 
            // btn_checkProxy
            // 
            this.btn_checkProxy.Location = new System.Drawing.Point(19, 248);
            this.btn_checkProxy.Name = "btn_checkProxy";
            this.btn_checkProxy.Size = new System.Drawing.Size(120, 23);
            this.btn_checkProxy.TabIndex = 11;
            this.btn_checkProxy.Text = "Kiểm tra nguồn proxy";
            this.btn_checkProxy.UseVisualStyleBackColor = true;
            this.btn_checkProxy.Click += new System.EventHandler(this.btn_checkProxy_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Start.Location = new System.Drawing.Point(19, 296);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(103, 49);
            this.btn_Start.TabIndex = 12;
            this.btn_Start.Text = "STAR";
            this.btn_Start.UseVisualStyleBackColor = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(190, 248);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "RESET ALL";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(316, 248);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_checkURL
            // 
            this.btn_checkURL.Location = new System.Drawing.Point(497, 68);
            this.btn_checkURL.Name = "btn_checkURL";
            this.btn_checkURL.Size = new System.Drawing.Size(100, 23);
            this.btn_checkURL.TabIndex = 14;
            this.btn_checkURL.Text = "Checking URL";
            this.btn_checkURL.UseVisualStyleBackColor = true;
            this.btn_checkURL.Click += new System.EventHandler(this.btn_checkURL_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.listBox_checkProxy);
            this.panel1.Controls.Add(this.listBox_Status);
            this.panel1.Location = new System.Drawing.Point(144, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 221);
            this.panel1.TabIndex = 15;
            // 
            // listBox_Status
            // 
            this.listBox_Status.FormattingEnabled = true;
            this.listBox_Status.Location = new System.Drawing.Point(1, 32);
            this.listBox_Status.Name = "listBox_Status";
            this.listBox_Status.Size = new System.Drawing.Size(268, 186);
            this.listBox_Status.TabIndex = 0;
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
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Stop.Location = new System.Drawing.Point(19, 351);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(103, 49);
            this.btn_Stop.TabIndex = 12;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // label_Ping
            // 
            this.label_Ping.AutoSize = true;
            this.label_Ping.Location = new System.Drawing.Point(603, 73);
            this.label_Ping.Name = "label_Ping";
            this.label_Ping.Size = new System.Drawing.Size(34, 13);
            this.label_Ping.TabIndex = 16;
            this.label_Ping.Text = "Ping: ";
            // 
            // listBox_checkProxy
            // 
            this.listBox_checkProxy.FormattingEnabled = true;
            this.listBox_checkProxy.Location = new System.Drawing.Point(275, 34);
            this.listBox_checkProxy.Name = "listBox_checkProxy";
            this.listBox_checkProxy.Size = new System.Drawing.Size(275, 186);
            this.listBox_checkProxy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status check proxy";
            // 
            // DDoS_Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(708, 502);
            this.Controls.Add(this.label_Ping);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_checkURL);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_checkProxy);
            this.Controls.Add(this.checkBox_availableUseProxy);
            this.Controls.Add(this.checkBox_downProxy);
            this.Controls.Add(this.btn_openFileProxy);
            this.Controls.Add(this.btn_downProxy);
            this.Controls.Add(this.radioButton_HEAD);
            this.Controls.Add(this.radioButton_POST);
            this.Controls.Add(this.radioButton_slow);
            this.Controls.Add(this.radioButton_ccAttack);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_pathToListProxy);
            this.Controls.Add(this.label_proxy);
            this.Controls.Add(this.label_Method);
            this.Controls.Add(this.label_URL);
            this.Name = "DDoS_Simulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDoS_Simulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.Label label_Method;
        private System.Windows.Forms.Label label_proxy;
        private System.Windows.Forms.Label label_pathToListProxy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.RadioButton radioButton_ccAttack;
        private System.Windows.Forms.RadioButton radioButton_slow;
        private System.Windows.Forms.RadioButton radioButton_POST;
        private System.Windows.Forms.RadioButton radioButton_HEAD;
        private System.Windows.Forms.Button btn_downProxy;
        private System.Windows.Forms.Button btn_openFileProxy;
        private System.Windows.Forms.CheckBox checkBox_downProxy;
        private System.Windows.Forms.CheckBox checkBox_availableUseProxy;
        private System.Windows.Forms.Button btn_checkProxy;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_checkURL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label label_Ping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_checkProxy;
    }
}

