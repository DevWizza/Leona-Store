using System;
using System.Collections;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;
using System.Linq;

namespace LeonaStore.Components.CarouselDotsGenerator
{
	public partial class CarouselDotsGenerator : StackLayout
	{
		public static BindableProperty CurrentPageProperty =
			BindableProperty.Create("CurrentPage",
								typeof(int),
								typeof(CarouselDotsGenerator),
								0,
									propertyChanged: OnCurrentPageChanged);

		public static BindableProperty ItemsSourceProperty =
			BindableProperty.Create("ItemsSource",
						typeof(IList),
						typeof(CarouselDotsGenerator),
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
			var instance = (CarouselDotsGenerator)bindable;

			instance.SetCurrentPage((int)newValue);
		}

		static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var instance = (CarouselDotsGenerator)bindable;

			var items = ((IList)newValue).Count;

			instance.PopulateDots(items);

			if(items >= 1)
				instance.SetCurrentPage(0);
		}

		public CarouselDotsGenerator()
		{
			InitializeComponent();
		}

		void PopulateDots(int listOfPagesOnScreen)
		{
			for (int eachPage = 0; eachPage < listOfPagesOnScreen; eachPage++)
			{
				var circle = new CircleImage
				{
					BorderColor = Color.Transparent,
					FillColor = Color.Black.MultiplyAlpha(0.6),
					BorderThickness = 0,
					HeightRequest = 10,
					WidthRequest = 10,
					Aspect = Aspect.AspectFit,
					HorizontalOptions = LayoutOptions.Center
				};

				Children.Add(circle);
			}
		}

		void SetCurrentPage(int newValue)
		{
			foreach (var littleDot in Children)
			{
				littleDot.Opacity = 0.4;
			}

			var selected = Children.ElementAtOrDefault(newValue);

			if (selected != null)
			{
				selected.Opacity = 1;
			}
		}
	}
}
