﻿#pragma checksum "..\..\StartGame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E613F59B1F7DA5C755DCA21DD19D5A7CA673A0811C6DEF8552DAF7B1D9321A12"
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
using TryItOutKarliCards;


namespace TryItOutKarliCards {
    
    
    /// <summary>
    /// StartGame
    /// </summary>
    public partial class StartGame : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox playerNameListBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newPlayerTextBok;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addNewPlayerButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\StartGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TryItOutKarliCards;component/startgame.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StartGame.xaml"
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
            this.playerNameListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 22 "..\..\StartGame.xaml"
            this.playerNameListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PlayerNameListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.newPlayerTextBok = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.addNewPlayerButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\StartGame.xaml"
            this.addNewPlayerButton.Click += new System.Windows.RoutedEventHandler(this.AddNewPlayerButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\StartGame.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
