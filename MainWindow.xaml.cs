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


namespace FirstProject
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
            txtInfo.Text = "Intel Core i7-8700 6-Core 3.2 GHz (4.6 GHz Turbo)";
            InkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117826&Description=i7%20procceser&cm_re=i7_procceser-_-19-117-826-_-Product");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/19-117-826-Z01.jpg"));
            imageInfo.Source = bi;
        }
        private void btnStorage_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Seagate BarraCuda ST2000DM006 2TB 7200 ";
            InkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16822178993");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/ProductImageCompressAll1280/22-178-993-V01.jpg"));
            imageInfo.Source = bi;
        }
        private void btnGraphicsCard_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "ASUS ROG GeForce GTX 1060";
            InkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16814126113");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/ProductImageCompressAll1280/14-126-113_R01.jpg"));
            imageInfo.Source = bi;
        }
        private void btnMotherboard_Click(object sender, RoutedEventArgs e)
        { 
        txtInfo.Text = "GIGABYTE Z390 AORUS MASTER LGA 1151 (300 Series)";
            InkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16813145089");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/13-145-089-V08.jpg"));
        imageInfo.Source = bi;
            }
        private void btnBluerayburner_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "LG Black Blu-ray Burner";
            InkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16827136269");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/productimage/27-136-269-08.jpg"));
            imageInfo.Source = bi;
        }
        private void btnRAM_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "G.SKILL TridentZ RGB Series 16GB";
            InkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16820232498&Description=ram&cm_re=ram-_-20-232-498-_-Product");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/20-232-498-V04.jpg"));
            imageInfo.Source = bi;
        }
        private void BtnPowerSupply_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Rosewill ARC Series 450W";
            InkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16817182295");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/17-182-295_R01.jpg"));
            imageInfo.Source = bi;
        }
        private void InkWeb_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
        private void BtnCase_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Fractal Design Core 1000 Black MATX Mini Tower Computer Case";
            InkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16811352032&ignorebbr=1&source=region&nm_mc=KNC-GoogleAdwordsCA-PC&cm_mmc=KNC-GoogleAdwordsCA-PC-_-pla-_-Cases+%28Computer+Cases+-+ATX+Form%29-_-N82E16811352032&gclid=Cj0KCQiAzePjBRCRARIsAGkrSm7fVN4EocPOy3zoS7SLgGeLZnWCHptHs3dAhUIP9DuzzqgYvAsICoEaAi1VEALw_wcB");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/11-352-032-02.jpg"));
            imageInfo.Source = bi;
        }
        }

}
