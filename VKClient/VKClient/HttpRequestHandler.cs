using System;
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
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace VKClient
{
    public class HttpRequestsHandler
    {
        public static String accessToken { get; private set; }

        private static String CreateAuthDataString(String username, String password)
        {
            return String.Format("?grant_type=password&client_id={0}&client_secret={1}&username={2}&password={3}&scope=messages", Constants.appID.ToString(), Constants.appSecret, username, password);
        }

        public static void AuthHttp(Action callback, Action<Exception> error)
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted += (p, q) =>
                {
                    if (q.Error == null)
                    {
                        accessToken = JsonConvert.DeserializeObject<AuthAnswer>(q.Result).accessToken;
                        
                        callback();
                    }
                    else
                    {
                        error(q.Error);
                    }
                };
            client.DownloadStringAsync(new Uri("https://oauth.vk.com/token" + CreateAuthDataString("pasha.zolnikov@gmail.com", "g47DKFJ7yg56918234")));
        }

        public static void GetDialogs(Action<List<Message>> callback, Action<Exception> error)
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted += (p, q) =>
            {
                if (q.Error == null)
                {
                    var itemList = ((JObject)JsonConvert.DeserializeObject(q.Result))["response"]
                .Skip(1)
                .Select(x => JsonConvert.DeserializeObject<Message>(x.ToString()))
                .ToList();
                    //messages = itemList;
                    callback(itemList);
                }
                else
                {
                    error(q.Error);
                }
            };
            client.DownloadStringAsync(new Uri(String.Format("https://api.vkontakte.ru/method/messages.getDialogs?access_token={0}", accessToken)));
        }

        public static void getMessages(int userID, Action callback, Action<Exception> error)
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted += (p, q) =>
            {
                if (q.Error == null)
                {
                    var itemList = ((JObject)JsonConvert.DeserializeObject(q.Result))["response"]
                .Skip(1)
                .Select(x => JsonConvert.DeserializeObject<Message>(x.ToString()))
                .ToList();

                    callback();
                }
                else
                {
                    error(q.Error);
                }
            };
            client.DownloadStringAsync(new Uri(String.Format("https://api.vkontakte.ru/method/messages.getDialogs?access_token={0}", accessToken)));
        }


        public static void GetUserByID(int userID, Action<User> callback, Action<Exception> error)
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted += (p, q) =>
            {
                if (q.Error == null)
                {
                    var user = JsonConvert.DeserializeObject<User>(((JObject)JsonConvert.DeserializeObject(q.Result))["response"].ToArray()[0].ToString());
                    //var user = JOject
                    callback(user);
                }
                else
                {
                    error(q.Error);
                }
            };
            client.DownloadStringAsync(new Uri(String.Format("https://api.vkontakte.ru/method/users.get?uid={0}&fields=online&access_token={1}", userID.ToString(), accessToken)));
        }
    }
}
