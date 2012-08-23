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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Threading;

using VKClient.dao;
namespace VKClient
{
    public partial class ConversationListPage : PhoneApplicationPage
    {
        IList<VKMessage> messageList = new List<VKMessage>();
        protected delegate void NoArgsDelegate();
        public ConversationListPage()
        {
            InitializeComponent();
            //update();
            DataController.setConversationListPage(this);
        }

        public void update(IList<VKMessage> list)
        {
            messageList = list;
            createControls();
        }

        private void createControls()
        {
            int index = 0;
            foreach (VKMessage message in messageList)
            {
                IList<VKUser> userList = UserDAO.getUsersByMessage(message);
                RowDefinition rowDefinition = new RowDefinition();
                rowDefinition.Height = GridLength.Auto;
                ContentPanel.RowDefinitions.Add(rowDefinition);
                //int index = 0;
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
                    Text = message.Body,
                    // TODO: implement showing of multiple users (беседа)
                    FullName = userList[0].LastName,
                    Time = message.Date.ToString()
                };
                ContentPanel.Children.Add(messControl);
                Grid.SetRow(messControl, index);
                index++;
            }
        }



    }
}