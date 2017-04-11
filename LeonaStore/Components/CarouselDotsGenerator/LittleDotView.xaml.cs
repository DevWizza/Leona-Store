using System;
using System.Collections.Generic;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace CarouselDotsGenerator
{
	public partial class LittleDotView : CircleImage, IDot
	{
		public LittleDotView()
		{
			InitializeComponent();
		}

		public void ChangeFillColorTo(Color to)
		{
			FillColor = to;
		}
	}
}
