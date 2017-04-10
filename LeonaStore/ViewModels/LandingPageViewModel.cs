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

		public ICommand ReachedLastPageCommand { get; set; }

		public ICommand ViewTapCommand { get; set; }

		public LandingPageViewModel()
		{
			ReachedLastPageCommand = new Command(OnReachedLastPage);

			ViewTapCommand = new Command(OnViewTap);
		}

		void OnReachedLastPage()
		{
			
		}

		void OnViewTap()
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
						BackgroundColor = Color.Black,
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
