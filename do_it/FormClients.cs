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
    public partial class FormClients : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;

        public FormClients()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dO_ITDataSet);

        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dO_ITDataSet.users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.usersTableAdapter.Fill(this.dO_ITDataSet.users);
            activate(false);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FormLoginSignUp f = new FormLoginSignUp();
            f.Show();
            this.Hide();
        }
        private void activate(Boolean a)
        {
            grpdetails.Enabled = a;
            password_userTextBox.Enabled = false;
            btncancel.Visible = a;
            btnvalidate.Visible = a;
            btnadd.Visible = !a;
            btnedite.Visible = !a;
            btnremove.Visible = !a;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
            tableAdapterManager.UpdateAll(dO_ITDataSet);
      //      fULL_NAMETextBox.Focus();
            activate(true);
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            activate(true);
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Are you sure you want to delete this user ??", "Delete..!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string req = "delete from users where ID_USER = " + iD_USERTextBox.Text;
                SqlCommand com = new SqlCommand(req, cn);

                com.ExecuteNonQuery();
                usersListBox.Refresh();
                this.usersTableAdapter.Fill(this.dO_ITDataSet.users);

            }
            

          
        }

        private void btnvalidate_Click(object sender, EventArgs e)
        {
            usersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dO_ITDataSet);
            activate(false);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            usersBindingSource.CancelEdit();
            activate(false);
        }
    }
}
