using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace VKClient.controls
{
    public partial class MessagePreviewControl : UserControl
    {
        public Image Avatar { get; set; }
        public String Time { get; set; }
        public String Text { get; set; }
        public String FullName{ get;  set;}

        public MessagePreviewControl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
            Touch.FrameReported += new TouchFrameEventHandler(on_click);
        }

        void on_click(object sender, TouchFrameEventArgs e)
        {            
            //NavigationService ns = NavigationService.GetNavigationService(this);
            //ns.Navigate(new Uri("/ConversationPage.xaml", UriKind.Relative));
            
        }
    }
}
