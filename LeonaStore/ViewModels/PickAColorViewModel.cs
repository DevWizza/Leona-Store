using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Xamarin.Forms;
using System.Windows.Input;

namespace LeonaStore.ViewModels
{
	public class PickAColorViewModel : BindableBase, INavigationAware
	{
		public IList<Color> Colors { get; set; }

		public Color SelectedColor { get; set; }

		public ICommand ListingSelectedCommand { get; set; }

		readonly INavigationService _navigationService;

		public PickAColorViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;

			ListingSelectedCommand = new Command(OnListingSelected);
		}

		void OnListingSelected()
		{
			var navigationParameters = new NavigationParameters();
			navigationParameters.Add(ScreensNavigationParameters.SelectedColor, SelectedColor.ToString());
			_navigationService.NavigateAsync($"{Screens.ListingDetail}", navigationParameters);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			Colors = new List<Color>
			{
				Color.Accent,
				Color.AntiqueWhite,
				Color.Azure,
				Color.Bisque,
				Color.LightSteelBlue,
				Color.DarkOliveGreen,
			};
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
