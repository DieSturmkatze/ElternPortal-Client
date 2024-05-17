using System.IO;
using System.Text.Json;

namespace Elternportal
{
	class SettingsManager
	{	
		private static string localusername = Environment.UserName;
		public static string AppPath = "C:\\Users\\" + localusername + "\\AppData\\Local\\ElternportalClient";
		private static string SettingPath = AppPath + "\\settings.json";

		public static SettingList SettingList1 = new SettingList();
		private static string json ="";

		public static void SaveSettings()
		{

			//Programm.settingswin.test.Content = AppPath;
			SettingList1.username = Programm.settingswin.usrname.Text;
			SettingList1.password = Programm.settingswin.passw.Password;
			json = JsonSerializer.Serialize(SettingList1);
		}

		public static void UpdateSettingsGui()
		{
			Programm.settingswin.usrname.Text = SettingList1.username;
			Programm.settingswin.test.Content = SettingList1.username;
		}

		public static void UpdateSettings(string ujson)
		{
			SettingList? SettingList1 =
				JsonSerializer.Deserialize<SettingList>(ujson);
		}

		public static void WriteSettings()
		{
			if (!Directory.Exists(AppPath)) { Directory.CreateDirectory(AppPath); }

			SaveSettings();

			if (SettingList1.username == "") { return; }
			File.WriteAllText(SettingPath, json);
		}
		public static void LoadSettings()
		{   
			if (!File.Exists(SettingPath)) {return;}

			string jsonr = File.ReadAllText(SettingPath);
			
			Programm.settingswin.test.Content = jsonr;
			UpdateSettings(jsonr);
		}
	}

	public class SettingList
	{
		public string username { get; set; }
		public string password { get; set; }

		public void update(string json)
		{

		}
	}

}
