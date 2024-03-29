﻿#pragma checksum "..\..\..\..\..\MVVM\View\LoginView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C85F5E2E5DAC9D922F2B680D9930CF42AC89F056"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Desktop.MVVM.ViewModel;
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


namespace Desktop.MVVM.View {
    
    
    /// <summary>
    /// LoginView
    /// </summary>
    public partial class LoginView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\..\..\MVVM\View\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginBox;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\MVVM\View\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\..\MVVM\View\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ForgotPasswordLabel;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\..\MVVM\View\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\..\MVVM\View\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LoginButton;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\..\..\MVVM\View\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GoToSignUpPage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Desktop;component/mvvm/view/loginview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            ((Desktop.MVVM.View.LoginView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.LoginView_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            this.LoginBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LoginBox_OnTextChanged);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            this.LoginBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.LoginBox_OnKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 109 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            this.PasswordBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.PassBox_OnPasswordChanged);
            
            #line default
            #line hidden
            
            #line 110 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            this.PasswordBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.PassBox_OnKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ForgotPasswordLabel = ((System.Windows.Controls.Label)(target));
            
            #line 151 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            this.ForgotPasswordLabel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ForgotPasswordLabel_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ErrorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.LoginButton = ((System.Windows.Controls.Border)(target));
            
            #line 163 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            this.LoginButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.LoginButton_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GoToSignUpPage = ((System.Windows.Controls.Label)(target));
            
            #line 202 "..\..\..\..\..\MVVM\View\LoginView.xaml"
            this.GoToSignUpPage.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GoToSignUpPage_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

