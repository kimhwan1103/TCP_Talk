namespace talk_client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.id_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.login_buttn = new System.Windows.Forms.Button();
            this.tset_text = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(52, 235);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(16, 12);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "ID";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(52, 268);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(23, 12);
            this.pw_label.TabIndex = 1;
            this.pw_label.Text = "PW";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(124, 232);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 21);
            this.id.TabIndex = 2;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(124, 259);
            this.pw.Name = "pw";
            this.pw.PasswordChar = '*';
            this.pw.Size = new System.Drawing.Size(100, 21);
            this.pw.TabIndex = 3;
            // 
            // login_buttn
            // 
            this.login_buttn.Location = new System.Drawing.Point(158, 347);
            this.login_buttn.Name = "login_buttn";
            this.login_buttn.Size = new System.Drawing.Size(75, 23);
            this.login_buttn.TabIndex = 4;
            this.login_buttn.Text = "로그인";
            this.login_buttn.UseVisualStyleBackColor = true;
            this.login_buttn.Click += new System.EventHandler(this.login_buttn_Click);
            // 
            // tset_text
            // 
            this.tset_text.AutoSize = true;
            this.tset_text.Font = new System.Drawing.Font("굴림", 30F);
            this.tset_text.Location = new System.Drawing.Point(117, 96);
            this.tset_text.Name = "tset_text";
            this.tset_text.Size = new System.Drawing.Size(57, 40);
            this.tset_text.TabIndex = 5;
            this.tset_text.Text = "톡";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(54, 347);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 6;
            this.register.Text = "회원가입";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.register);
            this.Controls.Add(this.tset_text);
            this.Controls.Add(this.login_buttn);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.id_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "talk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Button login_buttn;
        private System.Windows.Forms.Label tset_text;
        private System.Windows.Forms.Button register;
    }
}

