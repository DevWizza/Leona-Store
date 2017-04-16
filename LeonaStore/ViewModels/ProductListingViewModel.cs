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
						ProductName = "Adidas R1",
						Price = 66.66,
						ListingItemType = ListingItemType.Announcement,
						BrandCompany = "Adidas",
						BrandColor = Color.White,
						ProductBackground = "http://www.pngall.com/wp-content/uploads/2016/06/Adidas-Shoes-PNG-Picture.png"
					},
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
						ProductName = "Nintendo Switch",
						Price = 34.12,
						ListingItemType = ListingItemType.Premium,
						BrandCompany = "Nintendo",
						BrandColor = Color.White,
						ProductBackground = "http://vignette4.wikia.nocookie.net/fireemblem/images/4/42/Nintendo_Switch.png/revision/latest?cb=20170115150103"
					}
				};
			}

			public void OnNavigatingTo(NavigationParameters parameters)
			{
				
			}
		}
	}
