using System.Windows;
using ControlzEx.Theming;

namespace Elternportal
{
	/// <summary>
	/// Interaction logic for Settings.xaml
	/// </summary>
	public partial class Settings
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
		private void applyt_Click(object sender, RoutedEventArgs e)
		{
			ThemeManager.Current.ChangeTheme(Programm.settingswin, theme.Text);
			ThemeManager.Current.ChangeTheme(Application.Current.MainWindow, theme.Text);
		}
	}
}
