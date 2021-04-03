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
    public partial class FormNotes : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        //scketching 
        public int x = -1;
        public int y = -1;
        public bool moving = false;
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen p;
        public FormNotes()
        {
            InitializeComponent();
            g = DrawingPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Black);
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void FormNotes_Load(object sender, EventArgs e)
        {
            Pgnote.SetPage(note1);
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

             string req = "select TEXT_NOTE from NOTE where ID_USER = " + get_userID();
                    com = new SqlCommand(req, cn);
            //string req = "select TEXT_NOTE from NOTE where ID_USER = " + get_userID() + " AND TYPE_NOTE = '@Type'";
            //SqlCommand com = new SqlCommand(req, cn);
            comboxType.SelectedIndex = 0;
            //if (comboxType.SelectedItem.ToString() == "Text")
            //{
            //        com.Parameters.Add(new SqlParameter("@Type", "Text"));

            //}
            //else
            //{
            //    if (comboxType.SelectedItem.ToString() == "Sketch")
            //    {
            //        com.Parameters.Add(new SqlParameter("@Type", "Text"));
            //    }
            //    else
            //        req = "select TEXT_NOTE from NOTE where ID_USER = " + get_userID();
            //        com = new SqlCommand(req, cn);

            //}
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lstnotes.Items.Add("• " + dr[0]);

            }

        }
        //retrieve User ID
        public string get_userID()
        {
            string id = "";
            cn = new SqlConnection(cs);
            cn.Open();
            string r = "select ID_USER from users where FULL_NAME = '" + Program.activeUser + "'";
            com = new SqlCommand(r, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                id = dr[0].ToString();
            }
            cn.Close();
            cn = null;
            r = null;
            com = null;
            dr = null;
            return id;
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(p, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                DrawingPanel.Cursor = Cursors.Cross;
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;

        }
        private void Black_pen_Click(object sender, EventArgs e)
        {
            PictureBox Black_pen = (PictureBox)sender;
            p.Color = Black_pen.BackColor;
            DrawingPanel.Cursor = Cursors.Default;

        }

        private void Red_pen_Click(object sender, EventArgs e)
        {
            PictureBox Red_pen = (PictureBox)sender;
            p.Color = Red_pen.BackColor;
            DrawingPanel.Cursor = Cursors.Default;
        }

        private void Blue_pen_Click(object sender, EventArgs e)
        {
            PictureBox Blue_pen = (PictureBox)sender;
            p.Color = Blue_pen.BackColor;
            DrawingPanel.Cursor = Cursors.Default;
        }

        private void Grey_pen_Click(object sender, EventArgs e)
        {
            PictureBox Grey_pen = (PictureBox)sender;
            p.Color = Grey_pen.BackColor;
            DrawingPanel.Cursor = Cursors.Default;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
            //this.Rrefrech();
        }

        private void Erasser_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void comboxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
