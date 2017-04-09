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

		public SplashPageViewModel(INavigationService navigationService)
		{
			_navigationSevice = navigationService;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{

		}
	}
}
