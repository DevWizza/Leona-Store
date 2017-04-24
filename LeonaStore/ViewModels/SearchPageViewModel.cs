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

		public SearchPageViewModel(IListingService listingService,
		                           INavigationService navigationService)
		{
			_navigationService = navigationService;

			_listingService = listingService;

			NavigateBackCommand = new Command(OnNavigateBack);
		}

		async void OnNavigateBack()
		{
			await _navigationService.GoBackAsync(useModalNavigation: true);
		}

		async Task OnRefreshListing()
		{
			Articles = await _listingService.GetAllListings();
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
