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
            this.dO_ITDataSet = new do_it.DO_ITDataSet();
            this.cATEGORIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORIETableAdapter = new do_it.DO_ITDataSetTableAdapters.CATEGORIETableAdapter();
            this.tableAdapterManager = new do_it.DO_ITDataSetTableAdapters.TableAdapterManager();
            this.tASKTableAdapter = new do_it.DO_ITDataSetTableAdapters.TASKTableAdapter();
            this.cATEGORIEComboBox = new System.Windows.Forms.ComboBox();
            this.tASKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tASKListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dO_ITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).BeginInit();
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
            // cATEGORIEComboBox
            // 
            this.cATEGORIEComboBox.DataSource = this.cATEGORIEBindingSource;
            this.cATEGORIEComboBox.DisplayMember = "CAT_NAME";
            this.cATEGORIEComboBox.FormattingEnabled = true;
            this.cATEGORIEComboBox.Location = new System.Drawing.Point(33, 60);
            this.cATEGORIEComboBox.Name = "cATEGORIEComboBox";
            this.cATEGORIEComboBox.Size = new System.Drawing.Size(300, 21);
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
            this.tASKListBox.DataSource = this.tASKBindingSource;
            this.tASKListBox.DisplayMember = "DESCRIPTION";
            this.tASKListBox.FormattingEnabled = true;
            this.tASKListBox.Location = new System.Drawing.Point(33, 137);
            this.tASKListBox.Name = "tASKListBox";
            this.tASKListBox.Size = new System.Drawing.Size(300, 212);
            this.tASKListBox.TabIndex = 1;
            this.tASKListBox.ValueMember = "ID_TASK";
            // 
            // formTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 519);
            this.Controls.Add(this.tASKListBox);
            this.Controls.Add(this.cATEGORIEComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTask";
            this.Text = "formTask";
            this.Load += new System.EventHandler(this.formTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dO_ITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}