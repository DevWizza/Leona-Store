using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Behaviors
{
	public class HideViewIf : Behavior<View>
	{
		View _associatedObject;

		public static readonly BindableProperty HideControlIfProperty =
			BindableProperty.Create(nameof(HideControlIf),
			typeof(bool),
			typeof(HideViewIf),
			false, propertyChanged: async(b,o,n) => await OnPropertyChanged(b,o,n));

		public bool HideControlIf
		{
			get { return (bool)GetValue(HideControlIfProperty); }
			set { SetValue(HideControlIfProperty, value); }
		}

		static async Task OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var instance = (HideViewIf)bindable;
			await instance.HideView((bool)newValue);
		}

		async Task HideView(bool isConditionTrue)
		{
			if (isConditionTrue)
			{
				//if (_associatedObject.IsEnabled)
				//	return;
				
				_associatedObject.IsEnabled = true;

				await Show();
			}
			else
			{
				if (!_associatedObject.IsEnabled)
					return;
				
				await Hide();

				_associatedObject.IsEnabled = false;
			}
		}

		async Task Show()
		{
			await _associatedObject.FadeTo(1, 200, Easing.SinIn);
		}

		async Task Hide()
		{
			await _associatedObject.FadeTo(0, 200, Easing.SinIn);
		}

		protected override void OnAttachedTo(View bindable)
		{
			base.OnAttachedTo(bindable);

			_associatedObject = bindable;

			_associatedObject.BindingContextChanged += OnBindingContextChanged;
		}

		public void OnBindingContextChanged(object sender, EventArgs e)
		{
			BindingContext = _associatedObject.BindingContext;
		}

		protected override void OnDetachingFrom(View bindable)
		{
			base.OnDetachingFrom(bindable);

			_associatedObject = null;

			_associatedObject.BindingContextChanged -= OnBindingContextChanged;
		}
	}
}
