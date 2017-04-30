using System;
using System.Collections.Generic;
using AppDrawerItems;
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
			var viewModel = content.BindingContext as DrawerItem;

			if (viewModel.ShowSeparatorAfter)
			{
				var view = content as ViewCell;

				var layout = view.View as StackLayout;

				layout.Children.Add(new SeparatorView());
			}

			base.SetupContent(content, index);
		}
	}
}
