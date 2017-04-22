using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Like.ViewModels;
using Xamarin.Forms;
using System.Windows.Input;
using Prism.Services;
using System.Collections;
using ListingServices;
using LeonaStore.Domain;

namespace LeonaStore.ViewModels
{
	public class ListingDetailViewModel : BindableBase, INavigationAware
	{
		public ICommand ChangeColorCommand { get; set; }

		readonly IPageDialogService _dialogService;

		readonly IListingService _listingService;

		public LikeViewModel LikeViewModel { get; set; }

		public ListingItem SelectedListingItem { get; set; }

		public string ChangeColorText { get; set; }

		public string SelectedColor { get; set; }

		public int CarouselPosition { get; set; }

		public ListingDetailViewModel(LikeViewModel likeViewModel,
		                              IPageDialogService dialogService,
		                              IListingService listingService)
		{
			_listingService = listingService;

			_dialogService = dialogService;

			LikeViewModel = likeViewModel;

			ChangeColorCommand = new Command(OnChangeColor);

			ChangeColorText = "Change Color";

			SelectedColor = "Black";
		}

		async void OnChangeColor()
		{
			await _dialogService.DisplayActionSheetAsync("Device Color",
			                                             ActionSheetButton.CreateButton("Pink", () => OnColorSelected("Pink")),
			                                            ActionSheetButton.CreateButton("Blue", () => OnColorSelected("Blue")),
			                                            ActionSheetButton.CreateButton("Red", () => OnColorSelected("Red")));
		}

		public void OnColorSelected(string color) {
			SelectedColor = color;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public async void OnNavigatedTo(NavigationParameters parameters)
		{
			object productId = null;

			if (parameters.TryGetValue(ScreensNavigationParameters.ProductId, out productId))
			{
				SelectedListingItem = await _listingService.GetListing(productId as string);
			}
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
	}
}
