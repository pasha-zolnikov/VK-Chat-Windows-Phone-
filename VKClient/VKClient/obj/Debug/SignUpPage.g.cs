﻿#pragma checksum "C:\Users\dautov-r\Documents\GitHub\VK-Chat-Windows-Phone-\VKClient\VKClient\SignUpPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CE85F3432B05406DC5AF92EC083F31F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace VKClient.Assets {
    
    
    public partial class RegisterPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Image VKLogo;
        
        internal System.Windows.Controls.Grid RegisterPanel;
        
        internal System.Windows.Controls.TextBlock PhoneNumberBoxTitle;
        
        internal System.Windows.Controls.TextBox PhoneNumberBox;
        
        internal System.Windows.Controls.TextBlock NameBoxTitle;
        
        internal System.Windows.Controls.PasswordBox NameBox;
        
        internal System.Windows.Controls.TextBlock SurnameBoxTitle;
        
        internal System.Windows.Controls.PasswordBox SurnameBox;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/VKClient;component/SignUpPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.VKLogo = ((System.Windows.Controls.Image)(this.FindName("VKLogo")));
            this.RegisterPanel = ((System.Windows.Controls.Grid)(this.FindName("RegisterPanel")));
            this.PhoneNumberBoxTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PhoneNumberBoxTitle")));
            this.PhoneNumberBox = ((System.Windows.Controls.TextBox)(this.FindName("PhoneNumberBox")));
            this.NameBoxTitle = ((System.Windows.Controls.TextBlock)(this.FindName("NameBoxTitle")));
            this.NameBox = ((System.Windows.Controls.PasswordBox)(this.FindName("NameBox")));
            this.SurnameBoxTitle = ((System.Windows.Controls.TextBlock)(this.FindName("SurnameBoxTitle")));
            this.SurnameBox = ((System.Windows.Controls.PasswordBox)(this.FindName("SurnameBox")));
        }
    }
}
