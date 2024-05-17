using System.IO;
using System.Text.Json;
using Newtonsoft.Json.Converters;

namespace Elternportal
{
	class SettingsManager
	{	
		private static string localusername = Environment.UserName;
		public static string AppPath = "C:\\Users\\" + localusername + "\\AppData\\Local\\ElternportalClient";
		private static string SettingPath = AppPath + "\\settings.json";

		public static SettingList SettingList = new SettingList();
		private static string json ="";

		public static void SaveSettings()
		{

			//Programm.settingswin.test.Content = AppPath;
			SettingList.username = Programm.settingswin.usrname.Text;
			SettingList.password = Programm.settingswin.passw.Password;
			json = JsonSerializer.Serialize(SettingList);
			

		}

		public static void UpdateSettingsGui()
		{
			Programm.settingswin.usrname.Text = SettingList.username;
			Programm.settingswin.passw.Password = SettingList.password;
		}

		public static void UpdateSettings(string ujson)
		{
			List<SettingList> items = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SettingList>>(json);
		}

		public static void WriteSettings()
		{
			if (!Directory.Exists(AppPath)) {Directory.CreateDirectory(AppPath);}
			
			SaveSettings();

			File.WriteAllText(SettingPath, json);
		}
		public static void LoadSettings()
		{   
			if (!File.Exists(SettingPath)) {return;}

			json = File.ReadAllText(SettingPath);
			
			Programm.settingswin.test.Content = json;
			UpdateSettings(json);
			UpdateSettingsGui();
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
