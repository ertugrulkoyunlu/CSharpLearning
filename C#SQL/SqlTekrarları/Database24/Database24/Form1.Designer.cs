namespace Database24
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veroGirisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboneBilgiGirisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayitAramaSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayitDegistirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harcamaMiktariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veroGirisiToolStripMenuItem,
            this.hesaplamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veroGirisiToolStripMenuItem
            // 
            this.veroGirisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboneBilgiGirisiToolStripMenuItem,
            this.kayitAramaSilmeToolStripMenuItem,
            this.kayitDegistirmeToolStripMenuItem});
            this.veroGirisiToolStripMenuItem.Name = "veroGirisiToolStripMenuItem";
            this.veroGirisiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.veroGirisiToolStripMenuItem.Text = "Veri girisi";
            // 
            // aboneBilgiGirisiToolStripMenuItem
            // 
            this.aboneBilgiGirisiToolStripMenuItem.Name = "aboneBilgiGirisiToolStripMenuItem";
            this.aboneBilgiGirisiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboneBilgiGirisiToolStripMenuItem.Text = "Abone bilgi girisi";
            this.aboneBilgiGirisiToolStripMenuItem.Click += new System.EventHandler(this.aboneBilgiGirisiToolStripMenuItem_Click);
            // 
            // kayitAramaSilmeToolStripMenuItem
            // 
            this.kayitAramaSilmeToolStripMenuItem.Name = "kayitAramaSilmeToolStripMenuItem";
            this.kayitAramaSilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayitAramaSilmeToolStripMenuItem.Text = "Kayit arama silme";
            this.kayitAramaSilmeToolStripMenuItem.Click += new System.EventHandler(this.kayitAramaSilmeToolStripMenuItem_Click);
            // 
            // kayitDegistirmeToolStripMenuItem
            // 
            this.kayitDegistirmeToolStripMenuItem.Name = "kayitDegistirmeToolStripMenuItem";
            this.kayitDegistirmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayitDegistirmeToolStripMenuItem.Text = "Kayit degistirme";
            this.kayitDegistirmeToolStripMenuItem.Click += new System.EventHandler(this.kayitDegistirmeToolStripMenuItem_Click);
            // 
            // hesaplamaToolStripMenuItem
            // 
            this.hesaplamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.harcamaMiktariToolStripMenuItem});
            this.hesaplamaToolStripMenuItem.Name = "hesaplamaToolStripMenuItem";
            this.hesaplamaToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.hesaplamaToolStripMenuItem.Text = "Hesaplama";
            // 
            // harcamaMiktariToolStripMenuItem
            // 
            this.harcamaMiktariToolStripMenuItem.Name = "harcamaMiktariToolStripMenuItem";
            this.harcamaMiktariToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.harcamaMiktariToolStripMenuItem.Text = "harcama miktari";
            this.harcamaMiktariToolStripMenuItem.Click += new System.EventHandler(this.harcamaMiktariToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veroGirisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboneBilgiGirisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayitAramaSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayitDegistirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harcamaMiktariToolStripMenuItem;
    }
}

