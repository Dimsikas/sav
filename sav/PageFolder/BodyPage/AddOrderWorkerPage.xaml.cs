﻿using sav.ClassFolder;
using sav.NewFolder1;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace sav.PageFolder.BodyPage
{
    public partial class AddOrderWorkerPage : Page
    {
        public AddOrderWorkerPage()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
            WorkerComboBox.ItemsSource = AppConectClass.DB.Employee.ToList();
        }

        private void AddWorkerOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (OrderTextBox.Text == "" || WorkerComboBox.Text == "" || DateDatePicker.Text == "")
            {
                MessageBox.Show(
                    "Поля пустые", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    int numberOrder = Convert.ToInt32(OrderTextBox.Text);

                    var addOrder = new Orders();
                    addOrder.Number_order = numberOrder;
                    addOrder.Id_employee = (WorkerComboBox.SelectedItem as Employee).Id_employee;
                    addOrder.Deadline = DateDatePicker.SelectedDate;
                    addOrder.Date_orders = DateTime.Today;

                    if (AppConectClass.DB.Orders.Count(x => x.Number_order == numberOrder) > 0)
                    {
                        MessageBox.Show(
                            "В базе данных уже существует заказ с таким же номером", "Error",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        AppConectClass.DB.Orders.Add(addOrder);
                        AppConectClass.DB.SaveChanges();

                        MessageBox.Show(
                            "Заказ успешно добавлен", "YAY",
                            MessageBoxButton.OK, MessageBoxImage.Information);

                        FrameNavigationClass.BodyFrame.Navigate(new DirectorBodyTho());
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                       ex.Message.ToString(), "Error Exception",
                       MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
