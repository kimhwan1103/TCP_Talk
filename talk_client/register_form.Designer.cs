namespace talk_client
{
    partial class register_form
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
            this.email = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.pw_check = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email_check = new System.Windows.Forms.Button();
            this.id_check = new System.Windows.Forms.Button();
            this.go_login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("굴림", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text.Location = new System.Drawing.Point(97, 34);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(106, 23);
            this.text.TabIndex = 0;
            this.text.Text = "회원가입";
            this.text.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(122, 168);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 21);
            this.email.TabIndex = 1;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(122, 217);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 21);
            this.id.TabIndex = 2;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(122, 261);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(100, 21);
            this.pw.TabIndex = 3;
            // 
            // pw_check
            // 
            this.pw_check.Location = new System.Drawing.Point(122, 308);
            this.pw_check.Name = "pw_check";
            this.pw_check.Size = new System.Drawing.Size(100, 21);
            this.pw_check.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(36, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "이메일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(36, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(36, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(14, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "비밀번호 확인";
            // 
            // email_check
            // 
            this.email_check.Location = new System.Drawing.Point(228, 168);
            this.email_check.Name = "email_check";
            this.email_check.Size = new System.Drawing.Size(47, 23);
            this.email_check.TabIndex = 9;
            this.email_check.Text = "검증";
            this.email_check.UseVisualStyleBackColor = true;
            this.email_check.Click += new System.EventHandler(this.email_check_Click);
            // 
            // id_check
            // 
            this.id_check.Location = new System.Drawing.Point(228, 217);
            this.id_check.Name = "id_check";
            this.id_check.Size = new System.Drawing.Size(47, 23);
            this.id_check.TabIndex = 10;
            this.id_check.Text = "검증";
            this.id_check.UseVisualStyleBackColor = true;
            this.id_check.Click += new System.EventHandler(this.id_check_Click);
            // 
            // go_login
            // 
            this.go_login.Location = new System.Drawing.Point(91, 415);
            this.go_login.Name = "go_login";
            this.go_login.Size = new System.Drawing.Size(121, 23);
            this.go_login.TabIndex = 11;
            this.go_login.Text = "로그인 화면으로";
            this.go_login.UseVisualStyleBackColor = true;
            this.go_login.Click += new System.EventHandler(this.go_login_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(91, 371);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(121, 23);
            this.register.TabIndex = 12;
            this.register.Text = "회원가입";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.register);
            this.Controls.Add(this.go_login);
            this.Controls.Add(this.id_check);
            this.Controls.Add(this.email_check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pw_check);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.id);
            this.Controls.Add(this.email);
            this.Controls.Add(this.text);
            this.Name = "register_form";
            this.Text = "register_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.TextBox pw_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button email_check;
        private System.Windows.Forms.Button id_check;
        private System.Windows.Forms.Button go_login;
        private System.Windows.Forms.Button register;
    }
}