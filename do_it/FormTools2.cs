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
            Process.Start("CMD.exe", "/c start www.gmail.com");
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
   }
}
