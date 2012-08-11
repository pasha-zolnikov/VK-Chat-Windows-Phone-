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
using Newtonsoft.Json;

namespace VKClient
{
    public class AuthAnswer
    {
        [JsonProperty(PropertyName = "user_id")]
        public String uid { get; set; }
        [JsonProperty(PropertyName = "access_token")]
        public String accessToken { get; set; }
        [JsonProperty(PropertyName = "expires_in")]
        public String expireTime { get; set; }
    }   
}
