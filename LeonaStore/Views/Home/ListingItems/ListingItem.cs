using System;

namespace LeonaStore.Views.Home.ListingItem
{
	public class ListingItem
	{
		public ListingItemType ListingItemType { get; set; }

		public string BrandCompany { get; set; }

		public decimal Price { get; set; }

		public string ProductName { get; set; }

		public string HexadecimalBrandColor { get; set; }

		public string ProductBackground { get; set; }
	}
}
