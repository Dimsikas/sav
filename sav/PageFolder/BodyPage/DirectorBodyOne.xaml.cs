using sav.NewFolder1;
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

        private void bt10_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
