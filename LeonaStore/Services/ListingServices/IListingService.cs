using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeonaStore.Domain;
using Refit;

namespace ListingServices
{
	public interface IListingService
	{
		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/4a69600bc6a1999857dabdb542bcef3dd2e1099a/listingItems.json")]
		Task<List<ListingItem>> GetAllListings();

		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/4a69600bc6a1999857dabdb542bcef3dd2e1099a/listingItems.json")]
		Task<ListingItem> GetListing(string productId);
	}
}