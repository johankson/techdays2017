using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RenderersDemo : ContentPage
	{
		public RenderersDemo ()
		{
			InitializeComponent ();

            Select.Options = new List<string>() { "Developer", "IT-Pro" };
		}
	}
}