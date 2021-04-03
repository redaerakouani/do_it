using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace do_it
{
    public partial class FormHome : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string req1 = "select FULL_NAME from users where ID_USER = "+get_userID();
            string req2 = "select DESCRIPTION from TASK where ID_USER = "+ get_userID()+" AND STATUS = '0'";
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
                listBoxTodayTasks.Items.Add("• "+dr[0]);

            }
            if(listBoxTodayTasks.Items.Count==0)
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
            else if(DateTime.Now.Hour < 18)
                lblGreeting.Text = "Good afternoon,";
            else
                lblGreeting.Text = "Good evening,";

            
        }
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
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string req = "insert into note (ID_USER,TEXT_NOTE,DATE_NOTE,PUBLIC_NOTE,TITLE_NOTE) values (@iduser,@desc,@date,@public,@title)";
            SqlCommand com = new SqlCommand(req,cn);
            com.Parameters.Add(new SqlParameter("@iduser", Convert.ToInt32(get_userID())));
            com.Parameters.Add(new SqlParameter("@desc", txtBoxNote.Text));
            com.Parameters.Add(new SqlParameter("@title", "["+DateTime.Now.ToString("MM/dd/yyyy HH:mm") +"] "+lblName.Text+"'s "+(lblGreeting.Text.Split(' ',','))[1]+" note"));
            com.Parameters.Add(new SqlParameter("@date", DateTime.Now));
            com.Parameters.Add(new SqlParameter("@public", chkBoxPulicNote.Checked));

            com.ExecuteNonQuery();
            txtBoxNote.Text = "";

            cn.Close();
            cn = null;
            com = null;
        }

        private void btnGoTasks_Click(object sender, EventArgs e)
        {
            
        }
    }
}
