using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Fox.WinForms.LightDarkForm
{
    public class LightDarkForm : Form
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            UpdateLightDarkMode();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SETTINGCHANGE = 0x001A;

            if (m.Msg == WM_SETTINGCHANGE)
                UpdateLightDarkMode();

            base.WndProc(ref m);
        }


        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        private void UpdateLightDarkMode()
        {
            var regTheme = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1);
            var darkModeEnabled = regTheme is int regThemeInt && regThemeInt == 0;

            if (darkModeEnabled)
                SetLightDarkMode(1);
            else
                SetLightDarkMode(0);
        }

        private void SetLightDarkMode(int mode)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { mode }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { mode }, 4);
        }
    }
}
