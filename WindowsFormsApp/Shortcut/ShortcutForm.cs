using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Shortcut
{
    public partial class ShortcutForm : Form
    {
        // 핫키 등록
        [DllImport("user32.dll")]
        public static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);
        // 핫키 제거
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);


        Focus focus;
        //Hotkey hotkey;

        public ShortcutForm()
        {
            InitializeComponent();
            focus = new Focus();
            //hotkey = new Hotkey();
        }

        private void ShortcutForm_Load(object sender, EventArgs e)
        {
            processNameLabel.Text = focus.getFocusProcessName();
            RegisterHotKey((int)this.Handle, 0, 0x0, (int)Keys.F1);
        }

        private void ProcessCheck(string processName)
        {
            processNameLabel.Text = "ProcessCheck";
            if (processName == "Notion")
            { 
                Form form = new Notion();
                form.ShowDialog();
            }
        }

        // key press check event

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        // 작업표시줄 아이콘화
        private void ShortcutForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == (int)0x312)
            {
                if (m.WParam == (IntPtr)0x0)
                {
                    MessageBox.Show("Press");
                }
            }
        }
    }
}
