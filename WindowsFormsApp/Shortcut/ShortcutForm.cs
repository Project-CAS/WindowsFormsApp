using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shortcut
{
    public partial class ShortcutForm : Form
    {
        Focus focus;

        public ShortcutForm()
        {
            InitializeComponent();
            focus = new Focus();
        }

        private void ShortcutForm_Load(object sender, EventArgs e)
        {
            processNameLabel.Text = focus.getFocusProcessName();
        }

        private void ProcessCheck(string processName)
        {
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

        private void ShortcutForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void ShortcutForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string processName = focus.getFocusProcessName();
            // Left Windows Key Press
            if (e.KeyChar == 91)
            {
                ProcessCheck(processName);
            }
        }
    }
}
