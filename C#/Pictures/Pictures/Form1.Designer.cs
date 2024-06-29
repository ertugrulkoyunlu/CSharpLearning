namespace Pictures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pb = new PictureBox();
            monkey = new RadioButton();
            duck = new RadioButton();
            cat = new RadioButton();
            dog = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pb);
            groupBox1.Controls.Add(monkey);
            groupBox1.Controls.Add(duck);
            groupBox1.Controls.Add(cat);
            groupBox1.Controls.Add(dog);
            groupBox1.Location = new Point(67, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(929, 535);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pb
            // 
            pb.Image = Properties.Resources.duck;
            pb.Location = new Point(529, 152);
            pb.Name = "pb";
            pb.Size = new Size(250, 250);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.TabIndex = 4;
            pb.TabStop = false;
            // 
            // monkey
            // 
            monkey.AutoSize = true;
            monkey.Location = new Point(165, 383);
            monkey.Name = "monkey";
            monkey.Size = new Size(68, 19);
            monkey.TabIndex = 3;
            monkey.TabStop = true;
            monkey.Text = "monkey";
            monkey.UseVisualStyleBackColor = true;
            // 
            // duck
            // 
            duck.AutoSize = true;
            duck.Location = new Point(165, 299);
            duck.Name = "duck";
            duck.Size = new Size(51, 19);
            duck.TabIndex = 2;
            duck.TabStop = true;
            duck.Text = "duck";
            duck.UseVisualStyleBackColor = true;
            // 
            // cat
            // 
            cat.AutoSize = true;
            cat.Location = new Point(165, 231);
            cat.Name = "cat";
            cat.Size = new Size(41, 19);
            cat.TabIndex = 1;
            cat.TabStop = true;
            cat.Text = "cat";
            cat.UseVisualStyleBackColor = true;
            cat.CheckedChanged += cat_CheckedChanged;
            // 
            // dog
            // 
            dog.AutoSize = true;
            dog.Location = new Point(165, 152);
            dog.Name = "dog";
            dog.Size = new Size(46, 19);
            dog.TabIndex = 0;
            dog.TabStop = true;
            dog.Text = "dog";
            dog.UseVisualStyleBackColor = true;
            dog.CheckedChanged += this.radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 604);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pb;
        private RadioButton monkey;
        private RadioButton duck;
        private RadioButton cat;
        private RadioButton dog;
    }
}