using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
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
            Process.Start("CMD.exe","/c start www.google.com");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe","/c start www.facebook.com");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe","/c start www.drive.google.com");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", "/c start www.youtube.com");
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
    }
}
