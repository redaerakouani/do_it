﻿using System;
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
        public FormPublic()
        {
            InitializeComponent();
        }

        private void FormPublic_Load(object sender, EventArgs e)
        {
            

            remplirGrid();
          
        }
        public void remplirGrid()
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string req1 = "select t.ID_TASK,t.DESCRIPTION,u.FULL_NAME,c.CAT_NAME,t.STATUS,t.START_TIME,t.END_TIME from TASK t inner join users u on t.ID_USER=u.ID_USER inner join CATEGORIE c on c.ID_CATEGORIE_=t.ID_CATEGORIE_ where t.PUBLIC_TASK='1'";
            string req2 = "select n.ID_NOTE,n.TITLE_NOTE,n.TEXT_NOTE,u.FULL_NAME,n.DATE_NOTE,n.SKETCH_NOTE from NOTE n inner join users u on n.ID_USER=u.ID_USER n.PUBLIC_NOTE='1'";
            DataTable dataTable = new DataTable();
            if (rdBtnTask.Checked == true)
            {
                //Grid_Display.Rows.Clear();
                //Grid_Display.Columns.Clear();

                SqlCommand com = new SqlCommand(req1, cn);
                SqlDataReader dr = com.ExecuteReader();
                SqlDataReader sqlDataReader = dr;
                dataTable.Columns.Add("ID Task");
                dataTable.Columns.Add("Description");
                dataTable.Columns.Add("User");
                dataTable.Columns.Add("Categorie");
                dataTable.Columns.Add("Status");
                dataTable.Columns.Add("Start time");
                dataTable.Columns.Add("End time");
                while (sqlDataReader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["ID Task"] = sqlDataReader["ID_TASK"];
                    row["Description"] = sqlDataReader["DESCRIPTION"];
                    row["User"] = sqlDataReader["FULL_NAME"];
                    row["Categorie"] = sqlDataReader["CAT_NAME"];
                    row["Status"] = sqlDataReader["STATUS"];
                    row["Start time"] = sqlDataReader["START_TIME"];
                    row["End time"] = sqlDataReader["END_TIME"];
                    dataTable.Rows.Add(row);
                }
                sqlDataReader.Close();
            }
            else
            {
                //Grid_Display.Rows.Clear();
                //Grid_Display.Columns.Clear();
                SqlCommand com = new SqlCommand(req2, cn);
                SqlDataReader dr = com.ExecuteReader();
                SqlDataReader sqlDataReader = dr;
                dataTable.Columns.Add("ID NOTE");
                dataTable.Columns.Add("Title");
                dataTable.Columns.Add("Note text");
                dataTable.Columns.Add("User");
                dataTable.Columns.Add("Last Modified on");
                dataTable.Columns.Add("Sketck file");
                while (sqlDataReader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["ID NOTE"] = sqlDataReader["ID_NOTE"];
                    row["Title"] = sqlDataReader["TITLE_NOTE"];
                    row["Note text"] = sqlDataReader["TEXT_NOTE"];
                    row["User"] = sqlDataReader["FULL_NAME"];
                    row["Last Modified on"] = sqlDataReader["DATE_NOTE"];
                    row["Sketck file"] = sqlDataReader["SKETCH_NOTE"];
                    dataTable.Rows.Add(row);
                }
                sqlDataReader.Close();
            }
            Grid_Display.DataSource = dataTable;
        }

        private void rdBtn_Click(object sender, EventArgs e)
        {
            remplirGrid();
        }
    }
}
