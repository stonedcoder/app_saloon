﻿#pragma checksum "C:\Users\Desmond\Documents\Visual Studio 2015\Projects\Personal\C#\Universal\Truudus\Truudus\Pages\makeComment.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C69371916ACCA7BE471E05428D335BB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Truudus.Pages
{
    partial class makeComment : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.starField = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.commentBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.makeCommentButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\Pages\makeComment.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.makeCommentButton).Click += this.makeCommentButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\Pages\makeComment.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back).Click += this.back_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

