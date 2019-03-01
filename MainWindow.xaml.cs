/*Noah Irving
 * February 26th 2019
 * Grade 11 Computer Parts Project
 */
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Navigation;

namespace _304555FirstProject
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

        private void btnCPU_Click(object sender, RoutedEventArgs e)
        {

            txtInfo.Text = "gears";
            InkWeb.NavigateUri = new Uri("www.cornhub.com");
            BitmapImage bi = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Square_-_black_simple.svg/220px-Square_-_black_simple.svg.png"));
            imageInfo.Source = bi;
        }

        private void btnStorage_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "yrstd";
            InkWeb.NavigateUri = new Uri("");
            BitmapImage bi = new BitmapImage(new Uri(""));
            imageInfo.Source = bi;
        }

        private void btnGraphicsCard_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "buzzlightyear";
            BitmapImage bi = new BitmapImage(new Uri(""));
            imageInfo.Source = bi;
        }

        private void btnMotherboard_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "ghjsghkfe";
            BitmapImage bi = new BitmapImage(new Uri(""));
            imageInfo.Source = bi;
        }

        private void btnBluerayburner_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "beers";
            BitmapImage bi = new BitmapImage(new Uri(""));
            imageInfo.Source = bi;
        }

        private void btnRAM_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "cheers";
            BitmapImage bi = new BitmapImage(new Uri(""));
            imageInfo.Source = bi;
        }

        private void BtnPowerSupply_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "tears";
            BitmapImage bi = new BitmapImage(new Uri(""));
            imageInfo.Source = bi;
        }

        private void InkWeb_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void BtnCase_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "tears";
            BitmapImage bi = new BitmapImage(new Uri(""));
            imageInfo.Source = bi;
        }
    }
}
