﻿

#pragma checksum "C:\Users\cpetchim\Documents\workspace\workspace-universalapp\Universal Windows app samples\File access sample\C#\Shared\Scenario5_WriteAndReadAFileUsingAStream.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DDAC83E0607FC213E83594907DF4030D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileAccess
{
    partial class Scenario5 : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock StatusBlock; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox InputTextBox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button WriteToStreamButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button ReadFromStreamButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Scenario5_WriteAndReadAFileUsingAStream.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("StatusBlock");
            InputTextBox = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("InputTextBox");
            WriteToStreamButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("WriteToStreamButton");
            ReadFromStreamButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("ReadFromStreamButton");
        }
    }
}



