using System;
using System.Collections;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;
using System.Linq;
using CarouselDotsGenerator;

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

		public static BindableProperty DotColorProperty =
			BindableProperty.Create("DotColor",
				typeof(Color),
				typeof(CarouselDotsGenerator), Color.White);

		public Color DotColor
		{
			get { return (Color)GetValue(DotColorProperty); }
			set { SetValue(DotColorProperty, value); }
		}

		static void OnCurrentPageChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var instance = (CarouselDotsGenerator)bindable;

			instance.SetCurrentPage((int)newValue);
		}

		static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
		{
			if (newValue == null)
				return;
			
			var instance = (CarouselDotsGenerator)bindable;

			var items = ((IList)newValue).Count;

			instance.PopulateDots(items);

			if(items >= 1)
				instance.SetCurrentPage(0);
		}

		public CarouselDotsGenerator()
		{
			InitializeComponent();

			DotColor = Color.White;
		}

		void PopulateDots(int listOfPagesOnScreen)
		{
			for (int eachPage = 0; eachPage < listOfPagesOnScreen; eachPage++)
			{
				Children.Add(new LittleDotView());
			}
		}

		void SetCurrentPage(int newValue)
		{
			foreach (IDot littleDot in Children)
			{
				littleDot.ChangeFillColorTo(Color.Black.MultiplyAlpha(0.4));
			}

			var selected = (IDot) Children.ElementAtOrDefault(newValue);

			if (selected != null)
			{
				selected.ChangeFillColorTo(DotColor);
			}
		}
	}
}
