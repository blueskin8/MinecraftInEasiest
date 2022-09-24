using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
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
using System.Diagnostics;

namespace MinecraftInEasiest.src.Client.src.mods
{
    /// <summary>
    /// Logique d'interaction pour InstallMod.xaml
    /// </summary>
    public partial class InstallMod : Window
    {
        public InstallMod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Minecraft mod (*.jar)|*.jar";
            openFileDialog.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft\mods\";

            if (openFileDialog.ShowDialog() == true)
            {
                File.Delete(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft\mods\" + System.IO.Path.GetFileName(openFileDialog.FileName.ToString()));
            }

            if (System.IO.Path.GetFileName(openFileDialog.FileName.ToString()) != "")
            {
                MessageBox.Show(System.IO.Path.GetFileName(openFileDialog.FileName.ToString()) + " supprimé de vottre client depuis : " + openFileDialog.FileName);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Minecraft mod (*.jar)|*.jar";
            openFileDialog.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Downloads";

            if (openFileDialog.ShowDialog() == true)
            {
                File.Copy(openFileDialog.FileName.ToString(), @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft\mods\" + System.IO.Path.GetFileName(openFileDialog.FileName.ToString()));
            }



            if (System.IO.Path.GetFileName(openFileDialog.FileName.ToString()) != "")
            {
                MessageBox.Show(System.IO.Path.GetFileName(openFileDialog.FileName.ToString()) + " installé sur votre client dans : " + @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft\mods\");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer", "https://www.curseforge.com/minecraft/mc-mods");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainClient main = new();
            main.Show();
            this.Close();
        }
    }
}
