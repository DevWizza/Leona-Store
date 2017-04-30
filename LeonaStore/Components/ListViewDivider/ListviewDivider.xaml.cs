using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewDivider
{
	public partial class ListviewDivider : ListView
	{
		public ListviewDivider()
		{
			InitializeComponent();
		}


		protected override void SetupContent(Cell content, int index)
		{
			base.SetupContent(content, index);
		}
		
	}
}
