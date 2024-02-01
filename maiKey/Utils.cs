using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace maiKey
{
    public class Utils
    {
        public static class Keyboard
        {

            [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
            private static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
            [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
            private static extern void keybd_event(int bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

            public static void pressKey(int bVk)
            {
                keybd_event(bVk,0,0,0);
                keybd_event(bVk,0,2,0);
            }

            public static void longPressKey(int bVk)
            {
                new Thread(() => {
                    keybd_event(bVk, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(bVk, 0, 2, 0);
                }).Start();
            }

            public static void pressKey(Keys bVk)
            {
                keybd_event(bVk, 0, 0, 0);
                keybd_event(bVk, 0, 2, 0);
            }

            public static void longPressKey(Keys bVk)
            {
                new Thread(() => {
                    keybd_event(bVk, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(bVk, 0, 2, 0);
                }).Start();
            }
        }

        public class AppConfig
        {
            private string fileName = "./maikey-config.json";
            public class configClass
            {
                private List<int> _keyset;
                private int _btnRadius;
                private double _btnAngle;
                public List<int> keyset
                {
                    get
                    {
                        return _keyset;
                    }
                    set
                    {
                        if(value.Count != 9)
                        {
                            throw new Exception("List length not equal 9!");
                        }
                        else
                        {
                            _keyset = value;
                        }
                    }
                }
                public int btnRadius 
                {
                    get
                    {
                        return _btnRadius;
                    }
                    set
                    {
                        if(value < 0 || 1000 < value)
                        {
                            throw new Exception("Value out of range!");
                        }
                        else
                        {
                            _btnRadius = value;
                        }
                    } 
                }
                public double btnAngle
                {
                    get
                    {
                        return _btnAngle;
                    }
                    set
                    {
                        if (value < 15.0 || 35.0 < value)
                        {
                            throw new Exception("Value out of range!");
                        }
                        else
                        {
                            _btnAngle = value;
                        }
                    }
                }
            }
            private configClass templateConfig = new configClass() 
            {
                keyset = new List<int>() { 'Q', 'W', 'A', 'E', 'Z', 'D', 'X', 'C', '3' },
                btnAngle = 20.0,
                btnRadius = 300,
            };
            public configClass config;
            public AppConfig()
            {
                try
                {
                    string file = File.ReadAllText(fileName);
                    //Console.WriteLine(file);
                    this.config = JsonSerializer.Deserialize<configClass>(file);

                }catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    File.WriteAllText(fileName, JsonSerializer.Serialize(templateConfig));
                    this.config = JsonSerializer.Deserialize<configClass>(File.ReadAllText(fileName));
                }
            }
            public void save()
            {
                File.WriteAllText(fileName, JsonSerializer.Serialize(config));
            }
        }
    }
}
