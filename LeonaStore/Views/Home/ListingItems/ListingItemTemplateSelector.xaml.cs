using System;
using System.Collections.Generic;
using LeonaStore.Views.ListingItem.AnnouncementItem;
using LeonaStore.Views.ListingItem.BasicItem;
using LeonaStore.Views.ListingItem.PremiumItem;
using Xamarin.Forms;

namespace LeonaStore.Views.Home.ListingItem
{
	public partial class ListingItemTemplateSelector : StackLayout
	{
		public ListingItemTemplateSelector()
		{
			InitializeComponent();
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			var bindingContext = (ListingItem)BindingContext;

			switch (bindingContext.ListingItemType)
			{
				case ListingItemType.Basic:
					Children.Add(new BasicItem() { BindingContext = bindingContext });
					break;
				case ListingItemType.Announcement:
					Children.Add(new AnnouncementItem() { BindingContext = bindingContext });
					break;
				case ListingItemType.Premium:
					Children.Add(new PremiumItem() { BindingContext = bindingContext });
					break;
			}
		}
	}
}
