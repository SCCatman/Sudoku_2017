using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Sudoku_2017.Droid
{
    [Activity(Label = "Sudoku_2017", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    // Needed to change FormsAppCompatActivity to the older FormsApplicationActivity, otherwise buttons won't fill in grid cells
    //public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity.
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            // Had to remove after downgrading from FormsAppCompatActivity to FormsApplicationActivity. not what we want to use anyway
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

