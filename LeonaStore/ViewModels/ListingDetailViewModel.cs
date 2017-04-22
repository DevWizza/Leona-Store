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
		}

		async void OnChangeColor()
		{
			var modelList = new List<IActionSheetButton>();

			foreach (var model in SelectedListingItem.ListingModels.ListingModels)
			{
				modelList.Add(ActionSheetButton.CreateButton(model, () => OnModelSelected(model)));
			}

			await _dialogService.DisplayActionSheetAsync($"Select {SelectedListingItem.ListingModels.ModelType}", modelList.ToArray());
		}

		public void OnModelSelected(string model) {
			SelectedColor = model;
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

				ChangeColorText = $"Change {SelectedListingItem.ListingModels.ModelType}";

				SelectedColor = SelectedListingItem.ListingModels?.ListingModels.FirstOrDefault();
			}
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
	}
}
