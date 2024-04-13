using NyamNyam_SochnevApp.DB;
using NyamNyam_SochnevApp.MyPages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace NyamNyam_SochnevApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ventilatorFrame.Navigate(new ImagPage());
        }

        private void RenatLink1_Click(object sender, RoutedEventArgs e)
        {
            ventilatorFrame.Navigate(new ImagPage());
        }

        private void RenatLink2_Click(object sender, RoutedEventArgs e)
        {
            ventilatorFrame.Navigate(new NeponyatnoPage());
        }

        private void RenatLink3_Click(object sender, RoutedEventArgs e)
        {
            ventilatorFrame.Navigate(new LPage());
        }
    }
}
