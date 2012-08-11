﻿using System;
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

namespace VKClient
{
    public class HttpRequestsHandler
    {
        private String accessToken;
        private String results;
        private String[] separator = { ":", ",", "{", "}", "\"" };
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

        public void SignIn(String username, String password)
        {
            AuthHttp(username, password);            
        }

        private void AuthHttp(String username, String password)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://oauth.vk.com/token?grant_type=password&client_id=3059981&client_secret=YWES9oRC76HvjYLIA62a&username=pasha.zolnikov@gmail.com&password=g47DKFJ7yg56918234&scope=messages");
            request.BeginGetResponse(new AsyncCallback(ReadWebRequestCallback), request);       
        }

        private void ReadWebRequestCallback(IAsyncResult callbackResult)
        {
            HttpWebRequest myRequest = (HttpWebRequest)callbackResult.AsyncState;
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.EndGetResponse(callbackResult);

            using (StreamReader httpwebStreamReader = new StreamReader(myResponse.GetResponseStream()))
            {
                results = httpwebStreamReader.ReadToEnd();
                RetreiveAccessToken();
                //TextBlockResults.Text = results; //-- on another thread!
                //Dispatcher.BeginInvoke(() => TextBlockResults.Text = results);
            }
            myResponse.Close();
        }

        private void RetreiveAccessToken()
        {
            Dictionary<string, string> answer = JsonParser.ParseJson(results);
            answer.TryGetValue("access_token", out accessToken);
        }

        public void GetDialogs()
        {
            //JsonParser.ParseJson()
        }
        
    }
}