namespace do_it
{
    partial class FormNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotes));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.NotePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Pgnote = new Bunifu.UI.WinForms.BunifuPages();
            this.note1 = new System.Windows.Forms.TabPage();
            this.note2 = new System.Windows.Forms.TabPage();
            this.sketch = new System.Windows.Forms.TabPage();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.NotePanel.SuspendLayout();
            this.Pgnote.SuspendLayout();
            this.sketch.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotePanel
            // 
            this.NotePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NotePanel.BackgroundImage")));
            this.NotePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotePanel.Controls.Add(this.Pgnote);
            this.NotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotePanel.GradientBottomLeft = System.Drawing.Color.White;
            this.NotePanel.GradientBottomRight = System.Drawing.Color.White;
            this.NotePanel.GradientTopLeft = System.Drawing.Color.White;
            this.NotePanel.GradientTopRight = System.Drawing.Color.White;
            this.NotePanel.Location = new System.Drawing.Point(0, 0);
            this.NotePanel.Name = "NotePanel";
            this.NotePanel.Quality = 10;
            this.NotePanel.Size = new System.Drawing.Size(684, 519);
            this.NotePanel.TabIndex = 0;
            // 
            // Pgnote
            // 
            this.Pgnote.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Pgnote.AllowTransitions = true;
            this.Pgnote.Controls.Add(this.note1);
            this.Pgnote.Controls.Add(this.note2);
            this.Pgnote.Controls.Add(this.sketch);
            this.Pgnote.Location = new System.Drawing.Point(3, 3);
            this.Pgnote.Multiline = true;
            this.Pgnote.Name = "Pgnote";
            this.Pgnote.Page = this.sketch;
            this.Pgnote.PageIndex = 2;
            this.Pgnote.PageName = "sketch";
            this.Pgnote.PageTitle = "Sketching";
            this.Pgnote.SelectedIndex = 0;
            this.Pgnote.Size = new System.Drawing.Size(681, 516);
            this.Pgnote.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Pgnote.Transition = animation1;
            this.Pgnote.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // note1
            // 
            this.note1.Location = new System.Drawing.Point(4, 4);
            this.note1.Name = "note1";
            this.note1.Padding = new System.Windows.Forms.Padding(3);
            this.note1.Size = new System.Drawing.Size(673, 490);
            this.note1.TabIndex = 0;
            this.note1.Text = "Pgnote1";
            this.note1.UseVisualStyleBackColor = true;
            // 
            // note2
            // 
            this.note2.Location = new System.Drawing.Point(4, 4);
            this.note2.Name = "note2";
            this.note2.Padding = new System.Windows.Forms.Padding(3);
            this.note2.Size = new System.Drawing.Size(673, 490);
            this.note2.TabIndex = 1;
            this.note2.Text = "Pgnote2";
            this.note2.UseVisualStyleBackColor = true;
            // 
            // sketch
            // 
            this.sketch.Controls.Add(this.DrawingPanel);
            this.sketch.Controls.Add(this.ToolsPanel);
            this.sketch.Location = new System.Drawing.Point(4, 4);
            this.sketch.Name = "sketch";
            this.sketch.Padding = new System.Windows.Forms.Padding(3);
            this.sketch.Size = new System.Drawing.Size(673, 490);
            this.sketch.TabIndex = 2;
            this.sketch.Text = "Sketching";
            this.sketch.UseVisualStyleBackColor = true;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Location = new System.Drawing.Point(633, 6);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(34, 478);
            this.ToolsPanel.TabIndex = 0;
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(6, 6);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(621, 481);
            this.DrawingPanel.TabIndex = 1;
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 519);
            this.Controls.Add(this.NotePanel);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotes";
            this.Text = "FormNotes";
            this.NotePanel.ResumeLayout(false);
            this.Pgnote.ResumeLayout(false);
            this.sketch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel NotePanel;
        private Bunifu.UI.WinForms.BunifuPages Pgnote;
        private System.Windows.Forms.TabPage note1;
        private System.Windows.Forms.TabPage note2;
        private System.Windows.Forms.TabPage sketch;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Panel DrawingPanel;
    }
}