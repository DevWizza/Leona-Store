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

namespace LeonaStore.ViewModels
{
	public class ListingDetailViewModel : BindableBase, INavigationAware
	{
		public LikeViewModel LikeViewModel { get; set; }

		public string ChangeColorText { get; set; }

		public string SelectedColor { get; set; }

		public IList ListingImages { get; set; }

		public ICommand ChangeColorCommand { get; set; }

		public int CarouselPosition { get; set; }

		readonly INavigationService _navigationService;

		readonly IPageDialogService _dialogService;

		public IList<string> ListingFeature { get; set; }

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
			//ListingImages = new List<string>
			//{
			//	"http://pngbase.com/content/Electronics/Iphone%20Apple/5396.png",
			//	"http://www.pngall.com/wp-content/uploads/2016/06/IPhone-PNG-Picture-PNG-Image.png",
			//	"http://www.opusnetworks.co.uk/wp-content/uploads/2017/01/IPhone-7.png"
			//};

			//ListingFeature = new List<string>
			//{
			//	"128gb",
			//	"iOS10",
			//	"New",
			//	"Unlocked"
			//};
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
	}
}
