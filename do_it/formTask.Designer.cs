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
            this.txtmail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.dO_ITDataSet1 = new do_it.DO_ITDataSet();
            this.DataGridtasks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.combbx_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbx_cat.FormattingEnabled = true;
            this.combbx_cat.Location = new System.Drawing.Point(12, 58);
            this.combbx_cat.Name = "combbx_cat";
            this.combbx_cat.Size = new System.Drawing.Size(275, 32);
            this.combbx_cat.TabIndex = 1;
            // 
            // txtmail
            // 
            this.txtmail.AcceptsReturn = false;
            this.txtmail.AcceptsTab = false;
            this.txtmail.AnimationSpeed = 200;
            this.txtmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmail.BackColor = System.Drawing.Color.Transparent;
            this.txtmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtmail.BackgroundImage")));
            this.txtmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.txtmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.txtmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.txtmail.BorderRadius = 25;
            this.txtmail.BorderThickness = 2;
            this.txtmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmail.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtmail.DefaultText = "";
            this.txtmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.txtmail.HideSelection = true;
            this.txtmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtmail.IconLeft")));
            this.txtmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmail.IconPadding = 8;
            this.txtmail.IconRight = null;
            this.txtmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmail.Lines = new string[0];
            this.txtmail.Location = new System.Drawing.Point(12, 385);
            this.txtmail.MaxLength = 32767;
            this.txtmail.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtmail.Modified = false;
            this.txtmail.Multiline = false;
            this.txtmail.Name = "txtmail";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmail.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtmail.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmail.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmail.OnIdleState = stateProperties4;
            this.txtmail.PasswordChar = '\0';
            this.txtmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtmail.PlaceholderText = "New task";
            this.txtmail.ReadOnly = false;
            this.txtmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmail.SelectedText = "";
            this.txtmail.SelectionLength = 0;
            this.txtmail.SelectionStart = 0;
            this.txtmail.ShortcutsEnabled = true;
            this.txtmail.Size = new System.Drawing.Size(275, 40);
            this.txtmail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtmail.TabIndex = 8;
            this.txtmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmail.TextMarginBottom = 0;
            this.txtmail.TextMarginLeft = 12;
            this.txtmail.TextMarginTop = 0;
            this.txtmail.TextPlaceholder = "New task";
            this.txtmail.UseSystemPasswordChar = false;
            this.txtmail.WordWrap = true;
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
            this.DataGridtasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridtasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridtasks.ColumnHeadersVisible = false;
            this.DataGridtasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridtasks.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridtasks.EnableHeadersVisualStyles = false;
            this.DataGridtasks.Location = new System.Drawing.Point(12, 91);
            this.DataGridtasks.MultiSelect = false;
            this.DataGridtasks.Name = "DataGridtasks";
            this.DataGridtasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridtasks.RowHeadersVisible = false;
            this.DataGridtasks.RowHeadersWidth = 175;
            this.DataGridtasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridtasks.Size = new System.Drawing.Size(275, 288);
            this.DataGridtasks.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // formTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 519);
            this.Controls.Add(this.DataGridtasks);
            this.Controls.Add(this.txtmail);
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

        }

        #endregion

        private DO_ITDataSet dO_ITDataSet;
        private System.Windows.Forms.BindingSource cATEGORIEBindingSource;
        private DO_ITDataSetTableAdapters.CATEGORIETableAdapter cATEGORIETableAdapter;
        private DO_ITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DO_ITDataSetTableAdapters.TASKTableAdapter tASKTableAdapter;
        private System.Windows.Forms.BindingSource tASKBindingSource;
        private System.Windows.Forms.ComboBox combbx_cat;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtmail;
        private DO_ITDataSet dO_ITDataSet1;
        private System.Windows.Forms.DataGridView DataGridtasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}