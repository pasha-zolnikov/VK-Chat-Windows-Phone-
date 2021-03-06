﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
//using System.Threading;

namespace VKClient
{
    public partial class MainPage : PhoneApplicationPage
    {

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            if (HttpRequestsHandler.accessToken == null)
            {
                HttpRequestsHandler.AuthHttp(() =>
                {
                    NavigationService.Navigate(new Uri("/PivotPage.xaml" +  "?Refresh=true", UriKind.Relative));
                }, (error) =>
                {
                });
            }
            else
            {
                NavigationService.Navigate(new Uri("/PivotPage.xaml", UriKind.Relative));
            }

        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SignUpPage.xaml", UriKind.Relative));
        }
    }
}