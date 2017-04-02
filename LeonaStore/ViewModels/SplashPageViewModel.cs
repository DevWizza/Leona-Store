using Prism.Mvvm;
using System;
using Prism.Navigation;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace LeonaStore.ViewModels
{
	public class SplashPageViewModel : BindableBase, INavigationAware
	{
		readonly INavigationService _navigationSevice;

		public SplashPageViewModel(INavigationService navigationSevice)
		{
			_navigationSevice = navigationSevice;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			Device.StartTimer(TimeSpan.FromSeconds(5), onTimerFireOff);
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{

		}

		bool onTimerFireOff()
		{
			Task.Run(async () => await _navigationSevice.NavigateAsync(Screens.MainPageScreen));

			return true;
		}
	}
}
