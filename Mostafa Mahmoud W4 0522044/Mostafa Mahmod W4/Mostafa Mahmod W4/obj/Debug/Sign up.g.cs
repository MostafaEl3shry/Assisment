﻿#pragma checksum "..\..\Sign up.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA9F336FEAA3A450965AD7C2D831E9D765BD52E00EBE48D5925698E60E270B04"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mostafa_Mahmod_W4;
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


namespace Mostafa_Mahmod_W4 {
    
    
    /// <summary>
    /// Sign_up
    /// </summary>
    public partial class Sign_up : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\Sign up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usertxt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Sign up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passtxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Sign up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox agetxt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Sign up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phonetxt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Sign up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logbtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Sign up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signbtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Sign up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Sign up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboc;
        
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
            System.Uri resourceLocater = new System.Uri("/Mostafa Mahmod W4;component/sign%20up.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sign up.xaml"
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
            this.usertxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.passtxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\Sign up.xaml"
            this.passtxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.passtxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.agetxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.phonetxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.logbtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Sign up.xaml"
            this.logbtn.Click += new System.Windows.RoutedEventHandler(this.logbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.signbtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Sign up.xaml"
            this.signbtn.Click += new System.Windows.RoutedEventHandler(this.signbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.comboc = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

