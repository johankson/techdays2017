using System;
using demo.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("EvilCorp")]
[assembly: ExportEffect(typeof(AwesomeEffect), "AwesomeEffect")]

namespace demo.iOS.Effects
{
    public class AwesomeEffect : PlatformEffect
    {

        protected override void OnAttached()
        {
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == "Text")
            {
               if(Element is Entry e)
                {
                    if (e.Text.Length > 8)
                    {
                        Control.BackgroundColor = UIColor.FromRGB(255, 0, 0);
                    }
                    else
                    {
                        Control.BackgroundColor = UIColor.FromRGB(255, 255, 255);
                    }
                }
            }
        }
    }
}
