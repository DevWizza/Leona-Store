using System;
using System.ComponentModel;
using iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ScrollView), typeof(DisableScrollviewScrollBarRenderer))]
namespace iOS
{
	public class DisableScrollviewScrollBarRenderer : ScrollViewRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null || this.Element == null)
				{
			return;
		}
			if (e.OldElement != null)
			{
			e.OldElement.PropertyChanged -= OnElementPropertyChanged;
			}

		e.NewElement.PropertyChanged += OnElementPropertyChanged;
		}
		private void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{

			this.ShowsHorizontalScrollIndicator = false; 
		}
	}
}
