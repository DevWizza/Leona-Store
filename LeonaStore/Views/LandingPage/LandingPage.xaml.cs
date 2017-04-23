using System;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LeonaStore.Views
{
	public partial class LandingPage : ContentPage, IDestructible
	{
		public LandingPage()
		{
			InitializeComponent();
		}

		public void Destroy()
		{
			Carousel.Behaviors.Clear();
			SkipLabel.Behaviors.Clear();
			ContinueButton.Behaviors.Clear();
		}
	}
}

