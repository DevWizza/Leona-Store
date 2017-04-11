using System;
using System.Collections;
using Xamarin.Forms;

namespace LeonaStore
{
	public class CarouselDotsView : StackLayout
	{
		public static BindableProperty CurrentPageProperty = 
			BindableProperty.Create("CurrentPage",
								typeof(int),
		                        typeof(CarouselDotsView),
								0,
			                        propertyChanged: OnCurrentPageChanged);

		public static BindableProperty ItemsSourceProperty =
			BindableProperty.Create("ItemsSource",
						typeof(IList),
						typeof(CarouselDotsView),
						null,
			                        propertyChanged: OnItemsSourceChanged);

		public int CurrentPage
		{ 
			get { return (int)GetValue(CurrentPageProperty); }
			set { SetValue(CurrentPageProperty, value); }
		}

		public IList ItemsSource
		{ 
			get { return (IList)GetValue(ItemsSourceProperty); }
			set { SetValue(ItemsSourceProperty, value); }
		}

		static void OnCurrentPageChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var instance = (CarouselDotsView)bindable;

			instance.SetCurrentPage((int)newValue);
		}

		static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var instance = (CarouselDotsView)bindable;

			var items = ((IList)newValue).Count;

			instance.PopulateDots(items);
		}

		public CarouselDotsView()
		{
			HorizontalOptions = LayoutOptions.CenterAndExpand;
		}

		void PopulateDots(int items)
		{
			for (int i = 0; i < items; i++)
			{
				
			}
		}

		void SetCurrentPage(int newValue)
		{
			
		}
	}
}
