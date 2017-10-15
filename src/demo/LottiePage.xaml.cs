using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace demo
{
    public partial class LottiePage : ContentPage
    {
        public LottiePage()
        {
            InitializeComponent();
            TheButton.Clicked += (sender, e) => AnimationView.Play();
        }
    }
}
