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
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace VKClient
{
    [Table]
    public class UserMessage
    {
        [Column(IsPrimaryKey = true)]
        public int VKUserID { get; set; }

        [Column(IsPrimaryKey = true)]
        public int VKMessageID { get; set; }

        private EntityRef<VKUser> vkuser;
        [Association(ThisKey = "VKUserID", OtherKey = "VKUserID", Storage = "vkuser")]
        public VKUser VKUser{ get { return vkuser.Entity; } set { vkuser.Entity = value; } }

        private EntityRef<VKMessage> vkmessage;
        [Association(ThisKey = "VKMessageID", OtherKey = "VKMessageID", Storage = "vkmessage")]
        public VKMessage VKMessage { get { return vkmessage.Entity; } set { vkmessage.Entity = value; } }
    }
}
