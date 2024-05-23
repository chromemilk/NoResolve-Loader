using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NoResolve_Loader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VACBypass_Click(object sender, RoutedEventArgs e)
        {
            // Code to bypass VAC
            // Try to find NoResolveVACBypass.exe in the same directory as the loader

            // If the file is not found, display an error message
            if (System.IO.File.Exists("NoResolveVACBypass.exe"))
            {
                // Start the VAC bypass program
                System.Diagnostics.Process.Start("NoResolveVACBypass.exe");
            }
            else
            {
                MessageBox.Show("NoResolveVACBypass.exe not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadCheat_Click(object sender, RoutedEventArgs e)
        {
            // Attempt to find and execute the cheat called NoResolveCS2.exe for the external
            // Find the program in the same directory as the loader
            // If the program is not found, display an error message
            if (System.IO.File.Exists("NoResolveCS2.exe"))
            {
                System.Diagnostics.Process.Start("NoResolveCS2.exe");
            }
            else
            {
                MessageBox.Show("NoResolveCS2.exe not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void InjectCheat_Click(object sender, RoutedEventArgs e)
        {
            // Code to inject the cheat
            // Try to find NoResolveOfficial.dll in the same directory as the loader
            // If the file is not found, display an error message
            if (System.IO.File.Exists("NoResolveOfficial.dll"))
            {
                // Use reflective dll injection to inject the cheat into "csgo.exe"
                // If the injection is successful, display a message box



                MessageBox.Show("Cheat injected successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("NoResolveOfficial.dll not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}