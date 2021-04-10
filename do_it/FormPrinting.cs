using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;

namespace do_it
{
    public partial class FormPrinting : Form
    {
        ReportClass repport;
        public FormPrinting(ReportClass r)
        {
            InitializeComponent();
            repport =r ;
        }
        

        private void FormPrinting_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = repport;
        }
    }
}
