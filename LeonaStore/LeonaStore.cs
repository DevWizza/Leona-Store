using System;
using Xamarin.Forms;

namespace LeonaStore
{
	public class Screens
	{
		public static readonly string SplashPage = nameof(SplashPage);
		public static readonly string LandingContentPage = nameof(LandingContentPage);
		public static readonly string ProductListing = nameof(ProductListing);
		public static readonly string ListingDetail = nameof(ListingDetail);
		public static readonly string PickAColor = nameof(PickAColor);
		public static readonly string SearchPage = nameof(SearchPage);
		public static readonly string MoreApps = nameof(MoreApps);
		public static readonly string LeonaNavigationPage = nameof(LeonaNavigationPage);
		public static readonly string MasterDetailContainer = nameof(MasterDetailContainer);
        public static readonly string NotReadyYetPage = nameof(NotReadyYetPage);
		public static readonly string AbsoluteURI = "http://www.devwizza.com";
	}

	public class ScreensNavigationParameters
	{
		public static readonly string SelectedColor = nameof(SelectedColor);
		public static readonly string ProductId = nameof(ProductId);
	}

	public class CacheSetup
	{
		public static readonly string AppName = "LeonaStoreCache";
	}

	public class CacheKeys
	{
		public static readonly string NewUserKey = nameof(NewUserKey);
	}

	public class API
	{
		public static readonly string REST_Endpoint = "https://gist.githubusercontent.com/";
	}
}
