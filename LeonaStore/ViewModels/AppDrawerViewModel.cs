using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using AppDrawerItems;

namespace ViewModels.ViewModels
{
	public class AppDrawerViewModel : BindableBase, INavigationAware
	{
		public IList<DrawerItem> DrawerItems { get; set; }

		public AppDrawerViewModel()
		{

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (DrawerItems == null)
				DrawerItems = new List<DrawerItem>()
				{
					new DrawerItem
					{
						Text = "Home",
						Icon = "ic_home_black_24dp"
					},
					new DrawerItem
					{
						Text = "Categories",
						Icon = "ic_subject_black_24dp"
					},
					new DrawerItem
					{
						Text = "Today's Deals",
						Icon = "ic_trending_up_black_24dp"
					},
					new DrawerItem
					{
						Text = "Your Orders",
						Icon = "ic_list_black_24dp",
						ShowSeparatorAfter = true
					},
					new DrawerItem
					{
						Text = "Customer Service",
						Icon = "ic_help_black_24dp"
					},
					new DrawerItem
					{
						Text = "More Apps",
						Icon = "ic_info_black_24dp"
					},
					new DrawerItem
					{
						Text = "Settings",
						Icon = "ic_settings_black_24dp"
					}
				};
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
