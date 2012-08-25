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
    public class Message
    {
        public int mid { get; set; }
        public long date { get; set; }
        public int @out { get; set; }
        public int uid { get; set; }
        public int read_state { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
