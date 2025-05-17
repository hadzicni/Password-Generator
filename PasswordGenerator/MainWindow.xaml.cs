using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Text.RegularExpressions;

namespace PasswordGeneratorPro
{
    public partial class MainWindow : Window
    {
        private readonly Random random = new();

        public MainWindow()
        {
            InitializeComponent();
            LengthSlider.ValueChanged += (s, e) => LengthLabel.Text = $"Länge: {LengthSlider.Value}";
            SelectAllCheckbox.Checked += (s, e) => SetAllCheckboxes(true);
            SelectAllCheckbox.Unchecked += (s, e) => SetAllCheckboxes(false);
            Loaded += (_, _) => GeneratePassword(); // Beim Start direkt ein Passwort generieren
        }

        private void SetAllCheckboxes(bool value)
        {
            UseUpper.IsChecked = value;
            UseLower.IsChecked = value;
            UseDigits.IsChecked = value;
            UseSymbols.IsChecked = value;
        }

        private void GeneratePassword_Click(object sender, RoutedEventArgs e)
        {
            GeneratePassword();
        }

        private void GeneratePassword()
        {
            int length = (int)LengthSlider.Value;

            var charPool = new StringBuilder();
            if (UseUpper.IsChecked == true) charPool.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            if (UseLower.IsChecked == true) charPool.Append("abcdefghijklmnopqrstuvwxyz");
            if (UseDigits.IsChecked == true) charPool.Append("0123456789");
            if (UseSymbols.IsChecked == true) charPool.Append("!@#$%^&*()_-+=<>?");

            if (charPool.Length == 0)
            {
                MessageBox.Show("Bitte mindestens eine Zeichengruppe auswählen.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var password = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(charPool.Length);
                password.Append(charPool[index]);
            }

            PasswordBox.Text = password.ToString();
            EvaluateStrength(password.ToString());
        }

        private void CopyToClipboard_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                Clipboard.SetText(PasswordBox.Text);
                MessageBox.Show("Passwort wurde kopiert.", "Erfolg", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void EvaluateStrength(string password)
        {
            int score = 0;

            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;
            if (Regex.IsMatch(password, "[A-Z]")) score++;
            if (Regex.IsMatch(password, "[a-z]")) score++;
            if (Regex.IsMatch(password, "[0-9]")) score++;
            if (Regex.IsMatch(password, "[^a-zA-Z0-9]")) score++;

            score = Math.Min(score, 5);
            StrengthBar.Value = score;

            string level;
            if (score <= 2) level = "Schwach";
            else if (score == 3) level = "Mittel";
            else level = "Stark";

            StrengthLabel.Text = $"Sicherheitsbewertung: {level}";
            StrengthBar.Foreground = level switch
            {
                "Schwach" => new SolidColorBrush(Colors.OrangeRed),
                "Mittel" => new SolidColorBrush(Colors.Goldenrod),
                "Stark" => new SolidColorBrush(Colors.LimeGreen),
                _ => new SolidColorBrush(Colors.Gray)
            };
        }

        private void OpenInfo_Click(object sender, RoutedEventArgs e)
        {
            var info = new InfoWindow
            {
                Owner = this
            };
            info.ShowDialog();
        }

    }
}
