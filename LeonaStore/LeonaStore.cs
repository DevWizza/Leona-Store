using System;
using Xamarin.Forms;

namespace LeonaStore
{
	public class Screens
	{ 
		public static readonly string SplashScreen = "SplashPage";
		public static readonly string LandingPage = "LandingPage";
		public static readonly string ProductListing = "ProductListing";
		public static readonly string ListingDetail = "ListingDetail";
		public static readonly string PickAColor = "PickAColor";
		public static readonly string SearchPage = "SearchPage";
		public static readonly string AbsoluteURI = "http://www.devwizza.com";
	}

	public class ScreensNavigationParameters
	{
		public static readonly string SelectedColor = "ColorSelected";
		public static readonly string ProductId = "ProductId";
	}

	public class CacheSetup
	{
		public static readonly string AppName = "LeonaStoreCache";
	}

	public class CacheKeys
	{
		public static readonly string NewUserKey = "NewUserKey";
	}

	public class AppColors
	{
		public static readonly Color BrandingColor = Color.FromHex("e74c3c");
	}

	public class API
	{
		public static readonly string REST_Endpoint = "https://gist.githubusercontent.com/";
	}
}
