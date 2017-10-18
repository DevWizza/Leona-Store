using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using LeonaStore.Domain;
using System.Collections.Generic;
using ListingServices;
using System.Threading.Tasks;
using System;

namespace LeonaStore.ViewModels
	{
		public class ProductListingViewModel : BindableBase, INavigationAware
		{
			public string Title { get; set; }

			public Color BackgroundColor { get; set; }

			public IList<ListingItem> Articles { get; set; }

			public ICommand RefreshListingCommand { get; set; }

			public ICommand ListingSelectedCommand { get; set; }

			public bool IsRefreshingListing { get; set; }

			readonly INavigationService _navigationService;
			
			readonly IListingService _listingService;

			public ListingItem ItemSelected { get; set; }

			public ProductListingViewModel(INavigationService navigationService,
		                                   IListingService listingService)
			{
				_listingService = listingService;

				_navigationService = navigationService;
				
				RefreshListingCommand = new Command(async()=> await OnRefreshListing());

				ListingSelectedCommand = new Command<ListingItem>(OnListingSelected);
			}

			async void OnListingSelected(ListingItem item)
			{
				if (item == null)
					return;

				await _navigationService.NavigateAsync($"{Screens.ListingDetail}",
			                                       new NavigationParameters($"{ScreensNavigationParameters.ProductId}={item.ProductName}"));

				ItemSelected = null;
			}

			public void OnNavigatedFrom(NavigationParameters parameters)
			{
				
			}

			async Task OnRefreshListing()
			{
				IsRefreshingListing = true;

				Articles = await _listingService.GetAllListings();

				IsRefreshingListing = false;
			}

			public async void OnNavigatedTo(NavigationParameters parameters)
			{
				Title = "Leona Store";

				BackgroundColor = Color.FromHex("F5F5F5");

				if(Articles == null)
					await OnRefreshListing();

				object productId;

				if (parameters.TryGetValue(ScreensNavigationParameters.ProductId, out productId))
				{
					await _navigationService.NavigateAsync($"{Screens.ListingDetail}",
				                                           new NavigationParameters($"{ScreensNavigationParameters.ProductId}={productId}"));
				}
			}

			public void OnNavigatingTo(NavigationParameters parameters)
			{
				
			}
		}
	}