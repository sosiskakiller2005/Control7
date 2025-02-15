﻿using Control7.AppData;
using Control7.Views.Pages;
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

namespace Control7.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            FrameHelper.selectedFrame = MainFrm;
            MainFrm.Navigate(new StartPage());
        }

        private void AddManufacterBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AddManuacterPage());
        }

        private void AddMaterialBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AddMaterialPage());
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AccountingPage());
        }

        private void OtchetBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
