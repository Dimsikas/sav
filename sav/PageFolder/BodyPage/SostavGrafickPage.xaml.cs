using sav.ClassFolder;
using sav.NewFolder1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class SostavGrafickPage : Page
    {
        public SostavGrafickPage()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
            WorkerComboBox.ItemsSource = AppConectClass.DB.Employee.ToList();
        }

        private void AddWorkerGrafickButton_Click(object sender, RoutedEventArgs e)
        {
            if (WorkerComboBox.Text == "" || GrafTextBox.Text == "" || DateDatePicker.Text == "")
            {
                MessageBox.Show(
                    "Поля пустые", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    var dataWorker = new Employee();
                    dataWorker = AppConectClass.DB.Employee.Find((WorkerComboBox.SelectedItem as Employee).Id_employee);
                    dataWorker.Schedule = GrafTextBox.Text;
                    dataWorker.Release_date = DateDatePicker.SelectedDate;

                    AppConectClass.DB.SaveChanges();
                         MessageBox.Show(
                            "Успешно сохранено", "Yay",
                            MessageBoxButton.OK, MessageBoxImage.Information);

                    FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyOne());
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
}
