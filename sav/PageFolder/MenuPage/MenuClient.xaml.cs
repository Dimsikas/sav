using sav.ClassFolder;
using sav.PageFolder.BodyPage;
using System.Windows;
using System.Windows.Controls;

namespace sav.PageFolder.MenuPage
{
    public partial class MenuClient : Page
    {
        public MenuClient()
        {
            InitializeComponent();
        }

        private void Tb1_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.BodyFrame.Navigate(new ClientPage());
        }

        private void tb_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyThree());
        }

        private void tb2_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyTho());
        }
    }
}
