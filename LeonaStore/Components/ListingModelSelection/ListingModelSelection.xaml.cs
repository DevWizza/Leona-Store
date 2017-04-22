using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LeonaStore
{
	public partial class ListingModelSelection : StackLayout
	{
			public static BindableProperty ItemsSourceProperty =
				BindableProperty.Create("ItemsSource",
				typeof(IList),
				typeof(ListingModelSelection),
				null,
                propertyChanged: OnItemsSourceChanged);

		public IList ItemsSource
		{
			get { return (IList)GetValue(ItemsSourceProperty); }
			set { SetValue(ItemsSourceProperty, value); }
		}

		public static BindableProperty DataTemplateProperty =
				BindableProperty.Create("DataTemplate",
                typeof(DataTemplate),
				typeof(ListingModelSelection),
				null);

		public DataTemplate DataTemplate
		{
			get { return (DataTemplate)GetValue(DataTemplateProperty); }
			set { SetValue(DataTemplateProperty, value); }
		}

		static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var instance = (ListingModelSelection) bindable;
			instance.PopulateChildrens((List<string>)newValue);
		}

		void PopulateChildrens(IList list)
		{
			foreach (var kid in list)
			{
				var content = (View) DataTemplate.CreateContent();

				content.BindingContext = kid;

				Children.Add(content);
			}
		}

		public ListingModelSelection()
		{
			InitializeComponent();
		}
	}
}
