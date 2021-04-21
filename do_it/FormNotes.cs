using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace do_it
{
    public partial class FormNotes : Form
    {
        //Note
        string cs = ConfigurationManager.ConnectionStrings["do_it.Properties.Settings.DO_ITConnectionString"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        ////textBox_Note_Content
        public bool TextWasChanged = false;
        //scketching 
        //public int x = -1;
        //public int y = -1;
        public int h, w, x, y;
        public bool moving = false;
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen p;
        Bitmap surface;
        Graphics graph;
        string s ;
        int i = 0;
        public int width;
        public FormNotes()
        {
            InitializeComponent();
            g = DrawingPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Black);
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            clearSketch();


        }
        public void clearSketch()
        {
            surface = new Bitmap(DrawingPanel.Width, DrawingPanel.Height);
            graph = Graphics.FromImage(surface);
            DrawingPanel.BackgroundImage = surface;
            DrawingPanel.BackgroundImageLayout = ImageLayout.None;
        }
        private void FormNotes_Load(object sender, EventArgs e)
        {
            backPgnote.SetPage(note1);
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            //Greeting_Label
            string req = "select FULL_NAME from users where ID_USER = " + Program.get_userID();
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblGreeting.Text = dr[0].ToString() + "'s Notes";
            }
            dr.Close();
            //------------------------------------------------------------------------//
            //Title_List
            remplirlist();
            sketchDisplay.Visible = false;
            dr.Close();

        }

        //Delete_Note_Button
        private void deleteNote_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete this note ", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string req = "delete from NOTE where TITLE_NOTE ='" + lstnotes.SelectedItem.ToString() + "' and ID_USER = '" + Program.get_userID() + "'";
                cn = new SqlConnection(cs);
                cn.Open();
                com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                remplirlist();
                com = null;
                cn.Close();
            }
            try
            {
                File.Delete(s);
            }
            catch { };
        }
        //Methode_RemplireList
        public void remplirlist()
        {
            lstnotes.Items.Clear();
            string req = "select TITLE_NOTE from NOTE where ID_USER = " + Program.get_userID();
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
            backPgnote.SetPage(note2);
            cbAdd.Checked = true;
            //This Causes an issue the same sketch stays in all notes with the same user_Id but under diffrent names
             txtBoxSketch.Text = "";
           //after the exit of the app the pic is lost
        }
        //Note_TextBox
        private void NoteText_TextChanged(object sender, EventArgs e)
        {
            TextWasChanged = true;
            // ((TextBox)sender).Tag = "true";
        }
        //Button_Back_To_DisplayNotesPage
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (TextWasChanged == false)
            {
                backPgnote.SetPage(note1);
                txtnotedisplay.Text = "";
            }
            else
            {
                MessageBox.Show("Please save your modifications first.", "Alert", MessageBoxButtons.OK);

            }

        }
        //Button_Go_To_Sketching
        private void pictureBox1_Click(object sender, EventArgs e)
        {  // if()
           // DrawingPanel.
            backPgnote.SetPage(sketch);
            if(txtBoxSketch.Text=="")
            {
                clearSketch();
            }
            if (cbAdd.Checked == false)
            {
               
            }

        }
        //Modify_Note_Selected
        private void Btn_modifie_note_Click(object sender, EventArgs e)
        {
            if (lstnotes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a note to modify first.", "Alert", MessageBoxButtons.OK);

            }
            else
            {
                backPgnote.SetPage(note2);
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string req = "select TITLE_NOTE ,TEXT_NOTE,PUBLIC_NOTE,DATE_NOTE,SKETCH_NOTE from note where TITLE_NOTE = '" + lstnotes.SelectedItem.ToString() + "'";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    TitleNote.Text = dr[0].ToString();
                    NoteText.Text = dr[1].ToString();
                    chkBoxPulicNote.Checked = Convert.ToBoolean(dr[2].ToString());
                    txtBoxSketch.Text = dr[4].ToString();
                }
                cbAdd.Checked = false;
                dr.Close();
                dr = null;
            }
        }
        //Display_Notes_Selection
        private void lstnotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            try
            {
                string req = "select TEXT_NOTE,DATE_NOTE,PUBLIC_NOTE,SKETCH_NOTE from note where TITLE_NOTE = '" + lstnotes.SelectedItem.ToString() + "'";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    txtnotedisplay.Text = dr[0].ToString();
                    lbldate.Text = "Last modified on: " + Convert.ToDateTime(dr[1].ToString()).ToString("MMM dd,yyyy HH:mm");
                    cb_public.Checked = Convert.ToBoolean(dr[2].ToString());
                    if(dr[3].ToString()!=null && File.Exists(dr[3].ToString())==true)
                        sketchDisplay.Image = Image.FromFile(dr[3].ToString());
                    else
                        sketchDisplay.Image = Image.FromFile("null.png");
                }
                dr.Close();
                dr = null;
            }
            catch
            {

            }


        }
        //Button_Save
        private void btn_save_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            
            if (cbAdd.Checked == true)
            {
                string req1 = "insert into note (ID_USER,TEXT_NOTE,DATE_NOTE,PUBLIC_NOTE,TITLE_NOTE,SKETCH_NOTE) values (@iduser,@desc,@date,@public,@title,@sketch)";
                SqlCommand com = new SqlCommand(req1, cn);
                com.Parameters.Add(new SqlParameter("@iduser", Convert.ToInt32(Program.get_userID())));
                com.Parameters.Add(new SqlParameter("@desc", NoteText.Text));
                com.Parameters.Add(new SqlParameter("@title", TitleNote.Text));
                com.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                com.Parameters.Add(new SqlParameter("@public", chkBoxPulicNote.Checked));
                com.Parameters.Add(new SqlParameter("@sketch", txtBoxSketch.Text));
                com.ExecuteNonQuery();
            }
            else
            {
                //Maybe a try catch is needed
                string req2 = "UPDATE note SET TITLE_NOTE = @title, TEXT_NOTE = @desc, DATE_NOTE = @date, PUBLIC_NOTE = @public, SKETCH_NOTE=@sketch WHERE ID_USER='" + Program.get_userID() + "' and TITLE_NOTE='" + lstnotes.SelectedItem.ToString() + "'";
                SqlCommand com = new SqlCommand(req2, cn);
                com.Parameters.Add(new SqlParameter("@desc", NoteText.Text));
                com.Parameters.Add(new SqlParameter("@title", TitleNote.Text));
                com.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                com.Parameters.Add(new SqlParameter("@public", chkBoxPulicNote.Checked));
                com.Parameters.Add(new SqlParameter("@sketch", txtBoxSketch.Text));

                com.ExecuteNonQuery();
                
            }

            remplirlist();
            TitleNote.Text = "";
            NoteText.Text = "";
            backPgnote.SetPage(note1);
            txtnotedisplay.Text = "";
            cn.Close();
            cn = null;
            com = null;
            }
            catch
            {
                MessageBox.Show("Try another title...!");
            }

        }
        //Search_textBox
        private void txtBox_Search_NoteTitle_TextChanged(object sender, EventArgs e)
        {
            lstnotes.Items.Clear();
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string req = "select TITLE_NOTE from NOTE where TITLE_NOTE like '%" + txtBox_Search_NoteTitle.Text + "%' and ID_USER = '" + Program.get_userID() + "'";
            com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lstnotes.Items.Add(dr[0]);

            }
        }
        //Retrieve User ID
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
        //------------------------------------------------------------------------------------------------------//
        //sketching_Modifs
        //Tool_panel_modifs
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            if (rb_5.Checked == true)
                width = 5;
            else if (rb_10.Checked == true)
                width = 10;
            else if (rb_20.Checked == true)
                width = 20;
            else if (rb_30.Checked == true)
                width = 30;
            else if (rb_40.Checked == true)
                width = 40;
            else if (rb_50.Checked == true)
                width = 50;
            else
                width = 3;
            p.Width = width;
            x = e.X;
            y = e.Y;
        }
        //Mouse_events
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                graph.DrawLine(p, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                DrawingPanel.Cursor = Cursors.Cross;
                DrawingPanel.Invalidate();
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

        //Button_Save_Image
        private void btnSave_Click(object sender, EventArgs e)
        {

            s = "Sketch_" + Program.get_userID() + "_";
            if (txtBoxSketch.Text == "")
            {
                s = s + getRandomName() + ".png";
                surface.Save(s, ImageFormat.Png);
                txtBoxSketch.Text =s ;
            }else
            {
                s = s + getRandomName() + ".png";
                surface.Save(s, ImageFormat.Png);
                clearSketch();
                txtBoxSketch.Text = s;
            }
          
            MessageBox.Show("The Sketch is Saved !!.", "Notification", MessageBoxButtons.OK);
            backPgnote.SetPage(note2);

        }
        //Random_Number_proc
        private string getRandomName()
        {
            string Name = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "");
            Random r = new Random();
            long i = Math.Abs(r.Next() * 1000);
            return Name + i;
        }
        //Button_show_sketch
        private void btnShowSketch_Click(object sender, EventArgs e)
        {
           
            if(sketchDisplay.Visible == false)
            { 
                sketchDisplay.Visible = true;
                btnShowSketch.Image = do_it.Properties.Resources.text_50px;
            }
            else
            {
                sketchDisplay.Visible = false;
                btnShowSketch.Image = do_it.Properties.Resources.pqa;
            }
        }

        


        //
        //Button_Exit_Sketch
        private void btnexit_Click(object sender, EventArgs e)
        {
            backPgnote.SetPage(note2);
            //base.Close();
        }
        //Erasser_Button
        private void Erasser_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }
        //Color_Dialogue
        private void Color_Dialogue_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                p.Color = cd.Color;
                Black_pen.BackColor = cd.Color;

            }

        }



    }
    //Saving_sketch
    public class TPanel : Panel
    {
        public TPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}