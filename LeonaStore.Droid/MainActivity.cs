
using Android.App;
using Android.Content.PM;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Microsoft.Practices.Unity;
using Prism;
using Prism.Unity;
using Xamarin.Forms.Platform.Android;

namespace LeonaStore.Droid
{
	[Activity(Label = "@string/AppName", Icon = "@mipmap/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			ToolbarResource = Resource.Layout.toolbar;
    		TabLayoutResource = Resource.Layout.tabs;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			ImageCircleRenderer.Init();

			LoadApplication(new App(new AndroidInitializer()));
		}
	}

	public class AndroidInitializer : IPlatformInitializer
	{
		public void RegisterTypes(IUnityContainer container)
		{

		}
	}
}
