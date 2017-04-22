using System;
using System.Collections.Generic;

namespace LeonaStore.Domain
{
	public class ListingItem
	{
		public ListingItemType ListingItemType { get; set; }

		public ListingOwner ListingOwner { get; set; }

		public Price Price { get; set; }

		public string ProductDescription { get; set; }

		public string ProductName { get; set; }

		public string ProductBackground { get; set; }

		public IList<string> ListingImages { get; set; }

		public IList<string> PronouncedFeatures { get; set; }

		public ListingDifferentModels ListingModels { get; set; }
	}
}
