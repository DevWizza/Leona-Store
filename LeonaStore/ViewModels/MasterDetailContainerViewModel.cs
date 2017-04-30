using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using ViewModels.ViewModels;

namespace LeonaStore.ViewModels
{
	public class MasterDetailContainerViewModel : BindableBase, INavigationAware
	{
		public AppDrawerViewModel AppDrawerViewModel { get; set; }

		public MasterDetailContainerViewModel(AppDrawerViewModel drawerViewModel)
		{
			AppDrawerViewModel = drawerViewModel;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			AppDrawerViewModel.OnNavigatedFrom(parameters);
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			AppDrawerViewModel.OnNavigatedTo(parameters);
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			AppDrawerViewModel.OnNavigatingTo(parameters);
		}
	}
}
