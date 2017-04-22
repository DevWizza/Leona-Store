using System;
using System.Globalization;
using LeonaStore.Domain;
using LeonaStore.Views.Home.ListingItem;
using Xamarin.Forms;

namespace ListingItems
{
	public class MoneyConverter : IValueConverter
	{
		public MoneyConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var price = value as Price;

			if (price == null)
				throw new Exception("Value must be a 'Price' object");

			return $"${price.Amount} {price.Currency}";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
