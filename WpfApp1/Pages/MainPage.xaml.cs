﻿using System;
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
using WpfApp1.Classes;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            Manager.MainFrame = MainPageFrame;
            Manager.MainFrame.Navigate(new HomePage()); 

            
                    
            

        }

        private void LeftMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            LeftMenu.Width = 200;
            //MainPageFrame.Margin = new Thickness(260,0,0,0);


        }

        private void LeftMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            LeftMenu.Width = 50;
            //MainPageFrame.Margin = new Thickness(60, 0, 0, 0);
        }

        private void LeftMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void LeftMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {          
            switch (LeftMenu.SelectedIndex)
            {
                case 0:
                    Manager.MainFrame.Navigate(new HomePage());
                    break;
                case 1:
                    Manager.MainFrame.Navigate(new BuyerPage());
                    break;
                case 2:
                    Manager.MainFrame.Navigate(new PlanePage());
                    break;
                case 3:
                    Manager.MainFrame.Navigate(new PersonnelPage());
                    break;
            }
        }

        private void TopMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TopMenu.SelectedIndex > 1)
            {
                switch (TopMenu.SelectedIndex)
                {

                    case 2:
                        Manager.MainFrame.Navigate(new FlightPlane());
                        break;

                }
                foreach (ListViewItem li in TopMenu.Items)
                {
                    li.Background = new BrushConverter().ConvertFromString("#00000000") as SolidColorBrush;
                }
                (TopMenu.SelectedItem as ListViewItem).Background = new BrushConverter().ConvertFromString("#AA5555") as SolidColorBrush;
                TopMenu.SelectedIndex = -1;
            }
        }
    }
}
