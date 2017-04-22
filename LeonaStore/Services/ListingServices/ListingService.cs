using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeonaStore;
using LeonaStore.Domain;
using Refit;

namespace ListingServices
{
	public class ListingService : IListingService
	{
		IListingService _listingService;

		public ListingService()
		{
			_listingService = RestService.For<IListingService>(API.REST_Endpoint);
		}

		public async Task<List<ListingItem>> GetAllListings()
		{
			return await _listingService.GetAllListings();
		}
	}
}
