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
            System.Windows.Forms.Label sTART_TIMELabel;
            System.Windows.Forms.Label eND_TIMELabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label sTATUSLabel;
            System.Windows.Forms.Label pUBLIC_TASKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTask));
            this.dO_ITDataSet = new do_it.DO_ITDataSet();
            this.cATEGORIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORIETableAdapter = new do_it.DO_ITDataSetTableAdapters.CATEGORIETableAdapter();
            this.tableAdapterManager = new do_it.DO_ITDataSetTableAdapters.TableAdapterManager();
            this.tASKTableAdapter = new do_it.DO_ITDataSetTableAdapters.TASKTableAdapter();
            this.cATEGORIEComboBox = new System.Windows.Forms.ComboBox();
            this.tASKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tASKListBox = new System.Windows.Forms.ListBox();
            this.sTART_TIMEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eND_TIMEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.sTATUSCheckBox = new System.Windows.Forms.CheckBox();
            this.pUBLIC_TASKCheckBox = new System.Windows.Forms.CheckBox();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuCheckBox3 = new Bunifu.UI.WinForms.BunifuCheckBox();
            sTART_TIMELabel = new System.Windows.Forms.Label();
            eND_TIMELabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            sTATUSLabel = new System.Windows.Forms.Label();
            pUBLIC_TASKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dO_ITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sTART_TIMELabel
            // 
            sTART_TIMELabel.AutoSize = true;
            sTART_TIMELabel.Location = new System.Drawing.Point(430, 219);
            sTART_TIMELabel.Name = "sTART_TIMELabel";
            sTART_TIMELabel.Size = new System.Drawing.Size(75, 13);
            sTART_TIMELabel.TabIndex = 8;
            sTART_TIMELabel.Text = "START TIME:";
            // 
            // eND_TIMELabel
            // 
            eND_TIMELabel.AutoSize = true;
            eND_TIMELabel.Location = new System.Drawing.Point(430, 245);
            eND_TIMELabel.Name = "eND_TIMELabel";
            eND_TIMELabel.Size = new System.Drawing.Size(62, 13);
            eND_TIMELabel.TabIndex = 10;
            eND_TIMELabel.Text = "END TIME:";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dESCRIPTIONLabel.Location = new System.Drawing.Point(385, 151);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(141, 20);
            dESCRIPTIONLabel.TabIndex = 12;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // sTATUSLabel
            // 
            sTATUSLabel.AutoSize = true;
            sTATUSLabel.Location = new System.Drawing.Point(475, 298);
            sTATUSLabel.Name = "sTATUSLabel";
            sTATUSLabel.Size = new System.Drawing.Size(53, 13);
            sTATUSLabel.TabIndex = 14;
            sTATUSLabel.Text = "STATUS:";
            // 
            // pUBLIC_TASKLabel
            // 
            pUBLIC_TASKLabel.AutoSize = true;
            pUBLIC_TASKLabel.Location = new System.Drawing.Point(475, 328);
            pUBLIC_TASKLabel.Name = "pUBLIC_TASKLabel";
            pUBLIC_TASKLabel.Size = new System.Drawing.Size(79, 13);
            pUBLIC_TASKLabel.TabIndex = 16;
            pUBLIC_TASKLabel.Text = "PUBLIC TASK:";
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
            // cATEGORIEComboBox
            // 
            this.cATEGORIEComboBox.DataSource = this.cATEGORIEBindingSource;
            this.cATEGORIEComboBox.DisplayMember = "CAT_NAME";
            this.cATEGORIEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cATEGORIEComboBox.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cATEGORIEComboBox.ForeColor = System.Drawing.Color.CadetBlue;
            this.cATEGORIEComboBox.FormattingEnabled = true;
            this.cATEGORIEComboBox.Location = new System.Drawing.Point(210, 31);
            this.cATEGORIEComboBox.Name = "cATEGORIEComboBox";
            this.cATEGORIEComboBox.Size = new System.Drawing.Size(410, 30);
            this.cATEGORIEComboBox.TabIndex = 1;
            this.cATEGORIEComboBox.ValueMember = "ID_CATEGORIE_";
            // 
            // tASKBindingSource
            // 
            this.tASKBindingSource.DataMember = "FK_TASK_APPARTIEN_CATEGORI";
            this.tASKBindingSource.DataSource = this.cATEGORIEBindingSource;
            // 
            // tASKListBox
            // 
            this.tASKListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tASKListBox.DataSource = this.tASKBindingSource;
            this.tASKListBox.DisplayMember = "DESCRIPTION";
            this.tASKListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tASKListBox.ForeColor = System.Drawing.Color.CadetBlue;
            this.tASKListBox.FormattingEnabled = true;
            this.tASKListBox.ItemHeight = 20;
            this.tASKListBox.Location = new System.Drawing.Point(33, 137);
            this.tASKListBox.Name = "tASKListBox";
            this.tASKListBox.Size = new System.Drawing.Size(300, 204);
            this.tASKListBox.TabIndex = 1;
            this.tASKListBox.ValueMember = "ID_TASK";
            // 
            // sTART_TIMEDateTimePicker
            // 
            this.sTART_TIMEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tASKBindingSource, "START_TIME", true));
            this.sTART_TIMEDateTimePicker.Location = new System.Drawing.Point(525, 215);
            this.sTART_TIMEDateTimePicker.Name = "sTART_TIMEDateTimePicker";
            this.sTART_TIMEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sTART_TIMEDateTimePicker.TabIndex = 9;
            // 
            // eND_TIMEDateTimePicker
            // 
            this.eND_TIMEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tASKBindingSource, "END_TIME", true));
            this.eND_TIMEDateTimePicker.Location = new System.Drawing.Point(525, 241);
            this.eND_TIMEDateTimePicker.Name = "eND_TIMEDateTimePicker";
            this.eND_TIMEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eND_TIMEDateTimePicker.TabIndex = 11;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tASKBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(530, 150);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(251, 20);
            this.dESCRIPTIONTextBox.TabIndex = 13;
            // 
            // sTATUSCheckBox
            // 
            this.sTATUSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tASKBindingSource, "STATUS", true));
            this.sTATUSCheckBox.Location = new System.Drawing.Point(570, 293);
            this.sTATUSCheckBox.Name = "sTATUSCheckBox";
            this.sTATUSCheckBox.Size = new System.Drawing.Size(200, 24);
            this.sTATUSCheckBox.TabIndex = 15;
            this.sTATUSCheckBox.Text = "checkBox1";
            this.sTATUSCheckBox.UseVisualStyleBackColor = true;
            // 
            // pUBLIC_TASKCheckBox
            // 
            this.pUBLIC_TASKCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tASKBindingSource, "PUBLIC_TASK", true));
            this.pUBLIC_TASKCheckBox.Location = new System.Drawing.Point(570, 323);
            this.pUBLIC_TASKCheckBox.Name = "pUBLIC_TASKCheckBox";
            this.pUBLIC_TASKCheckBox.Size = new System.Drawing.Size(200, 24);
            this.pUBLIC_TASKCheckBox.TabIndex = 17;
            this.pUBLIC_TASKCheckBox.Text = "checkBox1";
            this.pUBLIC_TASKCheckBox.UseVisualStyleBackColor = true;
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
            this.bunifuCheckBox1.Location = new System.Drawing.Point(676, 290);
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
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 18;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // bunifuCheckBox3
            // 
            this.bunifuCheckBox3.AllowBindingControlAnimation = true;
            this.bunifuCheckBox3.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox3.AllowBindingControlLocation = true;
            this.bunifuCheckBox3.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox3.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox3.AllowOnHoverStates = true;
            this.bunifuCheckBox3.AutoCheck = true;
            this.bunifuCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox3.BackgroundImage")));
            this.bunifuCheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox3.BindingControl = null;
            this.bunifuCheckBox3.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox3.Checked = true;
            this.bunifuCheckBox3.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox3.CustomCheckmarkImage = null;
            this.bunifuCheckBox3.Location = new System.Drawing.Point(676, 323);
            this.bunifuCheckBox3.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox3.Name = "bunifuCheckBox3";
            this.bunifuCheckBox3.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox3.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox3.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox3.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox3.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox3.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox3.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox3.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox3.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox3.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox3.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox3.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox3.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox3.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox3.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox3.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox3.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox3.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox3.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox3.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox3.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox3.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox3.TabIndex = 20;
            this.bunifuCheckBox3.ThreeState = false;
            this.bunifuCheckBox3.ToolTipText = null;
            // 
            // formTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 519);
            this.Controls.Add(this.bunifuCheckBox3);
            this.Controls.Add(this.bunifuCheckBox1);
            this.Controls.Add(sTART_TIMELabel);
            this.Controls.Add(this.sTART_TIMEDateTimePicker);
            this.Controls.Add(eND_TIMELabel);
            this.Controls.Add(this.eND_TIMEDateTimePicker);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(sTATUSLabel);
            this.Controls.Add(this.sTATUSCheckBox);
            this.Controls.Add(pUBLIC_TASKLabel);
            this.Controls.Add(this.pUBLIC_TASKCheckBox);
            this.Controls.Add(this.tASKListBox);
            this.Controls.Add(this.cATEGORIEComboBox);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTask";
            this.Text = "formTask";
            this.Load += new System.EventHandler(this.formTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dO_ITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DO_ITDataSet dO_ITDataSet;
        private System.Windows.Forms.BindingSource cATEGORIEBindingSource;
        private DO_ITDataSetTableAdapters.CATEGORIETableAdapter cATEGORIETableAdapter;
        private DO_ITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cATEGORIEComboBox;
        private DO_ITDataSetTableAdapters.TASKTableAdapter tASKTableAdapter;
        private System.Windows.Forms.BindingSource tASKBindingSource;
        private System.Windows.Forms.ListBox tASKListBox;
        private System.Windows.Forms.DateTimePicker sTART_TIMEDateTimePicker;
        private System.Windows.Forms.DateTimePicker eND_TIMEDateTimePicker;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.CheckBox sTATUSCheckBox;
        private System.Windows.Forms.CheckBox pUBLIC_TASKCheckBox;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox3;
    }
}