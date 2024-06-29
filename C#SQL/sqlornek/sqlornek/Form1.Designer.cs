namespace sqlornek
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelDataSet = new sqlornek.PersonelDataSet();
            this.kisiBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kisiBilgiTableAdapter = new sqlornek.PersonelDataSetTableAdapters.KisiBilgiTableAdapter();
            this.personelNumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelNumarasiDataGridViewTextBoxColumn,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelSoyadDataGridViewTextBoxColumn,
            this.personeSehirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kisiBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1124, 588);
            this.dataGridView1.TabIndex = 0;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "PersonelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisiBilgiBindingSource
            // 
            this.kisiBilgiBindingSource.DataMember = "KisiBilgi";
            this.kisiBilgiBindingSource.DataSource = this.personelDataSet;
            // 
            // kisiBilgiTableAdapter
            // 
            this.kisiBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // personelNumarasiDataGridViewTextBoxColumn
            // 
            this.personelNumarasiDataGridViewTextBoxColumn.DataPropertyName = "PersonelNumarasi";
            this.personelNumarasiDataGridViewTextBoxColumn.HeaderText = "PersonelNumarasi";
            this.personelNumarasiDataGridViewTextBoxColumn.Name = "personelNumarasiDataGridViewTextBoxColumn";
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.HeaderText = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            // 
            // personelSoyadDataGridViewTextBoxColumn
            // 
            this.personelSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.Name = "personelSoyadDataGridViewTextBoxColumn";
            // 
            // personeSehirDataGridViewTextBoxColumn
            // 
            this.personeSehirDataGridViewTextBoxColumn.DataPropertyName = "PersoneSehir";
            this.personeSehirDataGridViewTextBoxColumn.HeaderText = "PersoneSehir";
            this.personeSehirDataGridViewTextBoxColumn.Name = "personeSehirDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 588);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBilgiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource kisiBilgiBindingSource;
        private PersonelDataSetTableAdapters.KisiBilgiTableAdapter kisiBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelNumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeSehirDataGridViewTextBoxColumn;
    }
}

