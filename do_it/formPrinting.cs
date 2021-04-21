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
        ReportClass report;
        public FormPrinting()
        {

            InitializeComponent();
        }
        public FormPrinting(ReportClass r)
        {

            InitializeComponent();
            report = r;
        }

        private void FormPrinting_Load(object sender, EventArgs e)
        {
            report.SetParameterValue("sketch", Application.StartupPath+"\\");
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
            

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
