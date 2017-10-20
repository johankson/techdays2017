using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace demo
{
    public partial class AnimationPage : ContentPage
    {
        public AnimationPage()
        {
            InitializeComponent();

            Rotate.Clicked += async (sender, e) => {
                await Box.RotateTo(Box.Rotation + 90);
            };

            MoveUp.Clicked += async (sender, e) => {
                await Box.TranslateTo(Box.TranslationX, Box.TranslationY - 30, 500, Easing.SpringOut);
            };

            MoveDown.Clicked += async (sender, e) => {
                await Box.TranslateTo(Box.TranslationX, Box.TranslationY + 30, 500, Easing.SpringOut);
            };
            ScaleUp.Clicked += async (sender, e) => {
                await Box.ScaleTo(Box.Scale * 1.5, 700);
            };
        }
    }
}
