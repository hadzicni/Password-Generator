using System.Diagnostics;
using System.Windows;

namespace PasswordGeneratorPro
{
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GitHubButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/hadzicni/Password-Generator",
                UseShellExecute = true
            });
        }
    }
}
