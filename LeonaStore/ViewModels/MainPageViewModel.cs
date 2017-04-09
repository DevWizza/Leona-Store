using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeonaStore.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		public string Title { get; set; }

		readonly INavigationService _navService;

		public MainPageViewModel(INavigationService navService)
		{
			_navService = navService;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			_navService.NavigateAsync("SplashPage");
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}

