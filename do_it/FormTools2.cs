using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Tulpep.NotificationWindow;

namespace do_it
{
    public partial class FormTools2 : Form
    {
        ProcessStartInfo ps = new ProcessStartInfo();


        public FormTools2()
        {
            InitializeComponent();
            
        }

     

        private void FormTools2_Load(object sender, EventArgs e)
        {

        }

        private void btngmail_Click(object sender, EventArgs e)
        {
            Process.Start("www.gmail.com");
        }

        private void btngoogle_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com");
        }

        private void btnfacebook_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void btndrive_Click(object sender, EventArgs e)
        {
            Process.Start("www.drive.com");
        }

        private void btnytb_Click(object sender, EventArgs e)
        {
            Process.Start("www.youtube.com");
        }

        private void btnmap_Click(object sender, EventArgs e)
        {
            Process.Start("www.googlemap.com");
        }

        private void btntelegram_Click(object sender, EventArgs e)
        {
            ps.FileName=("cmd.exe");
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = @"start C:\Users\Reda\AppData\Roaming\Telegram Desktop.exe";
            Process.Start(ps);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnlinked_Click(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com");
        }

        private void btnteams_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
            lblstpwatch.Text = "00:00:00";
             min = 00;
             sec = 00;
             milisec = 00;
        }
        int min = 00;
        int sec = 00;
        int milisec = 00;
        private void Stopwatch_Tick(object sender, EventArgs e)
        {
          
            milisec++;
            if (milisec > 99)
            {
                milisec = 00;
                sec++;
            }
            if (sec > 59)
            {
                sec = 00;
                min++;
            }
            lblstpwatch.Text = min.ToString("00") + ":" + sec.ToString("00") + ":" + milisec.ToString("00");

        }
        string curenttime;
        string messagetime;
        private void timer1_Tick(object sender, EventArgs e)
        {
            curenttime = DateTime.Now.ToString("hh:mm:ss:tt");
            label1.Text = curenttime;
           // dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = "";
            messagetime = maskedTextBox1.Text+":"+comboBox1.Text;
          
           
            if (curenttime == messagetime)
            {
                timer2.Stop();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info_30px;
                popup.TitleText = "Reminder";
                popup.ContentText = textBox1.Text;
                popup.Popup();
                label2.Text = "";
            }
                }

      

      

        private void btnStrat_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label2.Text = "reminder set for " + messagetime;
        }

        private void btnstop2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            label2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
