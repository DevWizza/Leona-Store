using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Collections.ObjectModel;
using LeonaStore.Views.Home.ListingItem;

namespace LeonaStore.ViewModels
{
	public class HomeViewModel : BindableBase, INavigationAware
	{

		public ObservableCollection<ListingItem> Articles { get; set; }

		public HomeViewModel()
		{

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			Articles = new ObservableCollection<ListingItem>
			{
				new ListingItem()
				{
					
				}
			};
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
