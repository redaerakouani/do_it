using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace do_it
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
          
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

       

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();



        }

        private void btnminize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            FormLoginSignUp f = new FormLoginSignUp();
            f.Show();
            this.Hide();
        }
        private void formtask(object panelT)
        {
            if (this.panelForms.Controls.Count > 0)
                this.panelForms.Controls.RemoveAt(0);
            Form f = panelT as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(f);
            this.panelForms.Tag = f;
            f.Show();
        }

        

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void btnmenu_Click(object sender, EventArgs e)
        {
        }

        private void btnemail_Click(object sender, EventArgs e)
        {
            formtask(new Formmail());
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
           // panelForms.Controls.RemoveAt(0);
            
        }

        private void btntask_Click(object sender, EventArgs e)
        {
            formtask(new formTask());
        }

        private void btntools_Click(object sender, EventArgs e)
        {
            formtask(new FormTools2());
        }

        private void btndocs_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

            if (bunifuGradientPanel1.Width == 60)
            {
                bunifuGradientPanel1.Width = 180;
                btntask.Text = "Task";
                btnpublic.Text = "Public";
                btnnote.Text = "Note";
                btnemail.Text = "Email";
                btnlogout.Text = "Log out";
                btnhome.Text = "Home";
                btntools.Text = "tools";
                btndocs.Text = "Docs";
                panelForms.Width = 647;
                Size = new Size(847, 551);
      
                


            }
            else
            {
                bunifuGradientPanel1.Width = 60;
                btntask.Text = "";
                btnpublic.Text = "";
                btnnote.Text = "";
                btnemail.Text = "";
                btnlogout.Text = "";
                btnhome.Text = "";
                btntools.Text = "";
                btndocs.Text = "";
                Size = new Size(687, 551);
               
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            formtask(new FormClients());
        }
    }
}
