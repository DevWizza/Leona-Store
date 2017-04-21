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

namespace LeonaStore.ViewModels
{
	public class ListingDetailViewModel : BindableBase, INavigationAware
	{
		public LikeViewModel LikeViewModel { get; set; }

		public string ChangeColorText { get; set; }

		public string SelectedColor { get; set; }

		public ICommand ChangeColorCommand { get; set; }

		readonly INavigationService _navigationService;

		readonly IPageDialogService _dialogService;

		public ListingDetailViewModel(LikeViewModel likeViewModel, 
		                              INavigationService navigationService,
		                              IPageDialogService dialogService)
		{
			this._dialogService = dialogService;
			_navigationService = navigationService;

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

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
	}
}
