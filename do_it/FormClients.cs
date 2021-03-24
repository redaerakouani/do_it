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
    public partial class FormClients : Form
    {
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
            usersBindingSource.RemoveCurrent();
            tableAdapterManager.UpdateAll(dO_ITDataSet);
            activate(true);
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
