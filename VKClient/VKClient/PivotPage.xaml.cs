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
using Microsoft.Phone.Shell;
namespace VKClient
{

    public partial class PivotPage : PhoneApplicationPage
    {
        private static int navNumber = 0;
        public PivotPage()
        {
            InitializeComponent();
        }

        private void onSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (((Pivot)sender).SelectedIndex)
            {
                case 0:
                    ApplicationBar = ((ApplicationBar)Application.Current.Resources["AppBarConversationList"]);
                    break;

                case 1:
                    ApplicationBar = ((ApplicationBar)Application.Current.Resources["AppBarFriendList"]);
                    break;
            }
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            navNumber++;
            DataController.getLastMessages();
            base.OnNavigatedTo(e);
            if (navNumber % 2 != 0)
            {
                NavigationService.Navigate(new Uri("/PivotPage.xaml", UriKind.Relative));
            }
        }

    }
}