namespace patates
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
            pb = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // pb
            // 
            pb.Location = new Point(442, 145);
            pb.Name = "pb";
            pb.Size = new Size(270, 181);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.TabIndex = 0;
            pb.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(130, 145);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 19);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "dog";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(130, 198);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "cat";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(130, 242);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 19);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "duck";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(130, 290);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 19);
            radioButton4.TabIndex = 4;
            radioButton4.Text = "monkey";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}