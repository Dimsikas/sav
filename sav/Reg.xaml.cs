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
using System.Windows.Shapes;

namespace sav
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
           
            if (LoginTB.Text == "" && PasswordTB.Text == "")
            {
                MessageBox.Show("Поля пустые");
            }
            else
            {
                if (AppConectClass.DB.Employee.Count(x => x.Login == LoginTB.Text||x.Password==PasswordTB.Text)>0)
                {
                    MessageBox.Show("Пользователь с такими данными уже существует");
                }
                else
                {
                    Employee employee = new Employee()
                    {
                        Id_role = 4,
                        FIO_employe = FioTB.Text,
                        Login = LoginTB.Text, 
                        Password = PasswordTB.Text
                    };
                    AppConectClass.DB.Employee.Add(employee);
                    AppConectClass.DB.SaveChanges();
                    MessageBox.Show("Регестрация прошла успеша!");
                    kab3 kab3 = new kab3();
                    kab3.Show();
                    this.Close();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorization = new AuthorizationWindow();
            authorization.Show();
            this.Close();
        }

        
        

        
    }
    }

