using sav.ClassFolder;
using sav.NewFolder1;
using sav.PageFolder.BodyPage;
using sav.PageFolder.MenuPage;
using System;
using System.Linq;
using System.Windows;

namespace sav
{
    public partial class AuthorizationWindow : Window
    {
       public static bool qwerty = false;

        public AuthorizationWindow()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Close();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            /// try{} catch (Exception ex) {} - это обработчик ошибок
            /// код выполняется в блоке кода try{}, если в этом блоке кода произошла ошибка, то код начинает выполяться в 
            /// catch (Exception ex) {}
            /// Самый простой пример - это если пользователь сделает что-то не то и БД выдаст ошибку, то программа не зависнет
            /// а просто обработается код в catch (Exception ex) {} и программа НЕ закроется
            try
            {
                if (LoginTextBox.Text == "" || PasswordTextBox.Password == "")
                {
                    MessageBox.Show(
                        "Поле логин или пароль пустое", "Пустые поля", 
                        MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                else
                {
                    var userData =  AppConectClass.DB.Employee.FirstOrDefault(z =>
                        z.Login == LoginTextBox.Text && z.Password == PasswordTextBox.Password);
                    ///<!--
                    /// AppConnectClass - класс подключения
                    /// DataBase - название подключения
                    /// UserTable - таблица в которой хранится информация о пользователях
                    /// FirstOrDefold - написано неправильно, но это дейсьвте над таблицей (найди всех или последнего по таким то данным)
                    /// -->
                    
                    if (userData != null)
                    {
                        MainWindow mainWindow = new MainWindow();
                        switch(userData.Id_role)
                        {
                            case 1:
                                mainWindow.Show();
                                FrameNavigationClass.MenuFrame.Navigate(new MenuDirector());
                                FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyOne());
                                MessageBox.Show($"Добро пожаловать {userData.FIO_employe}!"); 
                                this.Close();
                                break;
                            case 2:
                                kab1 kab1 = new kab1();
                                kab1.Show();
                                MessageBox.Show($"Добро пожаловать {userData.FIO_employe}!");
                                this.Close();
                                break;
                            case 3:
                                kab2 kab2 = new kab2();
                                kab2.Show();
                                MessageBox.Show($"Добро пожаловать {userData.FIO_employe}!");
                                this.Close();
                                break;
                            case 4:
                                mainWindow.Show();
                                FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyOne());
                                MessageBox.Show($"Добро пожаловать {userData.FIO_employe}!");
                                this.Close();
                                break;

                                default:
                                MessageBox.Show("У вас нет доступа");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Неправильный логин или пароль", "Ошибка входа",
                        MessageBoxButton.OK, MessageBoxImage.Hand);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message.ToString(), "Error Exception",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
