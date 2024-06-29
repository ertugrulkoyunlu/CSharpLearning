namespace Mouse_click
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
    static extern bool SetCursorPos(int x, int y);
 
    [DllImport("user32.dll")]
    public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
 
    public const int MOUSEEVENTF_LEFTDOWN = 0x02;
    public const int MOUSEEVENTF_LEFTUP = 0x04;
    public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
    public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetCursorPos(xpos, ypos);
    //Sol T?klad?
    mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
    //Sol B?rakt?
    mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
}
        }
    }
}