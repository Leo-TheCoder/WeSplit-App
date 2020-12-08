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

namespace GUI_WeSplit
{
    /// <summary>
    /// Interaction logic for TripDetailPage.xaml
    /// </summary>
    public partial class TripDetailPage : Page
    {
        private int tripID = 0;

        public TripDetailPage()
        {
            InitializeComponent();

            //Load data from the calling page (SearchPage)
            NavigationService.LoadCompleted += NavigationService_LoadCompleted;
        }

        private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        {
            tripID = (int)e.ExtraData;  //Get data from calling page

            //Do whatever you want herre
            //...
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MemberListPage memberList = new MemberListPage();
            TripDetailFrame.Navigate(memberList);
        }

        private void GeneralInfoButton_Click(object sender, MouseButtonEventArgs e)
        {
            //GeneralInfoButton.Background = Brus;
        }

        private void Sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
