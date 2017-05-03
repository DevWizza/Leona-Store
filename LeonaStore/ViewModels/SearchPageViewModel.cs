using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using LeonaStore.Domain;
using ListingServices;
using Prism.Navigation;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LeonaStore.ViewModels
{
	public class SearchPageViewModel : BindableBase, INavigationAware
	{
		public IList<ListingItem> Articles { get; set; }

		public ListingItem ItemSelected { get; set; }

		public ICommand NavigateBackCommand { get; set; }

		readonly IListingService _listingService;

		readonly INavigationService _navigationService;

		public ICommand PerformSearchCommand { get; set; }

		public ICommand NavigateToListingDetailCommand { get; set; }

		public bool IsLoading { get; set; }

		public string SearchQuery { get; set; }

		public bool CouldntFindAnyResultFromTheSearch { get; set; }

		public SearchPageViewModel(IListingService listingService,
		                           INavigationService navigationService)
		{
			_navigationService = navigationService;

			_listingService = listingService;

			NavigateBackCommand = new Command(OnNavigateBack);

			PerformSearchCommand = new Command(async()=> await OnPerformSearch());

			NavigateToListingDetailCommand = new Command<ListingItem>(OnNavigateToListingDetail);
		}

		async void OnNavigateToListingDetail(ListingItem item)
		{
			if (item == null)
					return;
			
			await _navigationService.GoBackAsync(new NavigationParameters($"{ScreensNavigationParameters.ProductId}={item.ProductName}"));

			ItemSelected = null;
		}

		async Task OnPerformSearch()
		{
			CouldntFindAnyResultFromTheSearch = false;

			Articles = null;

			IsLoading = true;

			var anyListingsFound = await _listingService.GetListingsByTitle(SearchQuery);

			Articles = anyListingsFound;

			CouldntFindAnyResultFromTheSearch = Articles == null;

			IsLoading = false;
		}

		async void OnNavigateBack()
		{
			await _navigationService.GoBackAsync(useModalNavigation: true);
		}

		async Task OnRefreshListing()
		{
			IsLoading = true;

			Articles = await _listingService.GetAllListings();

			IsLoading = false;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public async void OnNavigatedTo(NavigationParameters parameters)
		{
			await OnRefreshListing();
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
