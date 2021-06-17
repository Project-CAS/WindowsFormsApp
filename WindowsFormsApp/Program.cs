using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        /// 

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_SHOWMAXIMIZED = 3;

        [STAThread]
        static void Main()
        {
            IntPtr handle = IntPtr.Zero;
            uint pid = 0;
            Process ps = null;

            for (; ; )
            {
                handle = GetForegroundWindow();        // 활성화 윈도우
                GetWindowThreadProcessId(handle, out pid); // 핸들로 프로세스아이디 얻어옴
                ps = Process.GetProcessById((int)pid); // 프로세스아이디로 프로세스 검색

                Console.WriteLine(ps.ProcessName);



                Thread.Sleep(500);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Shortcut());
            }
        }
    }
}
