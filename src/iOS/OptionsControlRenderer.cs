using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using demo.Controls;
using System.ComponentModel;
using Xamarin.Forms;
using demo.iOS;

[assembly:ExportRenderer(typeof(OptionsControl) , typeof(OptionsControlRenderer))]
namespace demo.iOS
{
    public class OptionsControlRenderer : ViewRenderer<OptionsControl, UISegmentedControl>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<OptionsControl> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var control = new UISegmentedControl();
                control.SizeToFit();

                SetNativeControl(control); 
            }

            Update();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName == OptionsControl.OptionsProperty.PropertyName)
            {
                Update();
            }
        }

        private void Update()
        {
            Control.RemoveAllSegments();

            for (int i = 0; i < Element.Options.Count; i++)
            {
                Control.InsertSegment(Element.Options[i], i, true);
            }

            Control.SelectedSegment = 0;
        }
    }
}