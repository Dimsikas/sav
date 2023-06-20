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
    /// Логика взаимодействия для kab3.xaml
    /// </summary>
    public partial class kab3 : Window
    {
        public kab3()
        {
            InitializeComponent();
        }

        private void BT19_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ToMWbtn_Click1(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
