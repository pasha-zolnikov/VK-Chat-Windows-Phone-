﻿#pragma checksum "D:\Новая папка\VK-Chat-Windows-Phone-\VKClient\VKClient\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "585158319376A0125D568CDAFF1FEC64"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.544
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace VKClient {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Image VKLogo;
        
        internal System.Windows.Controls.Grid LoginPanel;
        
        internal System.Windows.Controls.TextBlock LoginBoxTitle;
        
        internal System.Windows.Controls.TextBox LoginBox;
        
        internal System.Windows.Controls.TextBlock PasswordBoxTitle;
        
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        internal System.Windows.Controls.Button LoginButton;
        
        internal System.Windows.Controls.Grid RegisterPanel;
        
        internal System.Windows.Controls.Button RegisterButton;
        
        internal System.Windows.Controls.TextBlock RegisterTextBlock;
        
        internal System.Windows.Controls.TextBlock RegisterPossibilityTextBlock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/VKClient;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.VKLogo = ((System.Windows.Controls.Image)(this.FindName("VKLogo")));
            this.LoginPanel = ((System.Windows.Controls.Grid)(this.FindName("LoginPanel")));
            this.LoginBoxTitle = ((System.Windows.Controls.TextBlock)(this.FindName("LoginBoxTitle")));
            this.LoginBox = ((System.Windows.Controls.TextBox)(this.FindName("LoginBox")));
            this.PasswordBoxTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PasswordBoxTitle")));
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(this.FindName("PasswordBox")));
            this.LoginButton = ((System.Windows.Controls.Button)(this.FindName("LoginButton")));
            this.RegisterPanel = ((System.Windows.Controls.Grid)(this.FindName("RegisterPanel")));
            this.RegisterButton = ((System.Windows.Controls.Button)(this.FindName("RegisterButton")));
            this.RegisterTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("RegisterTextBlock")));
            this.RegisterPossibilityTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("RegisterPossibilityTextBlock")));
        }
    }
}

