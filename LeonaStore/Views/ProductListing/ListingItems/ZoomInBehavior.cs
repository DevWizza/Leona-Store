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

			bindable.Opacity = 0;

			await Task.WhenAll(bindable.ScaleTo(1.2, 5000, Easing.SinOut),
			                   bindable.FadeTo(1, 5000, Easing.SinOut));
		}
	}
}
