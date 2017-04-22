using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeonaStore.Domain;
using Refit;

namespace ListingServices
{
	public interface IListingService
	{
		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/d09966e6a2e5e7f4fda307f03fb4048cf29885fa/listingItems.json")]
		Task<List<ListingItem>> GetAllListings();

		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/d09966e6a2e5e7f4fda307f03fb4048cf29885fa/listingItems.json")]
		Task<ListingItem> GetListing(string productId);
	}
}