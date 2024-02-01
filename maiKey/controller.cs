using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace maiKey
{
    public partial class Key : Form
    {
        private Utils.AppConfig appConfig = new Utils.AppConfig();
        private List<Form> _keyForms = new List<Form>();
        //private readonly int[] _keys = new int[] { 'Q','W','A','E','Z','D','X','C','3' };
        private bool _isClosed = true;
        public Key()
        {
            InitializeComponent();
            ShowKeySetTips();
            radiusBar.Value = appConfig.config.btnRadius;
            radiusNum.Value = Convert.ToDecimal(appConfig.config.btnRadius);
            angleBar.Value = Convert.ToInt32(appConfig.config.btnAngle * 10);
            angleNum.Value = Convert.ToDecimal(appConfig.config.btnAngle);
        }

        private void ShowKeySetTips()
        {
            string template = "当前键位布局：\r\n操作键：#controlKeyPairs#\r\n（从上到下，从左到右）\r\n选择键： #selectKey#";
            StringBuilder keySb = new StringBuilder();
            for (int i = 0; i < appConfig.config.keyset.Count - 1; i++)
            {
                if(i%2==0)
                {
                    keySb.Append(' ');
                }
                keySb.Append((char)appConfig.config.keyset[i]);
            }
            keySetTipsLab.Text = template
                .Replace("#selectKey#", ((char)appConfig.config.keyset[appConfig.config.keyset.Count - 1]).ToString())
                .Replace("#controlKeyPairs#", keySb.ToString());
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (_isClosed)
            {
                if (appConfig.config.keyset.Count != 9)
                {
                    MessageBox.Show(@"自定义键位长度错误！");

                }
                else
                {
                    _isClosed = false;
                    foreach(int c in appConfig.config.keyset)
                    {
                        Form form = new Controller(c);
                        _keyForms.Add(form);
                    }
                    _keyForms[_keyForms.Count - 1].Show();
                    _keyForms[_keyForms.Count - 1].Text = @"选择键";
                    _keyForms[_keyForms.Count - 1].FormBorderStyle = FormBorderStyle.FixedSingle;
                    _keyForms[_keyForms.Count - 1].Opacity = 1.0;
                    MessageBox.Show(@"将基于选择键按钮窗口的位置进行排布");
                    lockLocation.Checked = false;
                }
            }
            else
            {
                MessageBox.Show(@"当前已存在虚拟按键窗口！");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (!_isClosed && !lockLocation.Checked)
            {
                foreach(Form form in _keyForms)
                {
                    form.Close();
                }
                _isClosed = true;
                _keyForms.Clear();
                lockLocation.Checked = false;
            }
            else if (_isClosed)
            {
                MessageBox.Show(@"当前未打开任何虚拟按键窗口！");
            }
            else if (lockLocation.Checked)
            {
                MessageBox.Show(@"当前布局已锁定！");
            }
        }

        private void radiusBar_Scroll(object sender, EventArgs e)
        {
            radiusNum.Value = radiusBar.Value;
            lockLocation.Checked = false;
        }

        private void radiusNum_ValueChanged(object sender, EventArgs e)
        {
            radiusBar.Value = Decimal.ToInt32(radiusNum.Value);
            lockLocation.Checked = false;
        }

        private void autoReplaceBtn_Click(object sender, EventArgs e)
        {
            if (!_isClosed && !lockLocation.Checked)
            {
                double thisCenterX = _keyForms[_keyForms.Count - 1].Location.X;
                double thisCenterY = _keyForms[_keyForms.Count - 1].Location.Y;
                double radius = Decimal.ToDouble(radiusNum.Value);
                double angle = Decimal.ToDouble(angleNum.Value);
                double increaseA = Math.Abs(radius * Math.Sin((angle * (Math.PI)) / 180));
                double increaseB = Math.Abs(radius * Math.Cos((angle * (Math.PI)) / 180));

                for (int i = 0; i < _keyForms.Count - 1; i++)
                {
                    Form form = _keyForms[i];
                    double newX = thisCenterX, newY = thisCenterY;
                    switch (i)
                    {
                        case 0:
                            newX = thisCenterX - increaseA;
                            newY = thisCenterY - increaseB;
                            break;
                        case 1:
                            newX = thisCenterX + increaseA;
                            newY = thisCenterY - increaseB;
                            break;
                        case 2:
                            newX = thisCenterX - increaseB;
                            newY = thisCenterY - increaseA;
                            break;
                        case 3:
                            newX = thisCenterX + increaseB;
                            newY = thisCenterY - increaseA;
                            break;
                        case 4:
                            newX = thisCenterX - increaseB;
                            newY = thisCenterY + increaseA;
                            break;
                        case 5:
                            newX = thisCenterX + increaseB;
                            newY = thisCenterY + increaseA;
                            break;
                        case 6:
                            newX = thisCenterX - increaseA;
                            newY = thisCenterY + increaseB;
                            break;
                        case 7:
                            newX = thisCenterX + increaseA;
                            newY = thisCenterY + increaseB;
                            break;
                    }
                    form.Show();
                    form.Location = new Point(Convert.ToInt32(newX), Convert.ToInt32(newY));
                }
                lockLocation.Checked = true;
            }
            else if (_isClosed)
            {
                MessageBox.Show(@"当前未打开任何虚拟按键窗口！");
            }
            else if (lockLocation.Checked)
            {
                MessageBox.Show(@"当前布局已锁定！");
            }
            new Thread(() =>
            {
                appConfig.config.btnAngle = Convert.ToDouble(angleNum.Value);
                appConfig.config.btnRadius = Convert.ToInt32(radiusNum.Value);
                appConfig.save();
            }).Start();

        }

        private void angleBar_Scroll(object sender, EventArgs e)
        {
            angleNum.Value = Convert.ToDecimal(angleBar.Value / 10.0);
            lockLocation.Checked = false;
        }

        private void angleNum_ValueChanged(object sender, EventArgs e)
        {
            angleBar.Value = Decimal.ToInt32(angleNum.Value) * 10;
            lockLocation.Checked = false;
        }

        private void showExtraKey_Click(object sender, EventArgs e)
        {
            new extraKey().Show();
        }

        private void changeKeySetBtn_Click(object sender, EventArgs e)
        {
            new changeKeyset(appConfig).Show();
        }

        private void keySetTipsLab_Click(object sender, EventArgs e)
        {
            ShowKeySetTips();
        }
    }
}
