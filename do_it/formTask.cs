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
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;

namespace do_it
{
    public partial class formTask : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand comd = new SqlCommand();




        public string get_userID()
        {
            string id="";
            cn = new SqlConnection(cs);
            cn.Open();
            string r = "select ID_USER from users where FULL_NAME = '" + Program.activeUser + "'";
            comd = new SqlCommand(r, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                id=dr[0].ToString();
            }
            
            
            cn.Close();
            cn = null;
            r = null;
            comd = null;
            dr = null;
            return id;
        }
        public string get_categID()
        {
            string id = "";
            cn = new SqlConnection(cs);
            cn.Open();
            string r= "select ID_CATEGORIE_ from CATEGORIE where CAT_NAME='" + combbx_cat.GetItemText(combbx_cat.SelectedItem) + "'";
            comd = new SqlCommand(r, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                id = dr[0].ToString();
            }

          
            cn.Close();
            cn = null;
            r = null;
            comd = null;
            dr = null;
            return id;
        }
        public void datepicker_value(string cs, SqlConnection cn, string req, BunifuDatepicker datepiker)
        {

            cn = new SqlConnection(cs);
            cn.Open();
            comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                datepiker.Value =Convert.ToDateTime( dr[0].ToString());

            }
           
            cn.Close();
            cn = null;
            req = null;
            comd = null;
            dr = null;

        }

        public void remplirlist(string cs, SqlConnection cn, string req, DataGridView datagrid)
        {
            datagrid.Rows.Clear();

            cn = new SqlConnection(cs);
            cn.Open();
            comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                datagrid.Rows.Add(dr[0]);

            }
            
            cn.Close();
            cn = null;
            req = null;
            comd = null;
            dr = null;

        }
        public void checkboxvalue(string cs, SqlConnection cn, string req,BunifuCheckBox checkbox)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
               
                if (dr[0].ToString()=="True")
                    checkbox.Checked=true;
                else
                    checkbox.Checked = false;
            }
                
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
            combbx_cat.SelectedIndex=0; 
        }

        private void combbx_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

            string req = "select DESCRIPTION from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_=c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and c.CAT_NAME= '" + combbx_cat.GetItemText( combbx_cat.SelectedItem) + "' ";
            remplirlist(cs, cn, req, DataGridtasks);
            string req1 = "select STATUS from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_ = c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and t.DESCRIPTION = '" + DataGridtasks.CurrentCell.Value.ToString() + "'";
            checkboxvalue(cs, cn, req1, bunifuCheckBox1);
            string req2 = "select public_task from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_ = c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and t.DESCRIPTION = '" + DataGridtasks.CurrentCell.Value.ToString() + "'";
            checkboxvalue(cs, cn, req, bunifuCheckBox4);
        }

        private void DataGridtasks_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string req = "select STATUS from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_ = c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and t.DESCRIPTION = '"+DataGridtasks.CurrentCell.Value.ToString()+"'";
                checkboxvalue(cs, cn, req, bunifuCheckBox1);
                string req2 = "select public_task from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_ = c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and t.DESCRIPTION = '" + DataGridtasks.CurrentCell.Value.ToString() + "'";
                checkboxvalue(cs, cn, req, bunifuCheckBox4);
                string req3 = "select START_TIME from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_=c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and t.DESCRIPTION= '" + DataGridtasks.CurrentCell.Value.ToString() + "'";
                datepicker_value(cs,cn,req3,bunifuDatepicker1);
                string req4 = "select END_TIME from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_=c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and t.DESCRIPTION= '" + DataGridtasks.CurrentCell.Value.ToString() + "'";
                datepicker_value(cs, cn, req4, bunifuDatepicker2);
            }
            catch {}
            
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

        private void bunifuCheckBox4_Click(object sender, EventArgs e)
        {
            string req1 = "update task set [public_task] =1 where ID_USER in (select ID_USER from users where FULL_NAME=  '" + Program.activeUser + "')  and DESCRIPTION = '" + DataGridtasks.CurrentCell.Value.ToString() + "'";
            string req2 = "update task set [public_task] =0 where ID_USER in (select ID_USER from users where FULL_NAME=  '" + Program.activeUser + "')  and DESCRIPTION = '" + DataGridtasks.CurrentCell.Value.ToString() + "'";

            cn = new SqlConnection(cs);
            cn.Open();
            if (bunifuCheckBox4.Checked) comd = new SqlCommand(req1, cn);

            else comd = new SqlCommand(req2, cn);
            comd.ExecuteNonQuery();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txt_new_tsk.Text == "") MessageBox.Show("add task first...!");
            else
                if(combbx_cat.SelectedIndex==-1) MessageBox.Show("chose a categorie...!");
            else
            {
                string req = "insert into TASK (DESCRIPTION,STATUS,PUBLIC_TASK,START_TIME,END_TIME,ID_USER,ID_CATEGORIE_) values ('" + txt_new_tsk.Text + "',0,0,'" + bunifuDatepicker1.Value.ToString() + "','" + bunifuDatepicker2.Value.ToString() + "','" + get_userID() + "','" + get_categID() + "')";
                cn = new SqlConnection(cs);
                cn.Open();
                comd = new SqlCommand(req, cn);
                comd.ExecuteNonQuery();
                //recharge list data 
                string req2 = "select DESCRIPTION from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_=c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and c.CAT_NAME= '" + combbx_cat.GetItemText(combbx_cat.SelectedItem) + "' ";
                remplirlist(cs, cn, req2, DataGridtasks);
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string req = "delete from TASK where ID_USER in (select ID_USER from users where FULL_NAME = '" + Program.activeUser + "') and DESCRIPTION = '" + DataGridtasks.CurrentCell.Value.ToString() + "'";
            cn = new SqlConnection(cs);
            cn.Open();

            comd = new SqlCommand(req, cn);
            comd.ExecuteNonQuery();



            string req2 = "select DESCRIPTION from TASK t inner join users u on t.ID_USER = u.ID_USER  inner join CATEGORIE c on t.ID_CATEGORIE_=c.ID_CATEGORIE_  where u.FULL_NAME = '" + Program.activeUser + "' and c.CAT_NAME= '" + combbx_cat.GetItemText(combbx_cat.SelectedItem) + "' ";
            remplirlist(cs, cn, req2, DataGridtasks);


        }

    }
}
