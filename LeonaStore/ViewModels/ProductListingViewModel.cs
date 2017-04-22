using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using LeonaStore.Domain;
using System.Collections.Generic;

namespace LeonaStore.ViewModels
	{
		public class ProductListingViewModel : BindableBase, INavigationAware
		{
			public string Title { get; set; }

			public Color BackgroundColor { get; set; }

			public ObservableCollection<ListingItem> Articles { get; set; }

			public ICommand RefreshListingCommand { get; set; }

			public ICommand ListingSelectedCommand { get; set; }

			public bool IsRefreshingListing { get; set; }

			readonly INavigationService _navigationService;

			public ProductListingViewModel(INavigationService navigationService)
			{
				_navigationService = navigationService;
				
				RefreshListingCommand = new Command(OnRefreshListing);

				ListingSelectedCommand = new Command(OnListingSelected);
			}

			async void OnListingSelected()
			{
				await _navigationService.NavigateAsync($"{Screens.ListingDetail}");
			}

			public void OnNavigatedFrom(NavigationParameters parameters)
			{
				
			}

			void OnRefreshListing()
			{
				IsRefreshingListing = false;
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
						Price = new Price
						{
							Amount = 42.45,
							Currency = "USD"
						},
						ListingItemType = ListingItemType.Announcement,
						ListingOwner = new ListingOwner
						{
							BrandColorHex = "#ffffff",
							OwnerIdentityName = "Adidas"
						},
						ProductBackground = "http://www.pngall.com/wp-content/uploads/2016/06/Adidas-Shoes-PNG-Picture.png",
						ListingImages = new List<string> 
						{
							"https://thesolesupplier.co.uk/wp-content/uploads/2016/01/Adidas-NMD-R1-Primeknit-Black-White.png",
							"http://justfreshkix.com/wp-content/uploads/2016/07/Adidas-NMD-R1-Japan-Boost-Black-1.png",
							"https://thesolesupplier.co.uk/wp-content/uploads/2016/05/Adidas-NMD-R1-White-Primeknit-OG.png"	
						},
						PronouncedFeatures = new List<string>
						{
							"Mesh",
							"Comfortable"
						},
						ListingModels = new ListingDifferentModels
						{
							ModelType = ListingModelType.Size,
							ListingModels = new List<string>
							{
								"4 D(M) US",
								"4.5 D(M) US",
								"5 D(M) US",
								"5.5 D(M) US",
								"6 D(M) US",
								"6.5 D(M) US",
								"7 D(M) US",
								"7.5 D(M) US",
								"8 D(M) US",
								"8.5 D(M) US",
								"9 D(M) US",
								"9.5 D(M) US",
								"10 D(M) US",
								"10.5 D(M) US",
								"11 D(M) US",
								"11.5 D(M) US",
								"12 D(M) US",
								"13 D(M) US",
								"14 D(M) US"
							}
						}
					},
					new ListingItem()
					{
						ProductName = "Chuck II Rio",
						Price = new Price
						{
							Amount = 33.45,
							Currency = "USD"
						},
						ListingItemType = ListingItemType.Basic,
						ListingOwner = new ListingOwner{
							BrandColorHex = "#ffffff",
							OwnerIdentityName = "Converse"
						},
						ProductBackground = "http://images2.nike.com/is/image/DotCom/PHN_PS/M7650_102_E_PREM/converse-chuck-taylor-all-star-high-top-unisex-shoe.png?fmt=png-alpha",
						ListingImages = new List<string> 
						{
							"https://s-media-cache-ak0.pinimg.com/originals/79/27/c1/7927c14d306918704e5d5f2bc4fd5215.png",
							"http://images3.nike.com/is/image/DotCom/PDP_P/819196_103_F_PREM/jr-tiempo-rio-iii-little-big-kids-indoor-court-soccer-shoe.png?fmt=png-alpha",
							"http://images2.nike.com/is/image/DotCom/PHN_PS/819196_103_B_PREM/jr-tiempo-rio-iii-little-big-kids-indoor-court-soccer-shoe.png?fmt=png-alpha"
						},
						PronouncedFeatures = new List<string>
						{
							"Rubber",
							"Canvas",
							"HQ"
						},
						ListingModels = new ListingDifferentModels
						{
							ModelType = ListingModelType.Size,
							ListingModels = new List<string>
							{
								"10.5 D(M) US",
								"11 D(M) US",
								"11.5 D(M) US",
								"12 D(M) US",
								"13 D(M) US",
								"14 D(M) US"
							}
						}
					},
					new ListingItem()
					{
						ProductName = "Nintendo Switch",
						Price = new Price
						{
							Amount = 299.99,
							Currency = "USD"
						},
						ListingItemType = ListingItemType.Basic,
						ListingOwner = new ListingOwner {
							BrandColorHex = "#ffffff",
							OwnerIdentityName = "Nintendo"
						},
						ProductBackground = "http://vignette4.wikia.nocookie.net/fireemblem/images/4/42/Nintendo_Switch.png/revision/latest?cb=20170115150103"
					},
					new ListingItem()
					{
						ProductName = "iPhone 7",
						Price = new Price
						{
							Amount = 699.34,
							Currency = "USD"
						},
						ListingItemType = ListingItemType.Basic,
						ListingOwner = new ListingOwner
						{
							BrandColorHex = "#ffffff",
							OwnerIdentityName = "Apple"
						},
						ProductBackground = "http://pngbase.com/content/Electronics/Iphone%20Apple/5396.png",
						ListingImages = new List<string> 
						{
							"http://pngbase.com/content/Electronics/Iphone%20Apple/5396.png",
							"http://www.pngall.com/wp-content/uploads/2016/06/IPhone-PNG-Picture-PNG-Image.png",
							"http://www.opusnetworks.co.uk/wp-content/uploads/2017/01/IPhone-7.png"	
						},
						PronouncedFeatures = new List<string>
						{
							"128gb",
							"iOS10",
							"New",
							"Unlocked"
						}
					},
					new ListingItem()
					{
						ProductName = "Macbook Pro 15'",
						Price = new Price
						{
							Amount = 1200.42,
							Currency = "USD"
						},
						ListingItemType = ListingItemType.Basic,
						ListingOwner = new ListingOwner {
							BrandColorHex = "#ffffff",
							OwnerIdentityName = "Apple"
						},
						ProductBackground = "http://www.umbc.edu/bookstore-data/macbooksplash/images/MacBookPro_15inch_2.png"
					}
				};
			}

			public void OnNavigatingTo(NavigationParameters parameters)
			{
				
			}
		}
	}
