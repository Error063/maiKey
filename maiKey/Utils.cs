using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virtKey
{
    internal class Utils
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
    }
}
