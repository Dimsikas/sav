﻿using sav.ClassFolder;
using sav.NewFolder1;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace sav.PageFolder.BodyPage
{
    public partial class DirectorBodyTho : Page
    {
        public DirectorBodyTho()
        {
            InitializeComponent();
            AppConectClass.DB = new SavEntities();
            MainList.ItemsSource = AppConectClass.DB.Orders.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                MainList.Items.Refresh();

                if (AuthorizationWindow.qwerty == true)
                {
                    bt10.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.BodyFrame.Navigate(new AddOrderWorkerPage());
        }
    }
}
