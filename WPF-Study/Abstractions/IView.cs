using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study.Abstractions
{
    interface IView
    {
        string TextBox { get; set; }
        void GetRes(string text);
        string FileName { get; set; }


        event EventHandler OpenFile;
    }
}
