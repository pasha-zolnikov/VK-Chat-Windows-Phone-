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
        public static String accessToken;
        public static List<Message> dialogs = new List<Message>();
        public PivotPage()
        {
            InitializeComponent();
        }

        private void ConversationListControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private static void BeginAuth()
        {
        }

        public static void LoadDialogs()
        {
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            accessToken = HttpRequestsHandler.accessToken;
            dialogs = HttpRequestsHandler.messages;

        }

    }
}