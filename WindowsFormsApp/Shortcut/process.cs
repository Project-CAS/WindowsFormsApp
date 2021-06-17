using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Shortcut
{
    class Focus
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_SHOWMAXIMIZED = 3;

        public string getFocusProcessName()
        {
            IntPtr handle = IntPtr.Zero;
            uint pid = 0;
            Process ps = null;

            handle = GetForegroundWindow();
            GetWindowThreadProcessId(handle, out pid);
            ps = Process.GetProcessById((int)pid);
            return ps.ProcessName;
        }
    }
}
