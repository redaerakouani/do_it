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
        //Note
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
       
        private void FormNotes_Load(object sender, EventArgs e)
        {
            Pgnote.SetPage(note1);
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string req1 = "select TITLE_NOTE from NOTE where ID_USER = '" + get_userID()+"'";
            SqlCommand com1 = new SqlCommand(req1, cn);
            SqlDataReader dr = com1.ExecuteReader();
            while (dr.Read())
            {
                lstnotes.Items.Add(dr[0]);

            }

        }

        //Delete_Note_Button
        private void deleteNote_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete this note ", "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string req = "delete from NOTE where TITLE_NOTE ='" + lstnotes.SelectedItem.ToString() + "' and ID_USER = '" + get_userID() + "'";
                cn = new SqlConnection(cs);
                cn.Open();
                com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                remplirlist();
                com = null;
                cn.Close();
            }
        }
        //Methode_RemplireList
        public void remplirlist()
        {

            lstnotes.Items.Clear();
            string req = "select TITLE_NOTE from NOTE where ID_USER = " + get_userID();
            cn = new SqlConnection(cs);
            cn.Open();
            com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lstnotes.Items.Add(dr[0]);

            }
        }

        //Button_Add_newNote
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pgnote.SetPage(note2);
            cbAdd.Checked = true;
        }
        //Button_Back_To_DisplayNotesPage
        private void btn_back_Click(object sender, EventArgs e)
        {
            Pgnote.SetPage(note1);
        }
        //Button_Go_To_Sketching
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Pgnote.SetPage(sketch);

        }
        //Modify_Note_Selected
        private void Btn_modifie_note_Click(object sender, EventArgs e)
        {
            Pgnote.SetPage(note2);
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string req = "select TITLE_NOTE ,TEXT_NOTE,PUBLIC_NOTE,DATE_NOTE from note where TITLE_NOTE = '" + lstnotes.SelectedItem.ToString() + "'";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                TitleNote.Text = dr[0].ToString();
                NoteText.Text = dr[1].ToString();
                chkBoxPulicNote.Checked = Convert.ToBoolean(dr[2].ToString());

            }
            cbAdd.Checked = false;
            dr.Close();
            dr = null;
        }
        //Display_Notes_Selection
        private void lstnotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string r1 = "select TEXT_NOTE from note where TITLE_NOTE = '" + lstnotes.SelectedItem.ToString() + "'";
            string r2 = "select DATE_NOTE from note where TITLE_NOTE = '" + lstnotes.SelectedItem.ToString() + "'";
            string r3 = "select PUBLIC_NOTE from note where TITLE_NOTE = '" + lstnotes.SelectedItem.ToString() + "'";
            SqlCommand com = new SqlCommand(r1, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtnotedisplay.Text = dr[0].ToString();
            }
            dr.Close();
            dr = null;
            com = new SqlCommand(r2, cn);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                lbldate.Text = "Last modified on: " + Convert.ToDateTime(dr[0].ToString()).ToString("MMM dd,yyyy HH:mm");
            }
            dr.Close();
            dr = null;
            com = new SqlCommand(r3, cn);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == "TRUE")
                    cb_public.Checked = true;
                else
                    cb_public.Checked = false;
            }
            dr = null;
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
        //sketching_Modifs
        public FormNotes()
        {
            InitializeComponent();
            g = DrawingPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Black);
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
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
        //Button_Exit_Sketch
        private void btnexit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            if (cbAdd.Checked == true)
            {
                string req1 = "insert into note (ID_USER,TEXT_NOTE,DATE_NOTE,PUBLIC_NOTE,TITLE_NOTE) values (@iduser,@desc,@date,@public,@title)";
                SqlCommand com = new SqlCommand(req1, cn);
                com.Parameters.Add(new SqlParameter("@iduser", Convert.ToInt32(get_userID())));
                com.Parameters.Add(new SqlParameter("@desc", NoteText.Text));
                com.Parameters.Add(new SqlParameter("@title", TitleNote.Text));
                com.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                com.Parameters.Add(new SqlParameter("@public", chkBoxPulicNote.Checked));
                com.ExecuteNonQuery();
            }
            else
            {
                string req2 = "UPDATE note SET TITLE_NOTE = @title, TEXT_NOTE = @desc, DATE_NOTE = @date, PUBLIC_NOTE = @public WHERE ID_USER='"+get_userID()+ "' and TITLE_NOTE='"+ lstnotes.SelectedItem.ToString()+ "'";
                SqlCommand com = new SqlCommand(req2, cn);
                com.Parameters.Add(new SqlParameter("@desc", NoteText.Text));
                com.Parameters.Add(new SqlParameter("@title", TitleNote.Text));
                com.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                com.Parameters.Add(new SqlParameter("@public", chkBoxPulicNote.Checked));
                com.ExecuteNonQuery();
            }

            
            TitleNote.Text = "";
            NoteText.Text = "";

            cn.Close();
            cn = null;
            com = null;
        }

        

        
    }
}
