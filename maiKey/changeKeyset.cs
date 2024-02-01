using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace maiKey
{
    public partial class changeKeyset : Form
    {
        private List<NumericUpDown> keyset = new List<NumericUpDown>();
        private Utils.AppConfig _appConfig;
        public changeKeyset(Utils.AppConfig appConfig)
        {
            InitializeComponent();
            _appConfig = appConfig;
            keyset.Add(key1);
            keyset.Add(key2);
            keyset.Add(key3);
            keyset.Add(key4);
            keyset.Add(key5);
            keyset.Add(key6);
            keyset.Add(key7);
            keyset.Add(key8);
            keyset.Add(selectKey);

            for (int i = 0; i < _appConfig.config.keyset.Count; i++)
            {
                keyset[i].Value = Convert.ToDecimal(_appConfig.config.keyset[i]);
            }
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.runoob.com/note/29592");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < _appConfig.config.keyset.Count; i++)
            {
                _appConfig.config.keyset[i] = Convert.ToInt32(keyset[i].Value);
            }
            _appConfig.save();
            MessageBox.Show("保存成功！");
        }

        private void keyValueChanged(object sender, EventArgs e)
        {
            NumericUpDown key = (NumericUpDown) sender;
            Keys keyCode = (Keys) Convert.ToInt32(key.Value);
            Control[] foundControls = this.Controls.Find($"{key.Name}_label", true);
            if (foundControls != null && foundControls.Length > 0)
            {
                Label label = (Label)foundControls[0];
                label.Text = $"{label.Text.Split(':')[0]}: {keyCode.ToString()}";
            }
        }
    }
}
