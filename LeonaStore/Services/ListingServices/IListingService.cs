using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeonaStore.Domain;
using Refit;

namespace ListingServices
{
	public interface IListingService
	{
		[Get("/LuisAlbertoPenaNunez/26bd329c9f4a8205f50e417b0ace3564/raw/39ce14b0d3f732b9b53b8041b6d1d6ff6bf462a7/listingItems.json")]
		Task<List<ListingItem>> GetAllListings();
	}
}