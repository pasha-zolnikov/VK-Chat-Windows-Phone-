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


            //move this code into DAOUser
            IList<VKMessage> messageList = null;
            using (VKDataContext context = new VKDataContext(VKDataContext.DBConnectionString))
            {
                IList<UserMessage> usermessageList = null;
                IQueryable<UserMessage> usermessagequery = from c in context.UserMessage select c;
                usermessageList = usermessagequery.ToList();

                IQueryable<VKMessage> query = from c in context.VKMessage select c;
                messageList = query.ToList();


                UserMessage um = messageList[0].UserMessages[0];

                IList<VKUser> userList = null;


                IQueryable<VKUser> userquery = from c in context.VKUser where c.VKUserID == um.VKUserID select c;
                userList = userquery.ToList();


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
                    Text = messageList[0].Body,
                    FullName = userList[0].LastName,
                    Time = messageList[0].Date.ToString()
                };
                ContentPanel.Children.Add(messControl);
                Grid.SetRow(messControl, 0);

            }
        }
    }
}