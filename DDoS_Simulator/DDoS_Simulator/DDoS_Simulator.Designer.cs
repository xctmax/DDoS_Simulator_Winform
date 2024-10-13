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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_multi = new System.Windows.Forms.NumericUpDown();
            this.label_Multi = new System.Windows.Forms.Label();
            this.label_Ping = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_checkProxy = new System.Windows.Forms.ListBox();
            this.listBox_Status = new System.Windows.Forms.ListBox();
            this.btn_checkURL = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_checkProxy = new System.Windows.Forms.Button();
            this.checkBox_availableUseProxy = new System.Windows.Forms.CheckBox();
            this.checkBox_downProxy = new System.Windows.Forms.CheckBox();
            this.btn_openFileProxy = new System.Windows.Forms.Button();
            this.btn_downProxy = new System.Windows.Forms.Button();
            this.radioButton_HEAD = new System.Windows.Forms.RadioButton();
            this.radioButton_POST = new System.Windows.Forms.RadioButton();
            this.radioButton_slow = new System.Windows.Forms.RadioButton();
            this.radioButton_ccAttack = new System.Windows.Forms.RadioButton();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_pathToListProxy = new System.Windows.Forms.Label();
            this.label_proxy = new System.Windows.Forms.Label();
            this.label_Method = new System.Windows.Forms.Label();
            this.label_URL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_multi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_multi);
            this.panel1.Controls.Add(this.label_Multi);
            this.panel1.Controls.Add(this.label_Ping);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_checkURL);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_Stop);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.btn_checkProxy);
            this.panel1.Controls.Add(this.checkBox_availableUseProxy);
            this.panel1.Controls.Add(this.checkBox_downProxy);
            this.panel1.Controls.Add(this.btn_openFileProxy);
            this.panel1.Controls.Add(this.btn_downProxy);
            this.panel1.Controls.Add(this.radioButton_HEAD);
            this.panel1.Controls.Add(this.radioButton_POST);
            this.panel1.Controls.Add(this.radioButton_slow);
            this.panel1.Controls.Add(this.radioButton_ccAttack);
            this.panel1.Controls.Add(this.txt_URL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_pathToListProxy);
            this.panel1.Controls.Add(this.label_proxy);
            this.panel1.Controls.Add(this.label_Method);
            this.panel1.Controls.Add(this.label_URL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 502);
            this.panel1.TabIndex = 0;
            // 
            // txt_multi
            // 
            this.txt_multi.Location = new System.Drawing.Point(358, 193);
            this.txt_multi.Name = "txt_multi";
            this.txt_multi.Size = new System.Drawing.Size(120, 20);
            this.txt_multi.TabIndex = 42;
            // 
            // label_Multi
            // 
            this.label_Multi.AutoSize = true;
            this.label_Multi.Location = new System.Drawing.Point(308, 195);
            this.label_Multi.Name = "label_Multi";
            this.label_Multi.Size = new System.Drawing.Size(29, 13);
            this.label_Multi.TabIndex = 41;
            this.label_Multi.Text = "Multi";
            // 
            // label_Ping
            // 
            this.label_Ping.AutoSize = true;
            this.label_Ping.Location = new System.Drawing.Point(597, 65);
            this.label_Ping.Name = "label_Ping";
            this.label_Ping.Size = new System.Drawing.Size(34, 13);
            this.label_Ping.TabIndex = 40;
            this.label_Ping.Text = "Ping: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.listBox_checkProxy);
            this.panel2.Controls.Add(this.listBox_Status);
            this.panel2.Location = new System.Drawing.Point(138, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 221);
            this.panel2.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status check proxy/URL";
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
            // listBox_checkProxy
            // 
            this.listBox_checkProxy.FormattingEnabled = true;
            this.listBox_checkProxy.Location = new System.Drawing.Point(353, 21);
            this.listBox_checkProxy.Name = "listBox_checkProxy";
            this.listBox_checkProxy.Size = new System.Drawing.Size(205, 199);
            this.listBox_checkProxy.TabIndex = 0;
            // 
            // listBox_Status
            // 
            this.listBox_Status.FormattingEnabled = true;
            this.listBox_Status.Location = new System.Drawing.Point(1, 19);
            this.listBox_Status.Name = "listBox_Status";
            this.listBox_Status.Size = new System.Drawing.Size(348, 199);
            this.listBox_Status.TabIndex = 0;
            // 
            // btn_checkURL
            // 
            this.btn_checkURL.Location = new System.Drawing.Point(491, 60);
            this.btn_checkURL.Name = "btn_checkURL";
            this.btn_checkURL.Size = new System.Drawing.Size(100, 23);
            this.btn_checkURL.TabIndex = 38;
            this.btn_checkURL.Text = "Checking URL";
            this.btn_checkURL.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(310, 240);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(184, 240);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 36;
            this.btn_reset.Text = "RESET ALL";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Stop.Location = new System.Drawing.Point(13, 343);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(103, 49);
            this.btn_Stop.TabIndex = 35;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Start.Location = new System.Drawing.Point(13, 288);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(103, 49);
            this.btn_Start.TabIndex = 34;
            this.btn_Start.Text = "STAR";
            this.btn_Start.UseVisualStyleBackColor = false;
            // 
            // btn_checkProxy
            // 
            this.btn_checkProxy.Location = new System.Drawing.Point(13, 240);
            this.btn_checkProxy.Name = "btn_checkProxy";
            this.btn_checkProxy.Size = new System.Drawing.Size(120, 23);
            this.btn_checkProxy.TabIndex = 33;
            this.btn_checkProxy.Text = "Kiểm tra nguồn proxy";
            this.btn_checkProxy.UseVisualStyleBackColor = true;
            // 
            // checkBox_availableUseProxy
            // 
            this.checkBox_availableUseProxy.AutoSize = true;
            this.checkBox_availableUseProxy.Location = new System.Drawing.Point(128, 166);
            this.checkBox_availableUseProxy.Name = "checkBox_availableUseProxy";
            this.checkBox_availableUseProxy.Size = new System.Drawing.Size(148, 17);
            this.checkBox_availableUseProxy.TabIndex = 32;
            this.checkBox_availableUseProxy.Text = "Dùng nguồn proxy có sẵn";
            this.checkBox_availableUseProxy.UseVisualStyleBackColor = true;
            // 
            // checkBox_downProxy
            // 
            this.checkBox_downProxy.AutoSize = true;
            this.checkBox_downProxy.Location = new System.Drawing.Point(128, 134);
            this.checkBox_downProxy.Name = "checkBox_downProxy";
            this.checkBox_downProxy.Size = new System.Drawing.Size(153, 17);
            this.checkBox_downProxy.TabIndex = 31;
            this.checkBox_downProxy.Text = "Tải xuống nguồn proxy mới";
            this.checkBox_downProxy.UseVisualStyleBackColor = true;
            // 
            // btn_openFileProxy
            // 
            this.btn_openFileProxy.Enabled = false;
            this.btn_openFileProxy.Location = new System.Drawing.Point(311, 160);
            this.btn_openFileProxy.Name = "btn_openFileProxy";
            this.btn_openFileProxy.Size = new System.Drawing.Size(167, 23);
            this.btn_openFileProxy.TabIndex = 30;
            this.btn_openFileProxy.Text = "Mở tệp";
            this.btn_openFileProxy.UseVisualStyleBackColor = true;
            // 
            // btn_downProxy
            // 
            this.btn_downProxy.Enabled = false;
            this.btn_downProxy.Location = new System.Drawing.Point(311, 130);
            this.btn_downProxy.Name = "btn_downProxy";
            this.btn_downProxy.Size = new System.Drawing.Size(167, 23);
            this.btn_downProxy.TabIndex = 29;
            this.btn_downProxy.Text = "Tải xuống";
            this.btn_downProxy.UseVisualStyleBackColor = true;
            // 
            // radioButton_HEAD
            // 
            this.radioButton_HEAD.AutoSize = true;
            this.radioButton_HEAD.Location = new System.Drawing.Point(423, 98);
            this.radioButton_HEAD.Name = "radioButton_HEAD";
            this.radioButton_HEAD.Size = new System.Drawing.Size(55, 17);
            this.radioButton_HEAD.TabIndex = 28;
            this.radioButton_HEAD.TabStop = true;
            this.radioButton_HEAD.Text = "HEAD";
            this.radioButton_HEAD.UseVisualStyleBackColor = true;
            // 
            // radioButton_POST
            // 
            this.radioButton_POST.AutoSize = true;
            this.radioButton_POST.Location = new System.Drawing.Point(332, 98);
            this.radioButton_POST.Name = "radioButton_POST";
            this.radioButton_POST.Size = new System.Drawing.Size(54, 17);
            this.radioButton_POST.TabIndex = 27;
            this.radioButton_POST.TabStop = true;
            this.radioButton_POST.Text = "POST";
            this.radioButton_POST.UseVisualStyleBackColor = true;
            // 
            // radioButton_slow
            // 
            this.radioButton_slow.AutoSize = true;
            this.radioButton_slow.Location = new System.Drawing.Point(238, 98);
            this.radioButton_slow.Name = "radioButton_slow";
            this.radioButton_slow.Size = new System.Drawing.Size(57, 17);
            this.radioButton_slow.TabIndex = 26;
            this.radioButton_slow.TabStop = true;
            this.radioButton_slow.Text = "SLOW";
            this.radioButton_slow.UseVisualStyleBackColor = true;
            // 
            // radioButton_ccAttack
            // 
            this.radioButton_ccAttack.AutoSize = true;
            this.radioButton_ccAttack.Location = new System.Drawing.Point(128, 98);
            this.radioButton_ccAttack.Name = "radioButton_ccAttack";
            this.radioButton_ccAttack.Size = new System.Drawing.Size(73, 17);
            this.radioButton_ccAttack.TabIndex = 25;
            this.radioButton_ccAttack.TabStop = true;
            this.radioButton_ccAttack.Text = "CC Attack";
            this.radioButton_ccAttack.UseVisualStyleBackColor = true;
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(128, 62);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(350, 20);
            this.txt_URL.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "DDoS Attack Simulator";
            // 
            // label_pathToListProxy
            // 
            this.label_pathToListProxy.AutoSize = true;
            this.label_pathToListProxy.Location = new System.Drawing.Point(10, 195);
            this.label_pathToListProxy.Name = "label_pathToListProxy";
            this.label_pathToListProxy.Size = new System.Drawing.Size(90, 13);
            this.label_pathToListProxy.TabIndex = 22;
            this.label_pathToListProxy.Text = "Path to proxy list: ";
            // 
            // label_proxy
            // 
            this.label_proxy.AutoSize = true;
            this.label_proxy.Location = new System.Drawing.Point(10, 135);
            this.label_proxy.Name = "label_proxy";
            this.label_proxy.Size = new System.Drawing.Size(33, 13);
            this.label_proxy.TabIndex = 21;
            this.label_proxy.Text = "Proxy";
            // 
            // label_Method
            // 
            this.label_Method.AutoSize = true;
            this.label_Method.Location = new System.Drawing.Point(10, 100);
            this.label_Method.Name = "label_Method";
            this.label_Method.Size = new System.Drawing.Size(43, 13);
            this.label_Method.TabIndex = 20;
            this.label_Method.Text = "Method";
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(10, 65);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(106, 13);
            this.label_URL.TabIndex = 19;
            this.label_URL.Text = "Target Address/URL";
            // 
            // DDoS_Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(708, 502);
            this.Controls.Add(this.panel1);
            this.Name = "DDoS_Simulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDoS_Simulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_multi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txt_multi;
        private System.Windows.Forms.Label label_Multi;
        private System.Windows.Forms.Label label_Ping;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_checkProxy;
        private System.Windows.Forms.ListBox listBox_Status;
        private System.Windows.Forms.Button btn_checkURL;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_checkProxy;
        private System.Windows.Forms.CheckBox checkBox_availableUseProxy;
        private System.Windows.Forms.CheckBox checkBox_downProxy;
        private System.Windows.Forms.Button btn_openFileProxy;
        private System.Windows.Forms.Button btn_downProxy;
        private System.Windows.Forms.RadioButton radioButton_HEAD;
        private System.Windows.Forms.RadioButton radioButton_POST;
        private System.Windows.Forms.RadioButton radioButton_slow;
        private System.Windows.Forms.RadioButton radioButton_ccAttack;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_pathToListProxy;
        private System.Windows.Forms.Label label_proxy;
        private System.Windows.Forms.Label label_Method;
        private System.Windows.Forms.Label label_URL;
    }
}

