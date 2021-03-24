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
        public void remplirlist(string cs, SqlConnection cn, string req,DataGridView datagrid)
        {
                
                cn = new SqlConnection(cs);
                cn.Open();
                SqlCommand comd = new SqlCommand(req, cn);
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

    }
}
