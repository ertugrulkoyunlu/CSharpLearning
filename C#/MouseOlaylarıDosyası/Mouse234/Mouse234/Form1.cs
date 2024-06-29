using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse234
{
    public partial class Form1 : Form
    {
      [DllImport("User32.Dll")]
    public static extern long SetCursorPos(int x, int y);

    [DllImport("User32.Dll")]
    public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;

        public POINT(int X, int Y)
        {
            x = X;
            y = Y;
           
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     Microsoft.Win32.POINT p = new Microsft.Win32.POINT(xPos, yPos);

                
    this.Cursor = new Cursor(Cursor.Current.Handle);
   Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
   Cursor.Clip = new Rectangle(this.Location, this.Size);

        }
    }
}
}
