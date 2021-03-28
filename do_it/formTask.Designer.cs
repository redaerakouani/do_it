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
            this.combbx_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbx_cat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combbx_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbx_cat.FormattingEnabled = true;
            this.combbx_cat.Location = new System.Drawing.Point(12, 119);
            this.combbx_cat.Name = "combbx_cat";
            this.combbx_cat.Size = new System.Drawing.Size(275, 32);
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
            this.txt_new_tsk.BorderRadius = 25;
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
            this.txt_new_tsk.Location = new System.Drawing.Point(12, 446);
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
            this.txt_new_tsk.Size = new System.Drawing.Size(275, 40);
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
            this.DataGridtasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridtasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridtasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridtasks.ColumnHeadersVisible = false;
            this.DataGridtasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridtasks.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridtasks.EnableHeadersVisualStyles = false;
            this.DataGridtasks.Location = new System.Drawing.Point(12, 152);
            this.DataGridtasks.MultiSelect = false;
            this.DataGridtasks.Name = "DataGridtasks";
            this.DataGridtasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridtasks.RowHeadersVisible = false;
            this.DataGridtasks.RowHeadersWidth = 175;
            this.DataGridtasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridtasks.Size = new System.Drawing.Size(275, 288);
            this.DataGridtasks.TabIndex = 10;
            this.DataGridtasks.SelectionChanged += new System.EventHandler(this.DataGridtasks_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
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
            this.bunifuCheckBox1.Location = new System.Drawing.Point(176, 35);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox1.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(59, 59);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
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
            this.label1.Location = new System.Drawing.Point(72, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Done";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.combbx_cat;
            // 
            // formTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCheckBox1);
            this.Controls.Add(this.DataGridtasks);
            this.Controls.Add(this.txt_new_tsk);
            this.Controls.Add(this.combbx_cat);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTask";
            this.Text = "formTask";
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
    }
}