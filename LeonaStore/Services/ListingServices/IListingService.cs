using System;
namespace ListingServices
{
	public interface IListingService
	{
		Task<ListItem> GetRecentListings();
	}
}
