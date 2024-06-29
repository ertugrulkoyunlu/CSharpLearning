using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FileManager
{
    public partial class Form1 : Form
    {
currentLocation = filePath;
            string[] fileslist = Directory.GetDirectories(filePath).Concat(Directory.GetFiles(filePath)).ToArray();
        public Form1()
        {
            InitializeComponent();
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
        public string currentLocation = "C\\Users\\Lenovo";

        private void DisplayFiles(string filePath)
        {
            
            for (int i = 0; i < filesList.Length - 1; i++)
            {
                bool isHidden = ((File.GetAttributes(filesList[i]) & FileAttributes.Hidden) == FileAttributes.Hidden);

                if (!isHidden)
                {
                    // Get the name of the file from the path
                    var startOfName = filesList[i].LastIndexOf("\\");
                    var fileName = filesList[i].Substring(startOfName + 1, filesList[i].Length - (startOfName + 1));

                    // Display the file or folder as a button
                    Button newButton = new Button();
                    newButton.Text = fileName;
                    newButton.Name = filesList[i];
                    newButton.Location = new Point(70, 70);
                    newButton.Size = new Size(800, 100);
                    newButton.TextAlign = ContentAlignment.MiddleLeft;
                    newButton.Padding = new Padding(24, 0, 0, 0);
                    panel_FilesList.Controls.Add(newButton);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
