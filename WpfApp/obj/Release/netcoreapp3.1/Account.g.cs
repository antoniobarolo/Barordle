﻿#pragma checksum "..\..\..\Account.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C004680EFD6DA218247970B5C9A878A7FC1F93F"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfApp;


namespace WpfApp {
    
    
    /// <summary>
    /// Account
    /// </summary>
    public partial class Account : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LoginTitle;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nome;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginText;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SignUpTitle;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signupButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SignUpText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp;component/account.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Account.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoginTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.nome = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.loginButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Account.xaml"
            this.loginButton.Click += new System.Windows.RoutedEventHandler(this.loginButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LoginText = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Account.xaml"
            this.LoginText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GuessText_TextChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Account.xaml"
            this.LoginText.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SignUpTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.signupButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Account.xaml"
            this.signupButton.Click += new System.Windows.RoutedEventHandler(this.signupButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SignUpText = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Account.xaml"
            this.SignUpText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GuessText_TextChanged);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\Account.xaml"
            this.SignUpText.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
