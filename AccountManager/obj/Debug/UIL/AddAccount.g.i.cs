﻿#pragma checksum "..\..\..\UIL\AddAccount.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3D618DFDE5BA836AE77EFC1F8096F098"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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
using Xceed.Wpf.Toolkit;


namespace AccountManager.UIL {
    
    
    /// <summary>
    /// AddAccount
    /// </summary>
    public partial class AddAccount : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\UIL\AddAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox Login_WTB;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UIL\AddAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox Password_WTB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UIL\AddAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox Domain_WTB;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\UIL\AddAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox SiteName_WTB;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UIL\AddAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryList_CB;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UIL\AddAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox Description_WTB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UIL\AddAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCount_B;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountManager;component/uil/addaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIL\AddAccount.xaml"
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
            this.Login_WTB = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            
            #line 13 "..\..\..\UIL\AddAccount.xaml"
            this.Login_WTB.LostFocus += new System.Windows.RoutedEventHandler(this.Login_WTB_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Password_WTB = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            
            #line 14 "..\..\..\UIL\AddAccount.xaml"
            this.Password_WTB.LostFocus += new System.Windows.RoutedEventHandler(this.Password_WTB_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Domain_WTB = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            
            #line 15 "..\..\..\UIL\AddAccount.xaml"
            this.Domain_WTB.LostFocus += new System.Windows.RoutedEventHandler(this.Domain_WTB_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SiteName_WTB = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            
            #line 16 "..\..\..\UIL\AddAccount.xaml"
            this.SiteName_WTB.LostFocus += new System.Windows.RoutedEventHandler(this.SiteName_WTB_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CategoryList_CB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\UIL\AddAccount.xaml"
            this.CategoryList_CB.Loaded += new System.Windows.RoutedEventHandler(this.CategoryList_CB_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Description_WTB = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            return;
            case 7:
            this.AddCount_B = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\UIL\AddAccount.xaml"
            this.AddCount_B.Click += new System.Windows.RoutedEventHandler(this.AddCount_B_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
