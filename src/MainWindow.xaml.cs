using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Elternportal
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public MainWindow()
		{
			InitializeComponent();
			Programm.Main();

			Brush black = new(V);
			Brush white = new();


			if (Properties.Settings.Default.darkmode)
			{

				App.Current.RequestedTheme == ApplicationTheme.Light;
			}
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