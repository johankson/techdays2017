using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace demo.Controls
{
    public class OptionsControl : View
    {
        public static BindableProperty OptionsProperty = BindableProperty.Create("Options", typeof(List<string>), typeof(OptionsControl));

        public List<string> Options
        {
            get { return GetValue(OptionsProperty) as List<string>; }
            set { SetValue(OptionsProperty, value); }
        }
    }
}
