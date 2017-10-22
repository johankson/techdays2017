using System;
using System.Linq;
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
                if (Element is Entry e)
                {
                    if (e.Text.Length > 8)
                    {
                        Control.BackgroundColor = UIColor.FromRGB(255, 0, 0);

                        if(!Control.Subviews.OfType<UIVisualEffectView>().Any())
                        {
                            var blur = UIBlurEffect.FromStyle(UIBlurEffectStyle.Light);
                            var visualEffectView = new UIVisualEffectView(blur);
                            visualEffectView.Frame = Control.Bounds;
                            visualEffectView.Alpha = 0.7f;
                            Control.Add(visualEffectView);
						}
                    }
                    else
                    {
                        Control.BackgroundColor = UIColor.FromRGB(255, 255, 255);
                        foreach(var s in Control.Subviews.OfType<UIVisualEffectView>())
                        {
                            s.RemoveFromSuperview();
                        }
                    }
                }
            }
        }
    }
}
