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
			SettingsManager.WriteSettings();
		}

		private void Oksett_Click(object sender, RoutedEventArgs e)
		{
			SettingsManager.WriteSettings();
			this.Hide();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
        }
    }
}
