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
						Title = "Welcome To Slack",
						Image = "",
						BackgroundColor = Color.FromHex("e74c3c"),
						Description = "All your team communication in one place, instantly searchable"
					},
					new LandingPageTemplateModel
					{
						Title = "Welcome To Facebook",
						Image = "",
						BackgroundColor = Color.FromHex("1abc9c"),
						Description = "All your team communication in one place, instantly searchable"
					},
					new LandingPageTemplateModel
					{
						Title = "Welcome To Twitter",
						Image = "",
						BackgroundColor = Color.FromHex("f39c12"),
						Description = "All your team communication in one place, instantly searchable"
					}
				};
			}
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
