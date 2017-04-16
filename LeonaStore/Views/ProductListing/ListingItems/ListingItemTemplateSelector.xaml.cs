using System;
using System.Collections.Generic;
using AnnouncementItem;
using BasicItem;
using Xamarin.Forms;

namespace LeonaStore.Views.Home.ListingItem
{
	public partial class ListingItemTemplateSelector : ViewCell
	{
		public ListingItemTemplateSelector()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			await View.FadeTo(1, 500, Easing.SinIn);
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			var bindingContext = (ListingItem)BindingContext;

			switch (bindingContext.ListingItemType)
			{
				case ListingItemType.Basic:
					View = new BasicItemView() { BindingContext = bindingContext };
					break;
				case ListingItemType.Announcement:
					View = new AnnouncementItemView() { BindingContext = bindingContext };
					break;
			}
		}
	}
}
