namespace do_it
{
    partial class formTask
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTask));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dO_ITDataSet = new do_it.DO_ITDataSet();
            this.cATEGORIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORIETableAdapter = new do_it.DO_ITDataSetTableAdapters.CATEGORIETableAdapter();
            this.tableAdapterManager = new do_it.DO_ITDataSetTableAdapters.TableAdapterManager();
            this.tASKTableAdapter = new do_it.DO_ITDataSetTableAdapters.TASKTableAdapter();
            this.tASKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combbx_cat = new System.Windows.Forms.ComboBox();
            this.txt_new_tsk = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.dO_ITDataSet1 = new do_it.DO_ITDataSet();
            this.DataGridtasks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCheckBox4 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dO_ITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dO_ITDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridtasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dO_ITDataSet
            // 
            this.dO_ITDataSet.DataSetName = "DO_ITDataSet";
            this.dO_ITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORIEBindingSource
            // 
            this.cATEGORIEBindingSource.DataMember = "CATEGORIE";
            this.cATEGORIEBindingSource.DataSource = this.dO_ITDataSet;
            // 
            // cATEGORIETableAdapter
            // 
            this.cATEGORIETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIETableAdapter = this.cATEGORIETableAdapter;
            this.tableAdapterManager.NOTETableAdapter = null;
            this.tableAdapterManager.TASKTableAdapter = this.tASKTableAdapter;
            this.tableAdapterManager.UpdateOrder = do_it.DO_ITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // tASKTableAdapter
            // 
            this.tASKTableAdapter.ClearBeforeFill = true;
            // 
            // tASKBindingSource
            // 
            this.tASKBindingSource.DataMember = "FK_TASK_APPARTIEN_CATEGORI";
            this.tASKBindingSource.DataSource = this.cATEGORIEBindingSource;
            // 
            // combbx_cat
            // 
            this.combbx_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.combbx_cat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combbx_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbx_cat.ForeColor = System.Drawing.Color.White;
            this.combbx_cat.FormattingEnabled = true;
            this.combbx_cat.Location = new System.Drawing.Point(32, 103);
            this.combbx_cat.Name = "combbx_cat";
            this.combbx_cat.Size = new System.Drawing.Size(268, 33);
            this.combbx_cat.TabIndex = 1;
            this.combbx_cat.SelectedIndexChanged += new System.EventHandler(this.combbx_cat_SelectedIndexChanged);
            // 
            // txt_new_tsk
            // 
            this.txt_new_tsk.AcceptsReturn = false;
            this.txt_new_tsk.AcceptsTab = false;
            this.txt_new_tsk.AnimationSpeed = 200;
            this.txt_new_tsk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_new_tsk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_new_tsk.BackColor = System.Drawing.Color.Transparent;
            this.txt_new_tsk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_new_tsk.BackgroundImage")));
            this.txt_new_tsk.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.txt_new_tsk.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_new_tsk.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.txt_new_tsk.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.txt_new_tsk.BorderRadius = 35;
            this.txt_new_tsk.BorderThickness = 2;
            this.txt_new_tsk.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_new_tsk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_new_tsk.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_new_tsk.DefaultText = "";
            this.txt_new_tsk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_new_tsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.txt_new_tsk.HideSelection = true;
            this.txt_new_tsk.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_new_tsk.IconLeft")));
            this.txt_new_tsk.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_new_tsk.IconPadding = 8;
            this.txt_new_tsk.IconRight = null;
            this.txt_new_tsk.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_new_tsk.Lines = new string[0];
            this.txt_new_tsk.Location = new System.Drawing.Point(24, 429);
            this.txt_new_tsk.MaxLength = 32767;
            this.txt_new_tsk.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_new_tsk.Modified = false;
            this.txt_new_tsk.Multiline = false;
            this.txt_new_tsk.Name = "txt_new_tsk";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_new_tsk.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_new_tsk.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_new_tsk.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_new_tsk.OnIdleState = stateProperties4;
            this.txt_new_tsk.PasswordChar = '\0';
            this.txt_new_tsk.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_new_tsk.PlaceholderText = "New task";
            this.txt_new_tsk.ReadOnly = false;
            this.txt_new_tsk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_new_tsk.SelectedText = "";
            this.txt_new_tsk.SelectionLength = 0;
            this.txt_new_tsk.SelectionStart = 0;
            this.txt_new_tsk.ShortcutsEnabled = true;
            this.txt_new_tsk.Size = new System.Drawing.Size(281, 43);
            this.txt_new_tsk.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_new_tsk.TabIndex = 8;
            this.txt_new_tsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_new_tsk.TextMarginBottom = 0;
            this.txt_new_tsk.TextMarginLeft = 12;
            this.txt_new_tsk.TextMarginTop = 0;
            this.txt_new_tsk.TextPlaceholder = "New task";
            this.txt_new_tsk.UseSystemPasswordChar = false;
            this.txt_new_tsk.WordWrap = true;
            // 
            // dO_ITDataSet1
            // 
            this.dO_ITDataSet1.DataSetName = "DO_ITDataSet";
            this.dO_ITDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataGridtasks
            // 
            this.DataGridtasks.AllowUserToDeleteRows = false;
            this.DataGridtasks.AllowUserToResizeColumns = false;
            this.DataGridtasks.AllowUserToResizeRows = false;
            this.DataGridtasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridtasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.DataGridtasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridtasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridtasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridtasks.ColumnHeadersVisible = false;
            this.DataGridtasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DataGridtasks.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridtasks.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridtasks.EnableHeadersVisualStyles = false;
            this.DataGridtasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.DataGridtasks.Location = new System.Drawing.Point(32, 141);
            this.DataGridtasks.MultiSelect = false;
            this.DataGridtasks.Name = "DataGridtasks";
            this.DataGridtasks.ReadOnly = true;
            this.DataGridtasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridtasks.RowHeadersVisible = false;
            this.DataGridtasks.RowHeadersWidth = 175;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridtasks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridtasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridtasks.Size = new System.Drawing.Size(268, 288);
            this.DataGridtasks.TabIndex = 10;
            this.DataGridtasks.SelectionChanged += new System.EventHandler(this.DataGridtasks_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControl = null;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(190, 38);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuCheckBox1.OnCheck.BorderRadius = 1;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 1;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 1;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 1;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(56, 56);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round;
            this.bunifuCheckBox1.TabIndex = 13;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            this.bunifuCheckBox1.Click += new System.EventHandler(this.bunifuCheckBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Done";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this.bunifuCheckBox4;
            // 
            // bunifuCheckBox4
            // 
            this.bunifuCheckBox4.AllowBindingControlAnimation = true;
            this.bunifuCheckBox4.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox4.AllowBindingControlLocation = true;
            this.bunifuCheckBox4.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox4.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox4.AllowOnHoverStates = true;
            this.bunifuCheckBox4.AutoCheck = true;
            this.bunifuCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox4.BackgroundImage")));
            this.bunifuCheckBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox4.BindingControl = null;
            this.bunifuCheckBox4.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox4.Checked = true;
            this.bunifuCheckBox4.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox4.CustomCheckmarkImage = null;
            this.bunifuCheckBox4.Location = new System.Drawing.Point(568, 104);
            this.bunifuCheckBox4.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox4.Name = "bunifuCheckBox4";
            this.bunifuCheckBox4.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuCheckBox4.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox4.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox4.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuCheckBox4.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox4.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox4.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox4.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox4.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox4.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox4.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox4.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox4.OnHoverChecked.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCheckBox4.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox4.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox4.OnHoverChecked.CheckBoxColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCheckBox4.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox4.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox4.OnHoverUnchecked.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCheckBox4.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox4.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox4.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox4.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuCheckBox4.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox4.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox4.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox4.Size = new System.Drawing.Size(44, 44);
            this.bunifuCheckBox4.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round;
            this.bunifuCheckBox4.TabIndex = 25;
            this.bunifuCheckBox4.ThreeState = false;
            this.bunifuCheckBox4.ToolTipText = null;
            this.bunifuCheckBox4.Click += new System.EventHandler(this.bunifuCheckBox4_Click);
            // 
            // btn_add
            // 
            this.btn_add.Active = false;
            this.btn_add.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 0;
            this.btn_add.ButtonText = "";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_add.Iconimage")));
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 0;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = true;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 90D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(306, 426);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_add.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(46, 48);
            this.btn_add.TabIndex = 16;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuDatepicker2.BorderRadius = 30;
            this.bunifuDatepicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(359, 310);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(303, 47);
            this.bunifuDatepicker2.TabIndex = 18;
            this.bunifuDatepicker2.Value = new System.DateTime(2021, 3, 28, 21, 56, 10, 996);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.bunifuDatepicker1.BorderRadius = 30;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(359, 194);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(266, 35);
            this.bunifuDatepicker1.TabIndex = 19;
            this.bunifuDatepicker1.Value = new System.DateTime(2021, 3, 28, 9, 56, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(406, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 45);
            this.label2.TabIndex = 21;
            this.label2.Text = "Public";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(310, 330);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(46, 40);
            this.bunifuFlatButton2.TabIndex = 26;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(306, 375);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(46, 47);
            this.bunifuFlatButton3.TabIndex = 27;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(368, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Start Time ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(368, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "End Time";
            // 
            // formTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuCheckBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.bunifuDatepicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCheckBox1);
            this.Controls.Add(this.DataGridtasks);
            this.Controls.Add(this.txt_new_tsk);
            this.Controls.Add(this.combbx_cat);
            this.Controls.Add(this.btn_add);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTask";
            this.Load += new System.EventHandler(this.formTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dO_ITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dO_ITDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridtasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DO_ITDataSet dO_ITDataSet;
        private System.Windows.Forms.BindingSource cATEGORIEBindingSource;
        private DO_ITDataSetTableAdapters.CATEGORIETableAdapter cATEGORIETableAdapter;
        private DO_ITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DO_ITDataSetTableAdapters.TASKTableAdapter tASKTableAdapter;
        private System.Windows.Forms.BindingSource tASKBindingSource;
        private System.Windows.Forms.ComboBox combbx_cat;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_new_tsk;
        private DO_ITDataSet dO_ITDataSet1;
        private System.Windows.Forms.DataGridView DataGridtasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}