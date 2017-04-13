using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Collections.ObjectModel;
using LeonaStore.Views.Home.ListingItem;
using Xamarin.Forms;

namespace LeonaStore.ViewModels
{
	public class ProductListingViewModel : BindableBase, INavigationAware
	{
		public string Title { get; set; }

		public ObservableCollection<ListingItem> Articles { get; set; }

		public ProductListingViewModel()
		{

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			Title = "Home";

			Articles = new ObservableCollection<ListingItem>
			{
				new ListingItem()
				{
					ProductName = "Chuck II Rio",
					Price = 34.12,
					ListingItemType = ListingItemType.Basic,
					BrandCompany = "Converse",
					HexadecimalBrandColor = Color.White.ToString(),
					ProductBackground = ""
				}
			};
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
