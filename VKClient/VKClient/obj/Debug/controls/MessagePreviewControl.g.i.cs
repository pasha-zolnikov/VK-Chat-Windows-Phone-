﻿#pragma checksum "D:\Новая папка\VK-Chat-Windows-Phone-\VKClient\VKClient\controls\MessagePreviewControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5E4D8EFEE9F913F55EF04128E3BE9D43"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.544
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace VKClient.controls {
    
    
    public partial class MessagePreviewControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock fullnameBlock;
        
        internal System.Windows.Controls.TextBlock textBlock;
        
        internal System.Windows.Controls.TextBlock timeBlock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/VKClient;component/controls/MessagePreviewControl.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.fullnameBlock = ((System.Windows.Controls.TextBlock)(this.FindName("fullnameBlock")));
            this.textBlock = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock")));
            this.timeBlock = ((System.Windows.Controls.TextBlock)(this.FindName("timeBlock")));
        }
    }
}

