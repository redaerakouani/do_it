using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace do_it
{
    public partial class LoadingForm : Form
    {
        int valuep = 0;
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valuep += 1;
            bunifuCircleProgressbar1.Value = valuep;
            if (bunifuCircleProgressbar1.Value == 100)
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                this.Hide();
                FormLoginSignUp f = new FormLoginSignUp();
                f.ShowDialog();
            }
        }

       
    }
}
