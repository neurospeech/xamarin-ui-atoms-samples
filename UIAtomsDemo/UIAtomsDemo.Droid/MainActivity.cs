using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace UIAtomsDemo.Droid
{
	[Activity (
        Label = "UIAtoms Demo", 
        Icon = "@drawable/icon", 
        MainLauncher = true,
        Theme = "@style/AppTheme",
        ConfigurationChanges = 
            ConfigChanges.ScreenSize | 
            ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            LoadApplication(new UIAtomsDemo.App ());
		}
	}
}

