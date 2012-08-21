using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace VKClient.dao
{
    public class UserDAO
    {
        public static IList<VKUser> getUsersByMessage(VKMessage message)
        {
            IList<VKUser> userList = new List<VKUser>();
            using (VKDataContext context = new VKDataContext(VKDataContext.DBConnectionString))
            {
                IQueryable<UserMessage> usermessagequery = from c in context.UserMessage where c.VKMessageID == message.VKMessageID select c;
                IList<UserMessage> usermessageList = usermessagequery.ToList();
                foreach (UserMessage um in usermessageList)
                {
                    IQueryable<VKUser> userquery = from c in context.VKUser where c.VKUserID == um.VKUserID select c;
                    foreach(VKUser user in userquery.ToList()){
                        userList.Add(user);
                    }
                }                                
            }
            return userList;
        }        
    }
}
