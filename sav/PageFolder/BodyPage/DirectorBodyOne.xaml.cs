using sav.ClassFolder;
using sav.NewFolder1;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace sav.PageFolder.BodyPage
{
    public partial class DirectorBodyOne : Page
    {
        public DirectorBodyOne()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
            MainList.ItemsSource = AppConectClass.DB.Employee.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                MainList.Items.Refresh();
            }
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.BodyFrame.Navigate(new SostavGrafickPage());
        }
    }
}
