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
    public partial class FormPublic : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        string req1 = "select t.ID_TASK,t.DESCRIPTION,u.FULL_NAME,c.CAT_NAME,t.STATUS,t.START_TIME,t.END_TIME from TASK t inner join users u on t.ID_USER=u.ID_USER inner join CATEGORIE c on c.ID_CATEGORIE_=t.ID_CATEGORIE_ where t.PUBLIC_TASK='1'";
        string req2 = "select n.ID_NOTE,n.TITLE_NOTE,n.TEXT_NOTE,u.FULL_NAME,n.DATE_NOTE,n.SKETCH_NOTE from NOTE n inner join users u on n.ID_USER=u.ID_USER where n.PUBLIC_NOTE='1'";
        string reqElm = "";
        string reqDate = "";
        string reqStatus = "";

        public FormPublic()
        {
            InitializeComponent();
        }
        //FormLoad_Public
        private void FormPublic_Load(object sender, EventArgs e)
        {
            remplirGrid("");
           
        }
        //DataGridView_Display
        public void remplirGrid(string reqString)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            DataTable dt = new DataTable();
            if (rdBtnTask.Checked == true)
            {
                bunifuLabel6.Text = "Creation date";
                bunifuLabel5.Text = "Description";
                cbStatus.Visible = true;
                groupBox3.Visible = true;
                bunifuLabel11.Visible = false;
                rbText.Visible = false;
                groupBox2.Size = new System.Drawing.Size(190, 95);
                cbDate.Location = new System.Drawing.Point(15, 120);
                bunifuLabel6.Location = new System.Drawing.Point(42, 122);
                datePicker.Location = new System.Drawing.Point(16, 151);
                rbText.Location = new System.Drawing.Point(10, 58);
                bunifuLabel11.Location = new System.Drawing.Point(41, 58);
                SqlCommand com = new SqlCommand(req1 + reqString, cn);
                SqlDataReader dr = com.ExecuteReader();
                SqlDataReader sqlDataReader = dr;
               // dt.Columns.Add("ID Task");
                dt.Columns.Add("Description");
                dt.Columns.Add("User");
                dt.Columns.Add("Categorie");
                dt.Columns.Add("Status");
                dt.Columns.Add("Start time");
                dt.Columns.Add("End time");
                while (sqlDataReader.Read())
                {
                    DataRow row = dt.NewRow();
                   // row["ID Task"] = sqlDataReader["ID_TASK"];
                    row["Description"] = sqlDataReader["DESCRIPTION"];
                    row["User"] = sqlDataReader["FULL_NAME"];
                    row["Categorie"] = sqlDataReader["CAT_NAME"];
                    row["Status"] = sqlDataReader["STATUS"];
                    row["Start time"] = sqlDataReader["START_TIME"];
                    row["End time"] = sqlDataReader["END_TIME"];
                    dt.Rows.Add(row);

                }
                sqlDataReader.Close();
            }
            else
            {
                bunifuLabel6.Text = "Last modified on";
                bunifuLabel5.Text = "Title";
                cbStatus.Visible = false;
                groupBox3.Visible = false;
                bunifuLabel11.Visible = true;
                rbText.Visible = true;
                groupBox2.Size = new System.Drawing.Size(190, 95 + 31);
                cbDate.Location = new System.Drawing.Point(15, 120 + 31);
                bunifuLabel6.Location = new System.Drawing.Point(42, 122 + 31);
                datePicker.Location = new System.Drawing.Point(16, 151 + 31);
                rbText.Location = new System.Drawing.Point(10, 58 + 31);
                bunifuLabel11.Location = new System.Drawing.Point(41, 58 + 31);
                //Grid_Display.Rows.Clear();
                //Grid_Display.Columns.Clear();
                SqlCommand com = new SqlCommand(req2 + reqString, cn);
                SqlDataReader dr = com.ExecuteReader();
                SqlDataReader sqlDataReader = dr;
                dt.Columns.Add("ID NOTE");
                dt.Columns.Add("Title");
                dt.Columns.Add("Note text");
                dt.Columns.Add("User");
                dt.Columns.Add("Last Modified on");
                dt.Columns.Add("Sketck file");
                while (sqlDataReader.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ID NOTE"] = sqlDataReader["ID_NOTE"];
                    row["Title"] = sqlDataReader["TITLE_NOTE"];
                    row["Note text"] = sqlDataReader["TEXT_NOTE"];
                    row["User"] = sqlDataReader["FULL_NAME"];
                    row["Last Modified on"] = sqlDataReader["DATE_NOTE"];
                    row["Sketck file"] = sqlDataReader["SKETCH_NOTE"];
                    dt.Rows.Add(row);
                }

                sqlDataReader.Close();
            }
            Grid_Display.DataSource = dt;
        }
        //CheckBox_Element
        private void cbElement_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cbElement.Checked == true)
            {
                groupBox2.Enabled = true;
                txtSearch.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                txtSearch.Enabled = false;
            }
        }
        //CheckBox_Date
        private void cbDate_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cbDate.Checked == true)
                datePicker.Enabled = true;
            else
            {
                datePicker.Enabled = false;
            }
        }
        //CheckBox_Status
        private void cbStatus_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cbStatus.Checked == true)
                groupBox3.Enabled = true;
            else
            {
                groupBox3.Enabled = false;
            }
        }
        //Button_Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbElement.Checked == true)
            {
                txtSearch.Enabled = true;
                if (rdBtnTask.Checked == true)
                {
                    if (rdBtnTitle.Checked == true)
                        reqElm = " and t.DESCRIPTION like'%" + txtSearch.Text + "%'";
                    else
                        reqElm = " and u.FULL_NAME like'%" + txtSearch.Text + "%'";
                }
                else
                {
                    if (rdBtnTitle.Checked == true)
                        reqElm = " and n.TITLE_NOTE like'%" + txtSearch.Text + "%'";
                    else if (rdBtnUser.Checked == true)
                        reqElm = " and u.FULL_NAME like'%" + txtSearch.Text + "%'";
                    else
                        reqElm = " and n.TEXT_NOTE like'%" + txtSearch.Text + "%'";
                }
            }
            else
                reqElm = "";

            if (cbDate.Checked == true)
            {
                if (rdBtnTask.Checked == true)
                    reqDate = " and datediff(dd,START_TIME,'" + datePicker.Value.ToString() + "')=0";
                else
                    reqDate = " and datediff(dd,DATE_NOTE,'" + datePicker.Value.ToString() + "')=0";
            }
            else
            {
                reqDate = "";
            }
            if (cbStatus.Checked == true)
            {
                if (rdBtnTask.Checked == true && rbDone.Checked == true)
                    reqStatus = " and t.STATUS='1'";
                else
                    reqStatus = " and t.STATUS='0'";
            }
            else
                reqStatus = "";

            remplirGrid(reqElm + reqDate + reqStatus);
        }
        //Button_ShowAll
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            remplirGrid("");
        }
    }
}
