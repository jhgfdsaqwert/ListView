using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App11
{
    [Activity(Label = "App11", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListView listView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            listView = FindViewById<ListView>(Resource.Id.listView1);
            List<CityClass> cc = new List<CityClass>();
            CityClass c1 = new CityClass("Beijing", Resource.Drawable.beijing);
            cc.Add(c1);
            listView.Adapter = new HomeScreenAdapter(this, cc);
        }
    }
}

