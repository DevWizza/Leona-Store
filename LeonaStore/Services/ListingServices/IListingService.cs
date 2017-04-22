using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeonaStore.Domain;
using Refit;

namespace ListingServices
{
	public interface IListingService
	{
		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/6be896a249f89628676c6df8488464ac1cb42fe4/listingItems.json")]
		Task<List<ListingItem>> GetAllListings();

		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/6be896a249f89628676c6df8488464ac1cb42fe4/listingItems.json")]
		Task<ListingItem> GetListing(string productId);
	}
}