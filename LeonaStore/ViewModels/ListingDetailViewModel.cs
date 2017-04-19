using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Like.ViewModels;

namespace LeonaStore.ViewModels
{
	public class ListingDetailViewModel : BindableBase, INavigationAware
	{
		public LikeViewModel LikeViewModel { get; set; }

		public ListingDetailViewModel(LikeViewModel likeViewModel)
		{
			LikeViewModel = likeViewModel;
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
