namespace talk_client
{
    partial class main_talk
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
            this.text = new System.Windows.Forms.Label();
            this.server_ip = new System.Windows.Forms.TextBox();
            this.server_port = new System.Windows.Forms.TextBox();
            this.cn_server = new System.Windows.Forms.Button();
            this.server_log = new System.Windows.Forms.TextBox();
            this.input_msg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.server_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(116, 37);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(59, 12);
            this.text.TabIndex = 0;
            this.text.Text = "접속/오픈";
            // 
            // server_ip
            // 
            this.server_ip.Location = new System.Drawing.Point(21, 73);
            this.server_ip.Name = "server_ip";
            this.server_ip.Size = new System.Drawing.Size(154, 21);
            this.server_ip.TabIndex = 5;
            // 
            // server_port
            // 
            this.server_port.Location = new System.Drawing.Point(195, 73);
            this.server_port.Name = "server_port";
            this.server_port.Size = new System.Drawing.Size(76, 21);
            this.server_port.TabIndex = 3;
            // 
            // cn_server
            // 
            this.cn_server.Location = new System.Drawing.Point(51, 100);
            this.cn_server.Name = "cn_server";
            this.cn_server.Size = new System.Drawing.Size(75, 23);
            this.cn_server.TabIndex = 4;
            this.cn_server.Text = "서버 연결";
            this.cn_server.UseVisualStyleBackColor = true;
            this.cn_server.Click += new System.EventHandler(this.cn_server_Click);
            // 
            // server_log
            // 
            this.server_log.Location = new System.Drawing.Point(21, 129);
            this.server_log.Multiline = true;
            this.server_log.Name = "server_log";
            this.server_log.ReadOnly = true;
            this.server_log.Size = new System.Drawing.Size(250, 275);
            this.server_log.TabIndex = 6;
            // 
            // input_msg
            // 
            this.input_msg.Location = new System.Drawing.Point(21, 417);
            this.input_msg.Name = "input_msg";
            this.input_msg.Size = new System.Drawing.Size(177, 21);
            this.input_msg.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "전송";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // server_open
            // 
            this.server_open.Location = new System.Drawing.Point(167, 100);
            this.server_open.Name = "server_open";
            this.server_open.Size = new System.Drawing.Size(75, 23);
            this.server_open.TabIndex = 9;
            this.server_open.Text = "서버 열기";
            this.server_open.UseVisualStyleBackColor = true;
            this.server_open.Click += new System.EventHandler(this.server_open_Click);
            // 
            // main_talk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.server_open);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_msg);
            this.Controls.Add(this.server_log);
            this.Controls.Add(this.cn_server);
            this.Controls.Add(this.server_port);
            this.Controls.Add(this.server_ip);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main_talk";
            this.Text = "main_talk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox server_ip;
        private System.Windows.Forms.TextBox server_port;
        private System.Windows.Forms.Button cn_server;
        private System.Windows.Forms.TextBox server_log;
        private System.Windows.Forms.TextBox input_msg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button server_open;
    }
}