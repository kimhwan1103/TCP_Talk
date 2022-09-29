using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace talk_client
{

    
    public partial class register_form : Form
    {

        //MySqlConnection connection = new MySqlConnection("Server=localhost;Database=test_db;Uid=root;Pwd=1213;"); //db연결 설정
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=test_db;Uid=root;Pwd=1213;"); //db연결 설정

        int total_check = 0;
        int check_num = 0;
   

        public register_form()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void go_login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO profile(email, id, pw) VALUES('" + email.Text + "','" + id.Text + "','" + pw.Text + "')";

            connection.Open();

            if (email.Text == "" && id.Text == "" && pw.Text == "")
            {
                MessageBox.Show("이메일 혹은 아이디에 문자를 넣어주세요, 혹은 비밀번호를 넣어주세요");    
            }
            else
            {
                if (total_check == 2)
                {

                    if (check_num == 1 || check_num == 2)
                    {

                        MessageBox.Show("id 혹은 email를 확인해주세요");
                        check_num = 0;
                    }
                    else
                    {
                        if (pw.Text == pw_check.Text)
                        {
                            MySqlCommand command = new MySqlCommand(insertQuery, connection);

                            try
                            {
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("정상적으로 회원가입이 되었습니다.");
                                    this.Visible = false;
                                    Form1 Form1 = new Form1();
                                    Form1.Show();
                                }
                                else
                                {
                                    MessageBox.Show("오류 관리자한테 문의하세요");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 동일하지 않습니다. 비밀번호를 다시 입력해주세요.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("검증을 다 마치시오");
                    total_check = 0;
                }
            }

            connection.Close();
        }
           

        private void email_check_Click(object sender, EventArgs e)
        {

            check_mode email_check = new check_mode
            {
                text = email.Text,

                check_text = "email"
            };

            total_check += email_check.check();

            check_num += email_check.check_overlap();
                        

        }

        private void id_check_Click(object sender, EventArgs e)
        {

            check_mode id_check = new check_mode
            {
                text = id.Text,

                check_text = "id"
            };

            total_check += id_check.check();

            check_num += id_check.check_overlap();

        }
    }
}