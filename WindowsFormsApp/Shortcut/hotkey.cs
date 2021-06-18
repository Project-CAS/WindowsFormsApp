using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Shortcut
{
    class Hotkey
    {
        [DllImport("user32.dll")]

        public static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);
    }
}
