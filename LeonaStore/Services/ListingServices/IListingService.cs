using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeonaStore.Domain;
using Refit;

namespace ListingServices
{
	public interface IListingService
	{
		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/7a0d982feae97cb132f6635003bc2eb0038ddf87/listingItems.json")]
		Task<List<ListingItem>> GetAllListings();

		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/7a0d982feae97cb132f6635003bc2eb0038ddf87/listingItems.json")]
		Task<ListingItem> GetListing(string productId);
	}
}