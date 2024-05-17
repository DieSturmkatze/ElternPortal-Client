using System.Windows;

namespace Elternportal
{
	/// <summary>
	/// Interaction logic for Settings.xaml
	/// </summary>
	public partial class Settings : Window
	{
		public Settings()
		{
			InitializeComponent();
		}

		private void closesett_Click(object sender, RoutedEventArgs e)
		{
			this.Hide();
		}

		private void savesett_Click(object sender, RoutedEventArgs e)
		{
			SettingsManager.SaveSettings();
		}

		private void Oksett_Click(object sender, RoutedEventArgs e)
		{
			SettingsManager.SaveSettings();
			this.Hide();
		}
	}
}
