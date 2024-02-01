using System;
using System.Windows.Forms;

namespace maiKey
{
    public partial class Controller : Form
    {
        private int _performKey;
        public Controller(int performKey)
        {
            InitializeComponent();
            this._performKey = performKey;
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
