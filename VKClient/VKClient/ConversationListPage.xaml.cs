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
using VKClient.controls;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace VKClient
{
    public partial class ConversationListPage : PhoneApplicationPage
    {
        public ConversationListPage()
        {
            InitializeComponent();
            //load messages




            //for each message create textblock (should be custom MessagePreviewControl)         
            RowDefinition rowDefinition = new RowDefinition();
            rowDefinition.Height = GridLength.Auto;
            ContentPanel.RowDefinitions.Add(rowDefinition);
            /*
            Image avatar = new Image();
            Uri uri = new Uri("VKClient/Assets/Photo_Placeholder.png", UriKind.Relative);            
            StreamResourceInfo resourceInfo = Application.GetResourceStream(uri);            
            BitmapImage bmp = new BitmapImage();
            bmp.SetSource(resourceInfo.Stream);
            avatar.Source = bmp;
            */
            MessagePreviewControl messControl = new MessagePreviewControl
            {
                //Avatar = avatar,
                Text = "Привет! Как дела?",
                FullName = "Петя Петров",
                Time = "вчера"
            };
            ContentPanel.Children.Add(messControl);
            Grid.SetRow(messControl, 0);

            
        }
    }
}