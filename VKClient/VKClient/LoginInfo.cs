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

namespace VKClient
{
    public class LoginInfo
    {
        public String login { get; private set;}
        public String password { get; private set; }

        public LoginInfo(String login, String password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
