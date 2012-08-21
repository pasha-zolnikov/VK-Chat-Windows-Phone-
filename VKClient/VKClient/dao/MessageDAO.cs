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
    public class MessageDAO
    {
        public static IList<VKMessage> getLastMessages()
        {            
            using (VKDataContext context = new VKDataContext(VKDataContext.DBConnectionString))
            {               
                IQueryable<VKMessage> query = from c in context.VKMessage select c;
                return query.ToList();
            }
        }
    }
}
