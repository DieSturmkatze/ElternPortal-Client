using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using ControlzEx.Theming;
using MahApps.Metro.Controls;

namespace Elternportal
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{

		public MainWindow()
		{
			InitializeComponent();
			Programm.Main();

			ThemeManager.Current.ChangeTheme(Programm.settingswin, Properties.Settings.Default.theme);
			ThemeManager.Current.ChangeTheme(Application.Current.MainWindow, Properties.Settings.Default.theme);
		}

		private void settings_Click(object sender, RoutedEventArgs e)
		{
			SettingsManager.UpdateSettingsGui();
			Programm.settingswin.Hide();
			Programm.settingswin.Show();
		}

		private void Main_Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//SettingsManager.WriteSettings();
			Programm.settingswin.Close();
			System.Environment.Exit(1);
		}

	}
}