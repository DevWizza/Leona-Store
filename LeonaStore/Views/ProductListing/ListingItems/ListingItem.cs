using System;
using Xamarin.Forms;

namespace LeonaStore.Views.Home.ListingItem
{
	public class ListingItem
	{
		public ListingItemType ListingItemType { get; set; }

		public string BrandCompany { get; set; }

		public double Price { get; set; }

		public string ProductName { get; set; }

		public Color BrandColor { get; set; }

		public string ProductBackground { get; set; }
	}
}
