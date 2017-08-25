using System;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LeonaStore.Views
{
	public partial class LandingContentPage : ContentPage, IDestructible
	{
		public LandingContentPage()
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

