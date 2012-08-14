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
    public class VKUser: INotifyPropertyChanged, INotifyPropertyChanging
    {
        // Id of user. Primary key.
        private int _vkuid;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int VKUserID
        {
            get
            {
                return _vkuid;
            }
            set
            {
                if (_vkuid != value)
                {
                    NotifyPropertyChanging("VKUserID");
                    _vkuid = value;
                    NotifyPropertyChanged("VKUserID");
                }
            }
        }


 
        // Id of message which this user sent. Many to many relationsip. Foreign key for table UserMessage
        [Association(ThisKey = "VKUserID", OtherKey = "VKUserID")]
        public EntitySet<UserMessage> UserMessages { get; set; }

        // Last name of the user.
        private string _lastName;

        [Column]
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    NotifyPropertyChanging("lastName");
                    _lastName = value;
                    NotifyPropertyChanged("lastName");
                }
            }
        }



        // First name of the user.
        private string _firstName;

        [Column]
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    NotifyPropertyChanging("firstName");
                    _firstName = value;
                    NotifyPropertyChanged("firstName");
                }
            }
        }


        // Photo of the user.
        private string _photo;

        [Column]
        public string Photo
        {
            get
            {
                return _photo;
            }
            set
            {
                if (_photo != value)
                {
                    NotifyPropertyChanging("photo");
                    _photo = value;
                    NotifyPropertyChanged("photo");
                }
            }
        }


        // Defines is the user online or not
        private bool _isOnline;

        [Column]
        public bool IsOnline
        {
            get
            {
                return _isOnline;
            }
            set
            {
                if (_isOnline != value)
                {
                    NotifyPropertyChanging("isOnline");
                    _isOnline = value;
                    NotifyPropertyChanged("isOnline");
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

        public VKUser()
        {
            UserMessages = new EntitySet<UserMessage>();
        }
    }
}
