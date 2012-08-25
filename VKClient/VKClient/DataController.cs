using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using VKClient.dao;
namespace VKClient
{
    public class DataController
    {
        private static ConversationListPage ConversationListPage;

        public static void getLastMessages()
        {
            IList<VKMessage> list = MessageDAO.getLastMessages();
            if (list.Count == 0)
            {
                HttpRequestsHandler.GetDialogs((x) =>
                    {
                        LoadMessages(x);
                    }, (error) => { }
                    );
                list = MessageDAO.getLastMessages();
            }
            ConversationListPage.update(list);
        }

        public static void LoadMessages(List<Message> dialogs)
        {
            for (int i = 0; i < dialogs.Count; i++)
            {
                Message msg = dialogs[i];
                HttpRequestsHandler.GetUserByID(msg.uid, (x) =>
                {
                    using (VKDataContext context = new VKDataContext(VKDataContext.DBConnectionString))
                    {
                        VKMessage vm = new VKMessage();
                        vm.Body = msg.body;
                        vm.Date = DateConverter.DateTimeFromUnixTimestampSeconds(msg.date);
                        vm.VKMessageID = msg.mid;
                        VKUser user = new VKUser();

                        user.FirstName = x.first_name;
                        user.LastName = x.last_name;
                        user.IsOnline = (x.online == 1);
                        user.VKUserID = x.uid;

                        context.VKUser.InsertOnSubmit(user);
                        context.SubmitChanges();

                        context.VKMessage.InsertOnSubmit(vm);
                        context.SubmitChanges();

                        UserMessage um = new UserMessage();
                        um.VKMessageID = user.VKUserID;
                        um.VKUserID = vm.VKMessageID;

                        context.UserMessage.InsertOnSubmit(um);
                        context.SubmitChanges();
                    }
                }, (error) =>
                {
                });
            }
        }

        public static void setConversationListPage(ConversationListPage Page)
        {
            ConversationListPage = Page;
        }
    }
}
