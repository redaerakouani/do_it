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
    public partial class formTask : Form
    {
        public formTask()
        {
            InitializeComponent();
        }

        private void cATEGORIEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATEGORIEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dO_ITDataSet);

        }

        private void formTask_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dO_ITDataSet.TASK'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tASKTableAdapter.Fill(this.dO_ITDataSet.TASK);
            // TODO: cette ligne de code charge les données dans la table 'dO_ITDataSet.CATEGORIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cATEGORIETableAdapter.Fill(this.dO_ITDataSet.CATEGORIE);

        }
    }
}
