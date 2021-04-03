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
    public partial class FormAdmin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SqlCommandBuilder combuilder;
        BindingSource bs = new BindingSource();
        public FormAdmin()
        {
            InitializeComponent();

        }  private void btnlogout_Click(object sender, EventArgs e)
        {
            FormLoginSignUp f = new FormLoginSignUp();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void activate(Boolean a)
        {
            grpdetails.Enabled = a;
            btncancel.Visible = a;
            btnvalidate.Visible = a;
            btnadd.Visible = !a;
            btnedite.Visible = !a;
            btnremove.Visible = !a;

        }

     

        private void btnedite_Click(object sender, EventArgs e)
        {
            activate(true);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string req = " select*from users";
            com = new SqlCommand(req, cn);

            combuilder = new SqlCommandBuilder(da);
            da = new SqlDataAdapter(com);
            da.Fill(ds, "users");
            bs.DataSource = ds;
            bs.DataMember = "users";
            usersListBox.DataSource = bs;
            usersListBox.DisplayMember = "full_name";
            usersListBox.ValueMember = "id_user";
            iD_USERTextBox.DataBindings.Add("text", bs, "id_user");
            fULL_NAMETextBox.DataBindings.Add("text", bs, "full_name");
            lOGINTextBox.DataBindings.Add("text", bs, "login");
            password_userTextBox.DataBindings.Add("text", bs, "password_user");
            combotype.DataBindings.Add("text", bs, "type_user");
            activate(false);
            

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            activate(true);
            bs.AddNew();
            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("delete this user ?", "info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bs.RemoveCurrent();
            
                activate(true);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            activate(false);
        }

        private void btnvalidate_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            da.Update(ds, "users");
            ds.Tables["users"].Clear();
            bs.MoveLast();
        }
    }
}
