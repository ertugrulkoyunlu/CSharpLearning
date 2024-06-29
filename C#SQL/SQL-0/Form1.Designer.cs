namespace SQL_0
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbrg = new System.Windows.Forms.Button();
            this.tbm = new System.Windows.Forms.TextBox();
            this.tbun = new System.Windows.Forms.TextBox();
            this.tbsn = new System.Windows.Forms.TextBox();
            this.tbn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbrg);
            this.groupBox1.Controls.Add(this.tbm);
            this.groupBox1.Controls.Add(this.tbun);
            this.groupBox1.Controls.Add(this.tbsn);
            this.groupBox1.Controls.Add(this.tbn);
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register:";
            // 
            // tbrg
            // 
            this.tbrg.Location = new System.Drawing.Point(82, 158);
            this.tbrg.Name = "tbrg";
            this.tbrg.Size = new System.Drawing.Size(100, 37);
            this.tbrg.TabIndex = 4;
            this.tbrg.Text = " Register";
            this.tbrg.UseVisualStyleBackColor = true;
            this.tbrg.Click += new System.EventHandler(this.tbrg_Click);
            // 
            // tbm
            // 
            this.tbm.Location = new System.Drawing.Point(44, 120);
            this.tbm.Name = "tbm";
            this.tbm.Size = new System.Drawing.Size(181, 22);
            this.tbm.TabIndex = 3;
            // 
            // tbun
            // 
            this.tbun.Location = new System.Drawing.Point(44, 92);
            this.tbun.Name = "tbun";
            this.tbun.Size = new System.Drawing.Size(181, 22);
            this.tbun.TabIndex = 2;
            // 
            // tbsn
            // 
            this.tbsn.Location = new System.Drawing.Point(44, 64);
            this.tbsn.Name = "tbsn";
            this.tbsn.Size = new System.Drawing.Size(181, 22);
            this.tbsn.TabIndex = 1;
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(44, 36);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(181, 22);
            this.tbn.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tbrg;
        private System.Windows.Forms.TextBox tbm;
        private System.Windows.Forms.TextBox tbun;
        private System.Windows.Forms.TextBox tbsn;
        private System.Windows.Forms.TextBox tbn;
    }
}

