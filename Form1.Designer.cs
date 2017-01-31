namespace MyAppendDB
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new MyAppendDB.Database1DataSet();
            this.mAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAINTableAdapter = new MyAppendDB.Database1DataSetTableAdapters.MAINTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUPRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uOMRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cODEDataGridViewTextBoxColumn,
            this.gROUPRDataGridViewTextBoxColumn,
            this.dESCRRDataGridViewTextBoxColumn,
            this.uOMRDataGridViewTextBoxColumn,
            this.iNSTYPEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mAINBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 308);
            this.dataGridView1.TabIndex = 2;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAINBindingSource
            // 
            this.mAINBindingSource.DataMember = "MAIN";
            this.mAINBindingSource.DataSource = this.database1DataSet;
            // 
            // mAINTableAdapter
            // 
            this.mAINTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // cODEDataGridViewTextBoxColumn
            // 
            this.cODEDataGridViewTextBoxColumn.DataPropertyName = "CODE";
            this.cODEDataGridViewTextBoxColumn.HeaderText = "CODE";
            this.cODEDataGridViewTextBoxColumn.Name = "cODEDataGridViewTextBoxColumn";
            // 
            // gROUPRDataGridViewTextBoxColumn
            // 
            this.gROUPRDataGridViewTextBoxColumn.DataPropertyName = "GROUPR";
            this.gROUPRDataGridViewTextBoxColumn.HeaderText = "GROUPR";
            this.gROUPRDataGridViewTextBoxColumn.Name = "gROUPRDataGridViewTextBoxColumn";
            // 
            // dESCRRDataGridViewTextBoxColumn
            // 
            this.dESCRRDataGridViewTextBoxColumn.DataPropertyName = "DESCRR";
            this.dESCRRDataGridViewTextBoxColumn.HeaderText = "DESCRR";
            this.dESCRRDataGridViewTextBoxColumn.Name = "dESCRRDataGridViewTextBoxColumn";
            // 
            // uOMRDataGridViewTextBoxColumn
            // 
            this.uOMRDataGridViewTextBoxColumn.DataPropertyName = "UOMR";
            this.uOMRDataGridViewTextBoxColumn.HeaderText = "UOMR";
            this.uOMRDataGridViewTextBoxColumn.Name = "uOMRDataGridViewTextBoxColumn";
            // 
            // iNSTYPEDataGridViewTextBoxColumn
            // 
            this.iNSTYPEDataGridViewTextBoxColumn.DataPropertyName = "INS_TYPE";
            this.iNSTYPEDataGridViewTextBoxColumn.HeaderText = "INS_TYPE";
            this.iNSTYPEDataGridViewTextBoxColumn.Name = "iNSTYPEDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource mAINBindingSource;
        private MyAppendDB.Database1DataSetTableAdapters.MAINTableAdapter mAINTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gROUPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uOMRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSTYPEDataGridViewTextBoxColumn;
    }
}

