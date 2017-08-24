using System;
using System.Collections.Generic;

namespace LeonaStore.Domain
{
	public class ListingDifferentModels
	{
		public ListingModelType ModelType { get; set; }

		public IList<string> ListingModels { get; set; }
	}
}
