﻿#pragma checksum "..\..\PromptEmailWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "922C2A2766B1E58B25AFDB90793817C0529EC9C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using generate_dean_list_cert;


namespace generate_dean_list_cert {
    
    
    /// <summary>
    /// PromptEmailWindow
    /// </summary>
    public partial class PromptEmailWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\PromptEmailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailMessage;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\PromptEmailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClosePromptEmail;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/generate_dean_list_cert;component/promptemailwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PromptEmailWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EmailMessage = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\PromptEmailWindow.xaml"
            this.EmailMessage.GotFocus += new System.Windows.RoutedEventHandler(this.EmailMessage_GotFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\PromptEmailWindow.xaml"
            this.EmailMessage.LostFocus += new System.Windows.RoutedEventHandler(this.EmailMessage_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ClosePromptEmail = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\PromptEmailWindow.xaml"
            this.ClosePromptEmail.Click += new System.Windows.RoutedEventHandler(this.ClosePromptEmail_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

