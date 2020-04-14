using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class Sendmail
    {
        string title="test";
        string body;
        public string To { get; set; }
        public string From { get; set; }

        public Sendmail(string from,string to)
        {
            From = from;
            To = to;

        }
        

        public void send()
        {
            setbody();
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(From, "kontodoscam"),
                EnableSsl = true
            };
            try
            {
                client.Send(From, To,title,body);
                MessageBox.Show("wysłano mail");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
          


        }
        private void setbody()
        {           
            Txtfile txtfile1 = new Txtfile();
            txtfile1.getfile();
            body = txtfile1.line;
        }





    }
}

