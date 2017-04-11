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

		public int CarouselPosition { get; set; }

		public LandingPageViewModel()
		{
			
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
						BackgroundColor = Color.FromHex("e74c3c"),
						Description = "Buy and Sell as never seen before"
					},
					new LandingPageTemplateModel
					{
						Title = "Modern and Responsive",
						Image = "modern",
						BackgroundColor = Color.FromHex("1abc9c"),
						Description = "All your favorite items in one place, instantly searchable"
					},
					new LandingPageTemplateModel
					{
						Title = "Ready to awesome up?",
						Image = "ready",
						BackgroundColor = Color.FromHex("f39c12"),
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
