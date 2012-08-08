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

namespace VKClient
{
    public partial class ConversationListPage : PhoneApplicationPage
    {
        public ConversationListPage()
        {
            InitializeComponent();
            //load messages




            //for each message create textblock (should be custom MessagePreviewControl)

            RowDefinition rowDefinition1 = new RowDefinition();
            rowDefinition1.Height = GridLength.Auto;
            ContentPanel.RowDefinitions.Add(rowDefinition1);

            TextBlock vasjaMess = new TextBlock
            {
                Text = "Сообщение от Васи",
                Foreground = new SolidColorBrush(Colors.White),
                FontSize = 28            
            };
            ContentPanel.Children.Add(vasjaMess);
            Grid.SetRow(vasjaMess, 0);


            RowDefinition rowDefinition2 = new RowDefinition();
            rowDefinition2.Height = GridLength.Auto;
            ContentPanel.RowDefinitions.Add(rowDefinition2);
            TextBlock petjaMess = new TextBlock
            {
                Text = "Сообщение от Пети",
                Foreground = new SolidColorBrush(Colors.White),
                FontSize = 28,                
            };
            ContentPanel.Children.Add(petjaMess);
            Grid.SetRow(petjaMess, 1);
        }
    }
}