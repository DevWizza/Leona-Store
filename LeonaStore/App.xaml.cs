using Prism.Unity;
using LeonaStore.Views;
using Xamarin.Forms;
using Prism.Navigation;
using Microsoft.Practices.Unity;
using LeonaStore.Views.Home;
using Like.ViewModels;
using ListingServices;

namespace LeonaStore
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync($"{Screens.SplashScreen}");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<SplashPage>();
			Container.RegisterTypeForNavigation<LandingPage>();
			Container.RegisterTypeForNavigation<ProductListing>();
			Container.RegisterTypeForNavigation<ListingDetail>();
			Container.RegisterTypeForNavigation<SearchPage>();

			Container.RegisterType<LikeViewModel>();

			Container.RegisterType(typeof(ICache), typeof(AkavacheImpl));
			Container.RegisterType(typeof(IListingService), typeof(ListingService));
		}
	}
}