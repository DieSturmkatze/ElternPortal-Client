using System.Windows;

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
		}

		private void settings_Click(object sender, RoutedEventArgs e)
		{
			SettingsManager.UpdateSettingsGui();
			Programm.settingswin.Show();
		}

		private void Main_Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			SettingsManager.WriteSettings();
			Programm.settingswin.Close();
			System.Environment.Exit(1);
		}
	}
}