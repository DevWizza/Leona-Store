using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using LeonaStore.Components.Gesturator.Template.LandingPage;
using System.Windows.Input;
using Xamarin.Forms;

namespace LeonaStore.ViewModels
{
	public class LandingPageViewModel : BindableBase, INavigationAware
	{
		public IList<LandingPageTemplateModel> PagesModelData { get; set; }

		public ICommand SkipLandingPage { get; set; }

		public int CarouselPosition { get; set; }

		readonly INavigationService _navigationService;

		public bool ShowSkip { get; set; }

		public ICommand PositionChangedCommand { get; set; }

		public LandingPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;

			SkipLandingPage = new Command(OnSkipLandingPage);

			PositionChangedCommand = new Command<int>(OnPositionChanged);

			ShowSkip = true;
		}

		void OnPositionChanged(int position)
		{
			ShowSkip = position != (PagesModelData.Count - 1);
		}

		async void OnSkipLandingPage()
		{
			await _navigationService.NavigateAsync($"NavigationPage/{Screens.ProductListing}");
		}

		void OnReachedLastPage()
		{
			
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (PagesModelData == null)
			{
				PagesModelData = new List<LandingPageTemplateModel>
				{
					new LandingPageTemplateModel
					{
						Title = "Welcome To Leona",
						Image = "pocket",
						BackgroundColor = AppColors.BrandingColor,
						Description = "Buy and Sell like never seen before"
					},
					new LandingPageTemplateModel
					{
						Title = "Modern and Responsive",
						Image = "modern",
						BackgroundColor = AppColors.BrandingColor,
						Description = "All your favorite items in one place, instantly searchable"
					},
					new LandingPageTemplateModel
					{
						Title = "Ready to awesome up?",
						Image = "ready",
						BackgroundColor = AppColors.BrandingColor,
						Description = "Hit that button below!"
					}
				};
			}
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
