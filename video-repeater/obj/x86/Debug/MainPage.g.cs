﻿#pragma checksum "C:\Users\tacin\documents\visual studio 2017\Projects\video-repeater\video-repeater\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D96EC322545E4E4C97AF2AA4E28178A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoRepeater
{
    partial class MainPage : 
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
                    this.mySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.MenuItemListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 28 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.MenuItemListView).ItemClick += this.MenuItemListView_ItemClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.ListBoxItem = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                }
                break;
            case 4:
                {
                    this.ListBoxItem1 = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                }
                break;
            case 5:
                {
                    this.CloudInfo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.recordInfo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.mediaLibrary = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.HamburgerBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerBtn).Click += this.HamburgerBtn_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.mainPageFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

