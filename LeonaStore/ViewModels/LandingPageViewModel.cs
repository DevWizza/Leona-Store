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
	public class LandingContentPageViewModel : BindableBase, INavigationAware
	{
		public IList<LandingPageTemplateModel> PagesModelData { get; set; }

		public ICommand SkipLandingPage { get; set; }

		public int CarouselPosition { get; set; }

		readonly INavigationService _navigationService;

		public bool ShowSkip { get; set; }

		public bool ShowContinueButton { get; set; }

		public ICommand PositionChangedCommand { get; set; }

		public Color BackgroundColor { get; set; }

		public LandingContentPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;

			SkipLandingPage = new Command(OnSkipLandingPage);

			PositionChangedCommand = new Command<int>(OnPositionChanged);

			ShowSkip = true;
		}

		void OnPositionChanged(int position)
		{
			ShowSkip = position != (PagesModelData.Count - 1);

			ShowContinueButton = position == (PagesModelData.Count - 1);
		}

		async void OnSkipLandingPage()
		{
			await _navigationService.NavigateAsync(new Uri($"{Screens.AbsoluteURI}/{Screens.MasterDetailContainer}/{Screens.LeonaNavigationPage}/{Screens.ProductListing}", UriKind.Absolute));
		}

		void OnReachedLastPage()
		{
			
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			BackgroundColor = AppColors.BrandingColor;

			if (PagesModelData == null)
			{
				PagesModelData = new List<LandingPageTemplateModel>
				{
					new LandingPageTemplateModel
					{
						Title = "Welcome To Leona",
						Image = "pocket",
						Description = "Buy and Sell like never seen before"
					},
					new LandingPageTemplateModel
					{
						Title = "Modern and Responsive",
						Image = "modern",
						Description = "All your favorite items in one place, instantly searchable"
					},
					new LandingPageTemplateModel
					{
						Title = "Ready to awesome up?",
						Image = "ready",
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
