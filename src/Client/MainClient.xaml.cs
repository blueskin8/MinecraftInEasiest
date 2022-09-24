using System;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MinecraftInEasiest.src.Client
{
    /// <summary>
    /// Logique d'interaction pour MainClient.xaml
    /// </summary>
    public partial class MainClient : Window
    {
        public MainClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            src.mods.InstallMod installMod = new();
            installMod.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            src.datapacks.Datapacks datapacks = new();
            datapacks.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new();
            main.Show();
            this.Close();
        }
    }
}
