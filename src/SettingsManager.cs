using System.IO;
using System.Text.Json;

namespace Elternportal
{
	class SettingsManager
	{	
		public static void UpdateSettingsGui()
		{
			Programm.settingswin.usrname.Text = Properties.Settings.Default.username;
			Programm.settingswin.passw.Password = Properties.Settings.Default.password;
			Programm.settingswin.theme.Text = Properties.Settings.Default.theme;

		}

		public static void UpdateSettings()
		{
			Properties.Settings.Default.Reload();
			UpdateSettingsGui();
		}

		public static void WriteSettings()
		{
			Properties.Settings.Default.username = Programm.settingswin.usrname.Text;
			Properties.Settings.Default.password = Programm.settingswin.passw.Password;
			Properties.Settings.Default.theme = Programm.settingswin.theme.Text;
			Properties.Settings.Default.Save();
		}
	}
}
