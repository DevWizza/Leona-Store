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

		public MainPageViewModel()
		{

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("title"))
				Title = (string)parameters["title"] + " and Prism";
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}

