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

namespace sav
{
    /// <summary>
    /// Логика взаимодействия для kab.xaml
    /// </summary>
    public partial class kab : Window
    {
        public kab()
        {
            InitializeComponent();
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Navfrm.Navigate(new tab2());
        }

        private void tb_Click(object sender, RoutedEventArgs e)
        {
            Navfrm.Navigate(new tabl1());
        }

        private void Tb1_Click(object sender, RoutedEventArgs e)
        {
            Navfrm.Navigate(new tabl3());
        }

        private void tb3_Click(object sender, RoutedEventArgs e)
        {
            Navfrm.Navigate(new tabl4());
        }

        private void ToMWbtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
