using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LeonaStore.ViewModels
{
	public class MoreAppsViewModel : BindableBase, INavigationAware
	{
		public ICommand SendEmailToLuisCommand { get; set; }

		public MoreAppsViewModel()
		{
			SendEmailToLuisCommand = new Command(OnSendEmailToLuis);
		}

		void OnSendEmailToLuis()
		{
			Device.OpenUri(new Uri("mailto:luis.pena.nunez.developer@gmail.com"));
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