using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace talk_client
{
    class Server 
    {
        public string ip, port;

        public void main()
        {
            
            main_talk.list_text += new up_ip_port(get_ip_prot);            
            
        }

      
        public void msg()
        {
            MessageBox.Show($"{ip}");
            MessageBox.Show($"{port}");
        }
      
        public void get_ip_prot(string item1, string item2)
        {
            this.ip = item1;
            this.port = item2;
        }
        

    }

}
