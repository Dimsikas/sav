using sav.ClassFolder;
using sav.PageFolder.BodyPage;
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

namespace sav.PageFolder.MenuPage
{
    public partial class MenuDirector : Page
    {
        public MenuDirector()
        {
            InitializeComponent();
        }

        private void tb2_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyOne());
        }

        private void tb_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyTho());
        }

        private void Tb1_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyThree());
        }
    }
}
