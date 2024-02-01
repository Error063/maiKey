using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace maiKey
{
    public partial class extraKey : Form
    {
        public extraKey()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(int bVk, byte bScan, uint dwFlags, uint dwExtraInfo);


        private void testBtn_F1_Click(object sender, EventArgs e)
        {
            Utils.Keyboard.pressKey(Keys.F1);
        }

        private void serviceBtn_F2_Click(object sender, EventArgs e)
        {
            Utils.Keyboard.pressKey(Keys.F2);

        }

        private void virtualReaderBtn_Click(object sender, EventArgs e)
        {
            Utils.Keyboard.longPressKey(Keys.Enter);
        }

        private void testKey_1_Click(object sender, EventArgs e)
        {
            Utils.Keyboard.pressKey(49);
        }

        private void serviceBtn_2_Click(object sender, EventArgs e)
        {
            Utils.Keyboard.pressKey(50);
        }
    }
}