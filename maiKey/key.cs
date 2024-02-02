using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace maiKey
{
    public partial class Controller : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_NOACTIVATE = 0x08000000;

        private int _performKey;
        public Controller(int performKey)
        {
            InitializeComponent();
            this._performKey = performKey;
            SetWindowLong(this.Handle, GWL_EXSTYLE, GetWindowLong(this.Handle, GWL_EXSTYLE) | WS_EX_NOACTIVATE);
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.Keyboard.pressKey(_performKey);
        }
    }
}
