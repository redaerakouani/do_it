using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace do_it
{
    public partial class FormDocs : Form
    {
        private Boolean _isTask=false;
        public FormDocs()
        {
            InitializeComponent();
        }

        private void FormDocs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dO_ITDataSet.CATEGORIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cATEGORIETableAdapter.Fill(this.dO_ITDataSet.CATEGORIE);
            //// TODO: cette ligne de code charge les données dans la table 'dO_ITDataSet.TASK'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.tASKTableAdapter.Fill(this.dO_ITDataSet.TASK);
            //// TODO: cette ligne de code charge les données dans la table 'dO_ITDataSet.NOTE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.nOTETableAdapter.Fill(this.dO_ITDataSet.NOTE);

        }

        private void nOTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nOTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dO_ITDataSet);

        }

        private void btnshowAll_Click(object sender, EventArgs e)
        {
            _isTask = true;
            dataGridView1.DataSource = tASKBindingSource;
            this.tASKTableAdapter.FillBy(this.dO_ITDataSet.TASK, Program.get_userID());
            pnlOthersFilters.Visible = true;
        }

        private void btnallNotes_Click(object sender, EventArgs e)
        {
            _isTask = false;
            pnlOthersFilters.Visible = false;
            dataGridView1.DataSource = nOTEBindingSource;
            this.nOTETableAdapter.FillBy(this.dO_ITDataSet.NOTE, Program.get_userID());
        }

        private void cATEGORIEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool pub = false;
            bool status = false;
            if (SwitchPUB.Value.ToString() == "True")
                pub = true;
            if (SwitchSTATUS.Value.ToString() == "True")
                status = true;
            this.tASKTableAdapter.Fillfilter(dO_ITDataSet.TASK, pub, status, Program.get_userID(), int.Parse(cATEGORIEComboBox.SelectedValue.ToString()));
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            bool pub = false;
            bool status = false;
            if (SwitchPUB.Value.ToString() == "True")
                pub = true;
            if (SwitchSTATUS.Value.ToString() == "True")
                status = true;
            this.tASKTableAdapter.Fillfilter(dO_ITDataSet.TASK, pub, status, Program.get_userID(), int.Parse(cATEGORIEComboBox.SelectedValue.ToString()));
            this.nOTETableAdapter.FillBy1(dO_ITDataSet.NOTE, Program.get_userID(), pub);
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            FormPrinting f ;
            raport_task3 r = new raport_task3();
            report_note r2 = new report_note();
            //foreach(DataGridViewRow dgv in dataGridView1.Rows)
            //{
            //    r.SetParameterValue(0, dgv.Cells[5].Value);
            //    r.SetParameterValue(1, dgv.Cells[3].Value);
            //    r.SetParameterValue(2, dgv.Cells[4].Value);
            //    r.SetParameterValue(3, dgv.Cells[6].Value);
            //    r.SetParameterValue(4, dgv.Cells[7].Value);
            //}
            r.SetDataSource(dO_ITDataSet);

            r2.SetDataSource(dO_ITDataSet);

            if(_isTask)
            {
                f = new FormPrinting(r);
                

            }
            else
            {
                f = new FormPrinting(r2);
                
            }

                 

            f.ShowDialog();
        }
    }
}
