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
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace VKClient
{
    public class HttpRequestsHandler
    {
        public static String accessToken { get; private set; }
        public static string result;
        private String CreateAuthString(String username, String password)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("?grant_type=password&client_id=");
            sb.AppendLine(Constants.appID.ToString());
            sb.AppendLine("&client_secret=");
            sb.AppendLine(Constants.appSecret);
            sb.AppendLine("&username=");
            sb.AppendLine(username);
            sb.AppendLine("&password=");
            sb.AppendLine(password);

            return sb.ToString();
        }

        

        //public void AuthHttp(object info)
        //{
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://oauth.vk.com/token?grant_type=password&client_id=3059981&client_secret=YWES9oRC76HvjYLIA62a&username=pasha.zolnikov@gmail.com&password=g47DKFJ7yg56918234&scope=messages");
        //    request.BeginGetResponse(new AsyncCallback(AuthRequestCallback), request);
        //}

        //private void AuthRequestCallback(IAsyncResult callbackResult)
        //{
        //    HttpWebRequest myRequest = (HttpWebRequest)callbackResult.AsyncState;
        //    HttpWebResponse myResponse = (HttpWebResponse)myRequest.EndGetResponse(callbackResult);

        //    using (StreamReader httpwebStreamReader = new StreamReader(myResponse.GetResponseStream()))
        //    {
        //        string results = httpwebStreamReader.ReadToEnd();
        //        var answer = JsonConvert.DeserializeObject<AuthAnswer>(results);
        //        accessToken = answer.accessToken;
        //        //TextBlockResults.Text = results; //-- on another thread!
        //    }
        //    myResponse.Close();
        //}

        private void RetreiveAccessToken(String results)
        {
            var answer = JsonConvert.DeserializeObject<AuthAnswer>(results);
            accessToken = answer.accessToken;
        }

        public void AuthHttp(Action callback, Action<Exception> error)
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
            client.DownloadStringAsync(new Uri("https://oauth.vk.com/token?grant_type=password&client_id=3059981&client_secret=YWES9oRC76HvjYLIA62a&username=pasha.zolnikov@gmail.com&password=g47DKFJ7yg56918234&scope=messages"));
        }

        //private void client_DownloadStringSompleted(object sender, DownloadStringCompletedEventArgs ololo)
        //{
        //    if (ololo.Error == null)
        //    {
        //        PivotPage.result = ololo.Result;
                
        //    }
        //}

        public void GetDialogs(Action callback, Action<Exception> error)
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
        }
        
    }
}
