namespace do_it
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNote = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.listBoxTodayTasks = new System.Windows.Forms.ListBox();
            this.chkBoxPulicNote = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTasks = new System.Windows.Forms.Panel();
            this.panelNoTasks = new System.Windows.Forms.Panel();
            this.btnGoTasks = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTasks.SuspendLayout();
            this.panelNoTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.lblGreeting.Location = new System.Drawing.Point(50, 49);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(240, 45);
            this.lblGreeting.TabIndex = 22;
            this.lblGreeting.Text = "Good morning,";
            this.lblGreeting.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.lblName.Location = new System.Drawing.Point(50, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 45);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(441, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(53, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Anything on your mind? Write it down.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxNote.BackColor = System.Drawing.Color.White;
            this.txtBoxNote.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNote.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxNote.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxNote.HintText = "";
            this.txtBoxNote.isPassword = false;
            this.txtBoxNote.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.txtBoxNote.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtBoxNote.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtBoxNote.LineThickness = 3;
            this.txtBoxNote.Location = new System.Drawing.Point(55, 231);
            this.txtBoxNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNote.MaxLength = 32767;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(415, 33);
            this.txtBoxNote.TabIndex = 26;
            this.txtBoxNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxNote.OnValueChanged += new System.EventHandler(this.txtBoxNote_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Here are your tasks for today";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Add";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleBorderRadius = 40;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(495, 231);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 40;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 40;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(96, 45);
            this.bunifuButton1.TabIndex = 29;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // listBoxTodayTasks
            // 
            this.listBoxTodayTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTodayTasks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTodayTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.listBoxTodayTasks.FormattingEnabled = true;
            this.listBoxTodayTasks.ItemHeight = 25;
            this.listBoxTodayTasks.Location = new System.Drawing.Point(28, 39);
            this.listBoxTodayTasks.Name = "listBoxTodayTasks";
            this.listBoxTodayTasks.Size = new System.Drawing.Size(380, 100);
            this.listBoxTodayTasks.TabIndex = 30;
            // 
            // chkBoxPulicNote
            // 
            this.chkBoxPulicNote.AllowBindingControlAnimation = true;
            this.chkBoxPulicNote.AllowBindingControlColorChanges = false;
            this.chkBoxPulicNote.AllowBindingControlLocation = true;
            this.chkBoxPulicNote.AllowCheckBoxAnimation = false;
            this.chkBoxPulicNote.AllowCheckmarkAnimation = true;
            this.chkBoxPulicNote.AllowOnHoverStates = true;
            this.chkBoxPulicNote.AutoCheck = true;
            this.chkBoxPulicNote.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxPulicNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkBoxPulicNote.BackgroundImage")));
            this.chkBoxPulicNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkBoxPulicNote.BindingControl = null;
            this.chkBoxPulicNote.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkBoxPulicNote.Checked = true;
            this.chkBoxPulicNote.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chkBoxPulicNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxPulicNote.CustomCheckmarkImage = null;
            this.chkBoxPulicNote.Location = new System.Drawing.Point(55, 271);
            this.chkBoxPulicNote.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkBoxPulicNote.Name = "chkBoxPulicNote";
            this.chkBoxPulicNote.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.chkBoxPulicNote.OnCheck.BorderRadius = 2;
            this.chkBoxPulicNote.OnCheck.BorderThickness = 2;
            this.chkBoxPulicNote.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.chkBoxPulicNote.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkBoxPulicNote.OnCheck.CheckmarkThickness = 2;
            this.chkBoxPulicNote.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkBoxPulicNote.OnDisable.BorderRadius = 2;
            this.chkBoxPulicNote.OnDisable.BorderThickness = 2;
            this.chkBoxPulicNote.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkBoxPulicNote.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkBoxPulicNote.OnDisable.CheckmarkThickness = 2;
            this.chkBoxPulicNote.OnHoverChecked.BorderColor = System.Drawing.Color.DarkGray;
            this.chkBoxPulicNote.OnHoverChecked.BorderRadius = 2;
            this.chkBoxPulicNote.OnHoverChecked.BorderThickness = 2;
            this.chkBoxPulicNote.OnHoverChecked.CheckBoxColor = System.Drawing.Color.DarkGray;
            this.chkBoxPulicNote.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkBoxPulicNote.OnHoverChecked.CheckmarkThickness = 2;
            this.chkBoxPulicNote.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkBoxPulicNote.OnHoverUnchecked.BorderRadius = 2;
            this.chkBoxPulicNote.OnHoverUnchecked.BorderThickness = 2;
            this.chkBoxPulicNote.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkBoxPulicNote.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.chkBoxPulicNote.OnUncheck.BorderRadius = 2;
            this.chkBoxPulicNote.OnUncheck.BorderThickness = 2;
            this.chkBoxPulicNote.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkBoxPulicNote.Size = new System.Drawing.Size(21, 21);
            this.chkBoxPulicNote.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkBoxPulicNote.TabIndex = 31;
            this.chkBoxPulicNote.ThreeState = false;
            this.chkBoxPulicNote.ToolTipText = null;
            this.chkBoxPulicNote.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkBoxPulicNote_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(82, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Public";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelTasks
            // 
            this.panelTasks.Controls.Add(this.label2);
            this.panelTasks.Controls.Add(this.listBoxTodayTasks);
            this.panelTasks.Location = new System.Drawing.Point(53, 322);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(569, 149);
            this.panelTasks.TabIndex = 33;
            this.panelTasks.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTasks_Paint);
            // 
            // panelNoTasks
            // 
            this.panelNoTasks.Controls.Add(this.btnGoTasks);
            this.panelNoTasks.Controls.Add(this.label4);
            this.panelNoTasks.Location = new System.Drawing.Point(53, 322);
            this.panelNoTasks.Name = "panelNoTasks";
            this.panelNoTasks.Size = new System.Drawing.Size(569, 149);
            this.panelNoTasks.TabIndex = 34;
            this.panelNoTasks.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNoTasks_Paint);
            // 
            // btnGoTasks
            // 
            this.btnGoTasks.AllowToggling = false;
            this.btnGoTasks.AnimationSpeed = 200;
            this.btnGoTasks.AutoGenerateColors = false;
            this.btnGoTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnGoTasks.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.btnGoTasks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoTasks.BackgroundImage")));
            this.btnGoTasks.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGoTasks.ButtonText = "Go to Tasks";
            this.btnGoTasks.ButtonTextMarginLeft = 0;
            this.btnGoTasks.ColorContrastOnClick = 45;
            this.btnGoTasks.ColorContrastOnHover = 45;
            this.btnGoTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnGoTasks.CustomizableEdges = borderEdges2;
            this.btnGoTasks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGoTasks.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnGoTasks.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGoTasks.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGoTasks.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGoTasks.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGoTasks.ForeColor = System.Drawing.Color.White;
            this.btnGoTasks.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoTasks.IconMarginLeft = 11;
            this.btnGoTasks.IconPadding = 10;
            this.btnGoTasks.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoTasks.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnGoTasks.IdleBorderRadius = 40;
            this.btnGoTasks.IdleBorderThickness = 1;
            this.btnGoTasks.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.btnGoTasks.IdleIconLeftImage = null;
            this.btnGoTasks.IdleIconRightImage = null;
            this.btnGoTasks.IndicateFocus = false;
            this.btnGoTasks.Location = new System.Drawing.Point(-3, 60);
            this.btnGoTasks.Name = "btnGoTasks";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 40;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnGoTasks.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 40;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnGoTasks.OnPressedState = stateProperties4;
            this.btnGoTasks.Size = new System.Drawing.Size(572, 45);
            this.btnGoTasks.TabIndex = 34;
            this.btnGoTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoTasks.TextMarginLeft = 0;
            this.btnGoTasks.UseDefaultRadiusAndThickness = true;
            this.btnGoTasks.Click += new System.EventHandler(this.btnGoTasks_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "You seem to have no tasks for today. Would you like to add one?";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBoxPulicNote);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.panelNoTasks);
            this.Controls.Add(this.panelTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTasks.ResumeLayout(false);
            this.panelTasks.PerformLayout();
            this.panelNoTasks.ResumeLayout(false);
            this.panelNoTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxNote;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.ListBox listBoxTodayTasks;
        private Bunifu.UI.WinForms.BunifuCheckBox chkBoxPulicNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTasks;
        private System.Windows.Forms.Panel panelNoTasks;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGoTasks;
        private System.Windows.Forms.Label label4;
    }
}