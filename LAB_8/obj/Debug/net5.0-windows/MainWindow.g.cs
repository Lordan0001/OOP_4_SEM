﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ECB61F04B0D267025A4A00911D717851DC66D27"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Rock_shop;
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


namespace Rock_shop {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock First;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock More;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BraceleteBlock;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RingBlock;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PosterBlock;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MainCategories;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock labelWeAreChaos;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock labelHeaven;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Language;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.16.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Rock-shop;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.16.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.First = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.More = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BraceleteBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 53 "..\..\..\MainWindow.xaml"
            this.BraceleteBlock.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_Bracelet);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\MainWindow.xaml"
            this.BraceleteBlock.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\MainWindow.xaml"
            this.BraceleteBlock.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BraceleteBlock_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RingBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.RingBlock.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_Ring);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.RingBlock.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter_1);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.RingBlock.MouseLeave += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PosterBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.PosterBlock.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_Poster);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.PosterBlock.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter_2);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.PosterBlock.MouseLeave += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseLeave_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainCategories = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.labelWeAreChaos = ((System.Windows.Controls.TextBlock)(target));
            
            #line 67 "..\..\..\MainWindow.xaml"
            this.labelWeAreChaos.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_PreviewMouseDown_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.labelHeaven = ((System.Windows.Controls.TextBlock)(target));
            
            #line 68 "..\..\..\MainWindow.xaml"
            this.labelHeaven.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_PreviewMouseDown_2);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 69 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_PreviewMouseDown_3);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 70 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_PreviewMouseDown_4);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 71 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_PreviewMouseDown_5);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 72 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_PreviewMouseDown_6);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Language = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\MainWindow.xaml"
            this.Language.Click += new System.Windows.RoutedEventHandler(this.Language_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

