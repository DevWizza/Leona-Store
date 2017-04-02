using Prism.Unity;
using LeonaStore.Views;
using Xamarin.Forms;

namespace LeonaStore
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync($"NavigationPage/{Screens.SplashScreen}");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<SplashPage>();
		}
	}
}

