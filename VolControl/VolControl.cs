using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32; //写入注册表时要用到
namespace VolControl
{
    public partial class VolControl : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        const uint WM_APPCOMMAND = 0x319;
        const uint APPCOMMAND_VOLUME_UP = 0x0a;
        const uint APPCOMMAND_VOLUME_DOWN = 0x09;
        const uint APPCOMMAND_VOLUME_MUTE = 0x08;
        KeyboardHook k_hook;
        bool RealClose = false;
        int IncreaseKey;
        int MuteKey;
        int DecreaseKey;
        public VolControl()
        {
            InitializeComponent();
            MaximizeBox = false;
            k_hook = new KeyboardHook();
            k_hook.KeyDownEvent += new KeyEventHandler(Hook_KeyDown); 
            k_hook.Start();
        }
        private void Hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == (Keys)IncreaseKey)
            {
                SendMessage(this.Handle, WM_APPCOMMAND, 0x30292, APPCOMMAND_VOLUME_UP * 0x10000);
            }
            else if (ModifierKeys == Keys.Control && e.KeyCode == (Keys)DecreaseKey)
            {
                SendMessage(this.Handle, WM_APPCOMMAND, 0x30292, APPCOMMAND_VOLUME_DOWN * 0x10000);
            }
            else if (ModifierKeys == Keys.Control && e.KeyCode == (Keys)MuteKey)
            {
                SendMessage(this.Handle, WM_APPCOMMAND, 0x200eb0, APPCOMMAND_VOLUME_MUTE * 0x10000);
            }
        }
        private void VolControl_Load(object sender, EventArgs e)
        {
            IncreaseKey = int.Parse(ConfigurationManager.AppSettings["Increase"].ToString());
            MuteKey = int.Parse(ConfigurationManager.AppSettings["Mute"].ToString());
            DecreaseKey = int.Parse(ConfigurationManager.AppSettings["Decrease"].ToString());
            TB_Increase.Text = ((Keys)IncreaseKey).ToString();
            TB_Mute.Text = ((Keys)MuteKey).ToString();
            TB_Decrease.Text = ((Keys)DecreaseKey).ToString();
        }
        private void VolControl_Shown(object sender, EventArgs e)
        {
            BT_Save.Focus();
        }
        private void VolControl_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void NotifyIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = MousePosition;
                NotifyIconMenuStrip.Show(p);
            }
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealClose = true;
            Close();
        }
        private void VolControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            if (e.CloseReason == CloseReason.UserClosing && !RealClose)
            {
                e.Cancel = true;
            }
        }
        private void TB_Increase_KeyDown(object sender, KeyEventArgs e)
        {
            IncreaseKey = e.KeyValue;
            TB_Increase.Text = e.KeyData.ToString();
        }
        private void TB_Mute_KeyDown(object sender, KeyEventArgs e)
        {
            MuteKey = e.KeyValue;
            TB_Mute.Text = e.KeyData.ToString();
        }
        private void TB_Decrease_KeyDown(object sender, KeyEventArgs e)
        {
            DecreaseKey = e.KeyValue;
            TB_Decrease.Text = e.KeyData.ToString();
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            app.Settings["Increase"].Value = IncreaseKey.ToString();
            app.Settings["Mute"].Value = MuteKey.ToString();
            app.Settings["Decrease"].Value = DecreaseKey.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}