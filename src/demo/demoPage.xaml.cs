﻿using Xamarin.Forms;

namespace demo
{
    public partial class demoPage : ContentPage
    {
        public demoPage()
        {
            InitializeComponent();
            this.lottieButton.Clicked += (sender, e) => Navigation.PushAsync(new LottiePage());
            this.AnimationButton.Clicked += (sender, e) => Navigation.PushAsync(new AnimationPage());
        }
    }
}
