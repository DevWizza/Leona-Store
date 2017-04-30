using Xamarin.Forms;

namespace LeonaStore.Views
{
	public partial class MoreApps : ContentPage
	{
		public MoreApps()
		{
			InitializeComponent();

			this.Parent.LowerChild(Second_Panel);
		}
	}
}

