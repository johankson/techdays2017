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
      //      ClickBox.GestureRecognizers.Add(new TapGestureRecognizer()
      //      {
      //          Command = new Command(() => {
      //              if (AnimationView.IsPlaying)
      //              {
      //                  return;
      //              }

      //              if (AnimationView.Progress < 0.1)
      //              {
						//this.Animate("forward", (d) => AnimationView.Progress = (float)d, 0, 0.2, 60, 500); 
            //        }
            //        else
            //        {
            //            this.Animate("backward", (d) => AnimationView.Progress = (float)d, 0.2, 0, 60, 500); 
            //        }
            //    })
            //});
        }
    }
}
