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
  
    public partial class FormLoginSignUp : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        public FormLoginSignUp()
            
        {
        
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
        }

      
        //switch sign up//sign in
    

      

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            if (txtfullname.Text == "" || txtEmail.Text == "")
            {
              lblerrorsignup.Text=  "please fill mandatory fields";
            }else if (txtconfirmpwd.Text != Txtpwdsignup.Text)
                 {
                lblerrorsignup.Text = "passsowrd do not match";
            }
            else
            {
             SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand com = new SqlCommand("UserAdd", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@fullname", txtfullname.Text.Trim());
            com.Parameters.AddWithValue("@login", txtEmail.Text.Trim());
            com.Parameters.AddWithValue("@password_user", Txtpwdsignup.Text.Trim());
            com.ExecuteNonQuery();
            lblerrorsignup.Text="Successfull";
                lblerrorsignup.ForeColor = Color.DarkGreen;
            clear();
            }
           
        }
        private void clear()
        {
           lblerror.Text= txtEmail.Text = txtfullname.Text = Txtpwdsignup.Text =txtconfirmpwd.Text= "";

        }

    

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
             
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string req = "select * from users where LOGIN like  @login or Full_name like @login and password_user like @paswd  ";
            SqlCommand com2 = new SqlCommand(req, cn);
            com2.Parameters.Add(new SqlParameter("@login", txtmail.Text));

            com2.Parameters.Add(new SqlParameter( "@paswd", txtpwd.Text));
            SqlDataReader dr;
            dr = com2.ExecuteReader();
            if (dr.Read())
            {
                if (dr["TYPE_USER"].ToString().Equals("Admin")) 
                {
                    FormAdmin f = new FormAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                   
                }
                else 
                {
                    Program.activeUser = com2.Parameters["@login"].Value.ToString();
                    FormMenu f = new FormMenu();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                    
                }
            }
                else if (txtmail.Text == "" || txtpwd.Text == "")
                {
                    lblerror.Text = "please fill mandatory fields";
                }
                else
                {
                    lblerror.Text = "wrong password or email";
                }   
            }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtpwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) btnLogin.PerformClick();
        }

        private void FormLoginSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            loginSignupPage.SetPage(tabPage1);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            loginSignupPage.SetPage(tabPage2);
        }
       
    }

      
    

      
    
}
