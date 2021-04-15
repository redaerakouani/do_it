using System;
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
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);            bunifuFormDock1.SubscribeControlToDragEvents(panelForms);
            bunifuFormDock1.SubscribeControlToDragEvents(panelHome);



        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panelForms.Visible = false;
            panelHome.Visible = true;
            timer1.Start();
            


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
            {
                lblGreeting.Text = "Good morning,";
                pictureBox1.Image = do_it.Properties.Resources.icons8_sunrise_127px;
            }
            else if (DateTime.Now.Hour < 18)
            {
                lblGreeting.Text = "Good afternoon,";
                pictureBox1.Image = do_it.Properties.Resources.icons8_sun_127px;
            }
            else
            {
                lblGreeting.Text = "Good evening,";
                pictureBox1.Image = do_it.Properties.Resources.icons8_night_127px;
            }
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
            try
            {
                panelForms.Visible = true;
                panelHome.Visible = false;
                formtask(new Formmail());
            }
            catch { }
            
        }
        //Home_Button
        private void btnhome_Click(object sender, EventArgs e)
        {
            listBoxTodayTasks.Items.Clear();
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            panelForms.Visible = false;
            panelHome.Visible = true;

            string req2 = "select DESCRIPTION from TASK where ID_USER = " + get_userID() + " AND STATUS = '0' AND datediff(dd,START_TIME,getdate())=0";
            com = new SqlCommand(req2, cn);
            SqlDataReader dr = com.ExecuteReader();
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
             
        }
      //Task_Button
      public void btntask_Click(object sender, EventArgs e)
        {
            try
            {
                panelForms.Visible = true;
                panelHome.Visible = false;
                formtask(new formTask());

            }
            catch { }
            

        }
        //Tools_Botton
        private void btntools_Click(object sender, EventArgs e)
        {
            try
            {
                panelForms.Visible = true;
                panelHome.Visible = false;
              formtask(new FormTools2());
            }
            catch { }
            
        }
        //Docs_Button
        private void btndocs_Click(object sender, EventArgs e)
        {
            try
            {
                panelForms.Visible = true;
                panelHome.Visible = false;
               formtask(new FormDocs());
            }
            catch { }
                
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
            try
            {
                formtask(new FormClients());
            }
            catch { }
            
        }
        //Public_Button
        private void btnpublic_Click(object sender, EventArgs e)
        {
            try
            {
                panelForms.Visible = true;
                panelHome.Visible = false;
                formtask(new FormPublic());
            }
            catch { }
            
        }
        //Go_To_Task_Button
        private void btnGoTasks_Click(object sender, EventArgs e)
        {
            btntask.PerformClick();
        }
        //Notes_Button
        private void btnnote_Click(object sender, EventArgs e)
        {
            try
            {
                panelForms.Visible = true;
                panelHome.Visible = false;
                formtask(new FormNotes());
            }
            catch { }
            
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
            try {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string req = "insert into note (ID_USER,TEXT_NOTE,DATE_NOTE,PUBLIC_NOTE,TITLE_NOTE) values (@iduser,@desc,@date,@public,@title)";
                SqlCommand com = new SqlCommand(req, cn);
                com.Parameters.Add(new SqlParameter("@iduser", Convert.ToInt32(get_userID())));
                com.Parameters.Add(new SqlParameter("@desc", txtBoxNote.Text));
                com.Parameters.Add(new SqlParameter("@title", "[" + DateTime.Now.ToString("MM/dd/yyyy HH:mm") + "] " + lblName.Text + " " + (lblGreeting.Text.Split(' ', ','))[1] + " note"));
                com.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                com.Parameters.Add(new SqlParameter("@public", chkBoxPulicNote.Checked));

                com.ExecuteNonQuery();
                txtBoxNote.Text = "";

                cn.Close();
                cn = null;
                com = null;
            }
            catch { }
            
        }
    }
}
