using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace do_it
{
    public partial class Formmail : Form
    {
        public Formmail()
        {
            InitializeComponent();
        }

        private void Formmail_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            txtmail.Text = txtmailpwd.Text = txtmessage.Text = txtname.Text = txtsubject.Text = txtTo.Text = "";
            txtmail.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = txtmail.Text,
                    Password = txtmailpwd.Text,

                }

            };
            MailAddress FormEmail = new MailAddress(txtmail.Text,"");
            MailAddress ToEmail = new MailAddress(txtTo.Text, txtname.Text);
            MailMessage message = new MailMessage()
            {
                From = FormEmail,
                Subject = txtsubject.Text,
                Body = txtmessage.Text,
            };
            message.To.Add(ToEmail);
            try
            {
                client.Send(message);
                MessageBox.Show("Sent Successfully", "Done", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong \n" + ex.Message, "error");
            }
        }
    }
}
