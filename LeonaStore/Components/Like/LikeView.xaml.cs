using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Like.ViewModels;
using Xamarin.Forms;

namespace Like
{
	public partial class LikeView : RelativeLayout
	{
		public LikeView()
		{
			InitializeComponent();
		}

		async void OnComponentTapped(object sender, EventArgs e)
		{
			InputTransparent = true;

			await this.ScaleTo(1.6, 100, Easing.SinOut);

			await this.ScaleTo(1, 100, Easing.SinIn);

			InputTransparent = false;
		}
	}
}
