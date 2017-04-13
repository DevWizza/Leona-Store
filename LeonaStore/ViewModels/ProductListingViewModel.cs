	using Prism.Commands;
	using Prism.Mvvm;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Prism.Navigation;
	using System.Collections.ObjectModel;
	using LeonaStore.Views.Home.ListingItem;
	using Xamarin.Forms;

	namespace LeonaStore.ViewModels
	{
		public class ProductListingViewModel : BindableBase, INavigationAware
		{
			public string Title { get; set; }

			public Color BackgroundColor { get; set; }

			public ObservableCollection<ListingItem> Articles { get; set; }

			public ProductListingViewModel()
			{

			}

			public void OnNavigatedFrom(NavigationParameters parameters)
			{
				
			}

			public void OnNavigatedTo(NavigationParameters parameters)
			{
				Title = "Leona Store";

				BackgroundColor = Color.FromHex("F5F5F5");

				Articles = new ObservableCollection<ListingItem>
				{
					new ListingItem()
					{
						ProductName = "Chuck II Rio",
						Price = 34.12,
						ListingItemType = ListingItemType.Basic,
						BrandCompany = "Converse",
						BrandColor = Color.White,
						ProductBackground = "http://images2.nike.com/is/image/DotCom/PHN_PS/M7650_102_E_PREM/converse-chuck-taylor-all-star-high-top-unisex-shoe.png?fmt=png-alpha"
					},
					new ListingItem()
					{
						ProductName = "Adidas R1",
						Price = 66.66,
						ListingItemType = ListingItemType.Basic,
						BrandCompany = "Adidas",
						BrandColor = Color.White,
						ProductBackground = "http://www.pngall.com/wp-content/uploads/2016/06/Adidas-Shoes-PNG-Picture.png"
					},
					new ListingItem()
					{
						ProductName = "Premium",
						Price = 34.12,
						ListingItemType = ListingItemType.Basic,
						BrandCompany = "Timberland",
						BrandColor = Color.White,
						ProductBackground = "http://image.sneakerhead.com/is/image/sneakerhead/snusa-detail_20?$sn20-650$&$img=sneakerhead/timberland-af-6-inch-annversary-27092-1"
					}
				};
			}

			public void OnNavigatingTo(NavigationParameters parameters)
			{
				
			}
		}
	}
