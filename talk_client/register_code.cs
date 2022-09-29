using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


/// <summary>
/// 이 클래스들은 register_form에서 사용하는 클래스입니다. 
/// </summary>


namespace talk_client
{


    class check_mode  //클래스 선언 
    {

        MySqlConnection connection = new MySqlConnection("Server=210.123.255.103:3306;Database=test_db;Uid=root;Pwd=1213;"); //db연결 설정

        //전역 변수들 설정 

        public string check_text; 

        public string text;

        private int total_check = 0, overlap_check = 0; //검증및 



        public int check() //체크 메소드 생성 
        {

            string check_text = this.check_text; //지역 변수를 전역 변수에 대입 

            connection.Open(); // db 연결 

            string check = string.Format("select {0},count(*) from profile group by {0}", check_text); //db 쿼리문 

            int num_check = 0; //1이면 오류 0이면 정상


            //db command 생성과 reader 생성 
            MySqlCommand command = new MySqlCommand(check, connection);
            MySqlDataReader reader = command.ExecuteReader();

            //db내에서 검색을 위한 while문 
            while (reader.Read())
            {
               if(text == reader[check_text].ToString())
                {
                    num_check += 1; 
                }
                else
                {
                    num_check += 0;
                }
            }

            connection.Close();


            if (num_check == 1)
            {
                MessageBox.Show("중복입니다. 다른것으로 입력해주세요.");
                overlap_check += 1;
                total_check = 0;
            }
            else
            {
                MessageBox.Show("사용이 가능합니다.");

                total_check += 1;
                overlap_check -= 1;
            }
            return total_check;
        }

        public int check_overlap()
        {
            return overlap_check;
        }

    }
        
}
