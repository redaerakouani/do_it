﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace do_it
{
    public partial class FormMenu : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public object Applicatication { get; private set; }

        public FormMenu()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panelForms.Visible = false;
            panelHome.Visible = true;
            timer1.Start();
            //btnhome_Click(sender, e);


            //Home load
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string req1 = "select FULL_NAME from users where ID_USER = " + get_userID();
            string req2 = "select DESCRIPTION from TASK where ID_USER = " + get_userID() + " AND STATUS = '0' AND datediff(dd,START_TIME,getdate())=0";
            SqlCommand com = new SqlCommand(req1, cn);

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr[0].ToString();
            }
            dr.Close();
            com = new SqlCommand(req2, cn);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                listBoxTodayTasks.Items.Add("• " + dr[0]);

            }
            if (listBoxTodayTasks.Items.Count == 0)
            {
                panelTasks.Hide();
                panelNoTasks.Show();
            }
            else
            {
                panelTasks.Show();
                panelNoTasks.Hide();
            }
            if (DateTime.Now.Hour > 4 && DateTime.Now.Hour < 12)
                lblGreeting.Text = "Good morning,";
            else if (DateTime.Now.Hour < 18)
                lblGreeting.Text = "Good afternoon,";
            else
                lblGreeting.Text = "Good evening,";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // label1.Text = DateTime.Now.ToLongTimeString();
            //label2.Text = DateTime.Now.ToLongDateString();
        }
        //Escape_Button
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimize_Button
        private void btnminize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Button_LoginSignup
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            FormLoginSignUp f = new FormLoginSignUp();
            this.Hide();
            f.ShowDialog();
            this.Close();
            
        }
        //Form_Task
        public void formtask(object panelT)
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
        ///-------------------------------------------///
        //Buttons_click_event
        //Email_Button
        private void btnemail_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            panelHome.Visible = false;
            //panelForms.Visible = true;
           //lbel1.Visible = false;
            formtask(new Formmail());
        }
        //Home_Button
        private void btnhome_Click(object sender, EventArgs e)
        {
            panelForms.Visible = false;
            panelHome.Visible = true;
            //panelForms.Controls.RemoveAt(0);
            //panelForms.Visible = false;
            //label1.Visible = true;
            //panelForms.Visible = true;
            //panelForms.Visible = false;
            //label1.Visible = false;
            //formtask(new FormHome());
            // this.FormMenu_Load(sender, e);   
        }
      //Task_Button
      public void btntask_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            panelHome.Visible = false;
            //panelForms.Visible = true;
            //label1.Visible = false;
            formtask(new formTask());

        }
        //Tools_Botton
        private void btntools_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            panelHome.Visible = false;
            //panelForms.Visible = true;
            //label1.Visible = false;
            formtask(new FormTools2());
        }
        //Docs_Button
        private void btndocs_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            panelHome.Visible = false;
            //panelForms.Visible = true;
            //label1.Visible = false;
            formtask(new FormDocs());
        }
        //btn Show MainPanel
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
                panelHome.Width = 647;
                Size = new Size(847, 542);
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
                Size = new Size(734, 542);

            }
        }
        //Admin_Load_Page_Button
        private void btnClients_Click(object sender, EventArgs e)
        {
            formtask(new FormClients());
        }
        //Public_Button
        private void btnpublic_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            panelHome.Visible = false;
            formtask(new FormPublic());
            //panelForms.Visible = true;
            //label1.Visible = false;
        }
        //Go_To_Task_Button
        private void btnGoTasks_Click(object sender, EventArgs e)
        {
            btntask.PerformClick();
        }
        //Notes_Button
        private void btnnote_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            panelHome.Visible = false;
            formtask(new FormNotes());
        }
        ///-------------------------------------------///
        //Get_ID_Method
        public string get_userID()
        {
            string id = "";
            cn = new SqlConnection(cs);
            cn.Open();
            string r = "select ID_USER from users where FULL_NAME = '" + Program.activeUser + "'";
            com = new SqlCommand(r, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                id = dr[0].ToString();
            }


            cn.Close();
            cn = null;
            r = null;
            com = null;
            dr = null;
            return id;

        }
        ///-------------------------------------------///
        //Button_add_New_Note_From_Home
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string req = "insert into note (ID_USER,TEXT_NOTE,DATE_NOTE,PUBLIC_NOTE,TITLE_NOTE) values (@iduser,@desc,@date,@public,@title)";
            SqlCommand com = new SqlCommand(req, cn);
            com.Parameters.Add(new SqlParameter("@iduser", Convert.ToInt32(get_userID())));
            com.Parameters.Add(new SqlParameter("@desc", txtBoxNote.Text));
            com.Parameters.Add(new SqlParameter("@title", "[" + DateTime.Now.ToString("MM/dd/yyyy HH:mm") + "] " + lblName.Text + "''s " + (lblGreeting.Text.Split(' ', ','))[1] + " note"));
            com.Parameters.Add(new SqlParameter("@date", DateTime.Now));
            com.Parameters.Add(new SqlParameter("@public", chkBoxPulicNote.Checked));

            com.ExecuteNonQuery();
            txtBoxNote.Text = "";

            cn.Close();
            cn = null;
            com = null;
        }

        

        ///-------------------------------------------///

        //private void panelForms_ControlRemoved(object sender, ControlEventArgs e)
        //{
        //    if (panelForms.Controls.Count == 0) {
        //        btntask.PerformClick();
        //    }

        //    //else {Program.goToTask = false;}

        //}
    }
}
