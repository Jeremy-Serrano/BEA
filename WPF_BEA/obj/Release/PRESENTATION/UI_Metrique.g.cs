﻿#pragma checksum "..\..\..\PRESENTATION\UI_Metrique.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D52B7E06F82837DF3F1A0DBD60C133FF6A5AE2DEBD443C6D81804012C2AE185"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WPF_BEA.PRESENTATION;


namespace WPF_BEA.PRESENTATION {
    
    
    /// <summary>
    /// UI_Metrique
    /// </summary>
    public partial class UI_Metrique : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\PRESENTATION\UI_Metrique.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXB_Nom;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\PRESENTATION\UI_Metrique.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXB_ObjetIllu;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\PRESENTATION\UI_Metrique.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXB_Valeur;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\PRESENTATION\UI_Metrique.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Update;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_BEA;component/presentation/ui_metrique.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PRESENTATION\UI_Metrique.xaml"
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
            this.TXB_Nom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TXB_ObjetIllu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TXB_Valeur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BTN_Update = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\PRESENTATION\UI_Metrique.xaml"
            this.BTN_Update.Click += new System.Windows.RoutedEventHandler(this.BTN_Update_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

