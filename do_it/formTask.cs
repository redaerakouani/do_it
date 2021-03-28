using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace do_it
{
    public partial class formTask : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand comd = new SqlCommand();


        public void remplirlist(string cs, SqlConnection cn, string req, DataGridView datagrid)
        {

            cn = new SqlConnection(cs);
            cn.Open();
            comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                datagrid.Rows.Add(dr[0]);

            }
            cs = null;
            cn.Close();
            cn = null;
            req = null;
            comd = null;
            dr = null;

        }
        public void checkboxvalue(string cs, SqlConnection cn, string req,Bunifu.UI.WinForms.BunifuCheckBox checkbox)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
               
                if (dr[0].ToString()=="True") checkbox.Checked=true;
                else
                    checkbox.Checked = false;


            }
                cs = null;
                cn.Close();
                cn = null;
                req = null;
                comd = null;
                dr = null;

        }
        public void remplircombo(string cs, SqlConnection cn, string req, ComboBox combbx)
        {

            cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                combbx.Items.Add(dr[0]);

            }
            cs = null;
            cn.Close();
            cn = null;
            req = null;
            comd = null;
            dr = null;

        }
        public formTask()
        {
            InitializeComponent();
        }

        private void formTask_Load(object sender, EventArgs e)
        {
            
            string req2 = "select CAT_NAME from CATEGORIE";
            remplircombo(cs, cn, req2, combbx_cat);
            string req = "select DESCRIPTION from TASK t inner join users u on t.ID_USER = u.ID_USER  where u.FULL_NAME = '" + Program.activeUser + "'; ";
            remplirlist(cs, cn, req,DataGridtasks);



            
           
           

        }

        private void combbx_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridtasks.Rows.Clear();

            string req = "select DESCRIPTION from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_=c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and c.CAT_NAME= '" + combbx_cat.GetItemText( combbx_cat.SelectedItem) + "' ";
            remplirlist(cs, cn, req, DataGridtasks);
        }

        private void DataGridtasks_SelectionChanged(object sender, EventArgs e)
        {
            string req = "select STATUS from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_ = c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and t.DESCRIPTION = '"+DataGridtasks.CurrentCell.Value.ToString()+"'";
            checkboxvalue(cs, cn, req, bunifuCheckBox1);

        }

        private void bunifuCheckBox1_Click(object sender, EventArgs e)
        {
            
            string req1 = "update task set [STATUS] =1 where ID_USER in (select ID_USER from users where FULL_NAME=  '" + Program.activeUser + "')  and DESCRIPTION = '" + DataGridtasks.CurrentCell.Value.ToString() + "'";
            string req2 = "update task set [STATUS] =0 where ID_USER in (select ID_USER from users where FULL_NAME=  '" + Program.activeUser + "')  and DESCRIPTION = '" + DataGridtasks.CurrentCell.Value.ToString() + "'";

            cn = new SqlConnection(cs);
            cn.Open();
            if (bunifuCheckBox1.Checked) comd = new SqlCommand(req1, cn);

            else comd = new SqlCommand(req2, cn);
            comd.ExecuteNonQuery();

        }
    }
}
