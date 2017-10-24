using Xamarin.Forms;

namespace demo
{
    public partial class demoPage : ContentPage
    {
        public demoPage()
        {
            InitializeComponent();
            this.lottieButton.Clicked += (sender, e) => Navigation.PushAsync(new LottiePage());
            this.AnimationButton.Clicked += (sender, e) => Navigation.PushAsync(new AnimationPage());
            this.BehaviorButton.Clicked += (sender, e) => Navigation.PushAsync(new BehaviorPage());
            this.EffectButton.Clicked += (sender, e) => Navigation.PushAsync(new EffectPage());
            this.EmbeddedButton.Clicked += (sender, e) => Navigation.PushAsync(new EmbeddedControls());
        }
    }
}
