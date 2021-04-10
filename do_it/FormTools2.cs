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
        public FormTools2()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Process.Start("www.gmail.com");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start(" www.facebook.com");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start(" www.drive.google.com");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Process.Start(" www.youtube.com");
        }
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
           // Process.Start("");
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            //Process.Start("");
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }

        private void bunifuImageButton5_Click_1(object sender, EventArgs e)
        {
            //Process.Start("Zoom.exe");
        }

        private void btnmap_Click(object sender, EventArgs e)
        {
            //Process.Start("www..com");
        }

        private void FormTools2_Load(object sender, EventArgs e)
        {

        }
        int min = 00;
        int sec = 00;
        int milisec = 00;


        private void StopWatch_Tick(object sender, EventArgs e)
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

        private void btnstop_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
            lblstpwatch.Text = "00:00:00";
            min = 00;
            sec = 00;
            milisec = 00;
        }

        private void btnstrat_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
        }
        string curenttime;
        string messagetime;

        private void timer2_Tick(object sender, EventArgs e)
        {
            curenttime = DateTime.Now.ToString("hh:mm:ss:tt");
            label5.Text = curenttime;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            messagetime = txtH.Text + ":" + txtmin.Text + ":" + txtss.Text + ":" + comboBox1.Text;



            if (curenttime == messagetime)
            {
                timer2.Stop();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info_30px;
                popup.TitleText = "Reminder";
                popup.ContentText = textBox1.Text;
                popup.Popup();
                curenttime = null;

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label2.Text = "reminder set for " + messagetime;
        }

        private void btnnstop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            label2.Text = "";
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

