﻿

#pragma checksum "C:\Users\Simon\Documents\_Dev\ExamensArbete\SiolRecieverPrototype\siolReciever\siolReciever.Windows\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AEDD4C40983B468660996F43AB404767"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace siolReciever
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 91 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.CheckBoxComplete_Checked;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 84 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ButtonRefresh_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 59 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SaveProfile_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 60 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.CloseProfile_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 38 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ButtonLogin_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 39 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ManageProfile_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 40 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ButtonSave_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

