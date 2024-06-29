namespace Database21
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.verigirisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonebilgigirisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayitaramasilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayitdegistirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verigirisiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // verigirisiToolStripMenuItem
            // 
            this.verigirisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonebilgigirisiToolStripMenuItem,
            this.kayitaramasilmeToolStripMenuItem,
            this.kayitdegistirmeToolStripMenuItem});
            this.verigirisiToolStripMenuItem.Name = "verigirisiToolStripMenuItem";
            this.verigirisiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.verigirisiToolStripMenuItem.Text = "verigirisi";
            // 
            // abonebilgigirisiToolStripMenuItem
            // 
            this.abonebilgigirisiToolStripMenuItem.Name = "abonebilgigirisiToolStripMenuItem";
            this.abonebilgigirisiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abonebilgigirisiToolStripMenuItem.Text = "Abonebilgigirisi";
            this.abonebilgigirisiToolStripMenuItem.Click += new System.EventHandler(this.abonebilgigirisiToolStripMenuItem_Click);
            // 
            // kayitaramasilmeToolStripMenuItem
            // 
            this.kayitaramasilmeToolStripMenuItem.Name = "kayitaramasilmeToolStripMenuItem";
            this.kayitaramasilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayitaramasilmeToolStripMenuItem.Text = "kayitaramasilme";
            this.kayitaramasilmeToolStripMenuItem.Click += new System.EventHandler(this.kayitaramasilmeToolStripMenuItem_Click);
            // 
            // kayitdegistirmeToolStripMenuItem
            // 
            this.kayitdegistirmeToolStripMenuItem.Name = "kayitdegistirmeToolStripMenuItem";
            this.kayitdegistirmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayitdegistirmeToolStripMenuItem.Text = "kayitdegistirme";
            this.kayitdegistirmeToolStripMenuItem.Click += new System.EventHandler(this.kayitdegistirmeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem verigirisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonebilgigirisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayitaramasilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayitdegistirmeToolStripMenuItem;
    }
}

