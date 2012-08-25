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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace VKClient
{
    [Table]
    public class VKMessage : INotifyPropertyChanged, INotifyPropertyChanging
    {
        // Message id. Primary key of the table.
        private int _vkmessageid;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int VKMessageID
        {
            get
            {
                return _vkmessageid;
            }
            set
            {
                if (_vkmessageid != value)
                {
                    NotifyPropertyChanging("VKMessageID");
                    _vkmessageid = value;
                    NotifyPropertyChanged("VKMessageID");
                }
            }
        }

        // Id of user who sent the message. Many to many relationsip. Foreign key for table UserMessage
        [Association(ThisKey = "VKMessageID", OtherKey = "VKMessageID")]
        public EntitySet<UserMessage> UserMessages { get; set; }

        // Text body of the message
        private string _body;

        [Column]
        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                if (_body != value)
                {
                    NotifyPropertyChanging("body");
                    _body = value;
                    NotifyPropertyChanged("body");
                }
            }
        }

        // Defines is the message read or not yet
        private bool _isRead;

        [Column]
        public bool IsRead
        {
            get
            {
                return _isRead;
            }
            set
            {
                if (_isRead != value)
                {
                    NotifyPropertyChanging("isRead");
                    _isRead = value;
                    NotifyPropertyChanged("isRead");
                }
            }
        }


        // Date the message was sent
        private DateTime _date;

        [Column]
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (_date != value)
                {
                    NotifyPropertyChanging("date");
                    _date = value;
                    NotifyPropertyChanged("date");
                }
            }
        }



        // Version column aids update performance.
        [Column(IsVersion = true)]
        private Binary _version;

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify the page that a data context property changed
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        // Used to notify the data context that a data context property is about to change
        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        #endregion

        public VKMessage()
        {
            UserMessages = new EntitySet<UserMessage>();
        }
    }

}