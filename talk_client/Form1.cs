using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace talk_client
{

    public partial class Form1 : Form
    {

        //MySqlConnection connection = new MySqlConnection("Server=210.123.255.103,3306;Database=test_db;Uid=root;Pwd=1213;"); //db연결 설정
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=test_db;Uid=root;Pwd=1213;"); //db연결 설정




        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false; //사이즈 조절 설정 
        }

        private void login_buttn_Click(object sender, EventArgs e) 
        {
            login(); //로그인 메소드 불러오기
        }

        public void login()
        {

            //텍스트 박스에서 데이터 값들을 불러와서 변수에 저장 
            string ID = id.Text;
            string PW = pw.Text;

            string check = "select * from profile"; //db 쿼리문

            int num_check = 0; // if문 체크 

            connection.Open(); //db 연결 


            //db 연결후 reader 설정 
            MySqlCommand command = new MySqlCommand(check, connection); 
            MySqlDataReader reader = command.ExecuteReader();


            //db내 테이블에서 검색하는 반복문 
            while (reader.Read())
            {
                if (ID == reader["id"].ToString() && PW == reader["pw"].ToString()) //db에서 해당 id와 pw를 찾아서 비교 
                {
                    num_check += 1;  //비교해서 트루이면 1로 반환 
                }
            }
            connection.Close();

            if (num_check == 1) //체크 변수가 1이면 진실이기 때문에 실행 
            {
                this.Visible = false; //새로운 창을 띄우지만 이전 창은 닫게 하는 설정 
                main_talk main_Talk = new main_talk(); //새로운 창 생성 
                main_Talk.Show(); //새로운창 출력 
            }
            else //진실이 아니면 실행 
            {
                MessageBox.Show("아이디 혹은 비밀번호가 맞지 않습니다."); //해당 메시지 출력 
                num_check = 0; //체크 변수 다시 리셋 
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Visible = false; //새로운 창을 띄우지만 이전 창은 닫게 하는 설정
            register_form register_Form = new register_form(); //새로운 창 생성 
            register_Form.Show(); //새로운 창 출력 
        }
    }
}
