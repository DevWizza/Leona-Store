using System;
namespace AppDrawerItems
{
	public class DrawerItem
	{
		public string Text { get; set; }

		public string Icon { get; set; }

		public string ScreenNavigateTo { get; set; }

		public bool ShowSeparatorAfter { get; set; }
	}
}
