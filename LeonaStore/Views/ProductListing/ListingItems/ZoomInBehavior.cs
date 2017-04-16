using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListingItems
{
	public class ZoomInBehavior : Behavior<View>
	{
		protected override async void OnAttachedTo(View bindable)
		{
			base.OnAttachedTo(bindable);

			await Task.WhenAll(bindable.RotateTo(10, 5000, Easing.SinIn),
						 bindable.ScaleTo(1.3, 5000, Easing.SinOut));
		}
	}
}
