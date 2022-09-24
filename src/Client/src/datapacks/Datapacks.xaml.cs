using System;
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
using System.Windows.Shapes;

namespace MinecraftInEasiest.src.Client.src.datapacks
{
    /// <summary>
    /// Logique d'interaction pour Datapacks.xaml
    /// </summary>
    public partial class Datapacks : Window
    {
        public Datapacks()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainClient mainClient = new();
            mainClient.Show();
            this.Close();
        }
    }
}
