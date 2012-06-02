using System;
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
using System.Threading;

namespace VKClient
{

    public partial class PivotPage : PhoneApplicationPage
    {
        public static String result;
        public PivotPage()
        {
            InitializeComponent();
        }

        private void ConversationListControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //public static void LoadDialogs(String login, String password)
        //{
        //    LoginInfo info = new LoginInfo(login, password);
        //    HttpRequestsHandler rh = new HttpRequestsHandler();
        //    //Thread loginThread = new Thread(rh.AuthHttp);
        //    //loginThread.Start(info);
        //    //loginThread.Join();
        //    //Thread.Sleep(TimeSpan.FromSeconds(1));
        //    //String ololo = HttpRequestsHandler.accessToken;
        //}

        private static void BeginAuth()
        {
        }

        public static void LoadDialogs()
        {
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
        }
    }
}