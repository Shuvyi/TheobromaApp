
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ThebromaCoffeeLounge
{
	[Activity(Label = "AboutUs")]
	public class AboutUs : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.AboutAx);
			var button = FindViewById<ImageButton>(Resource.Id.AboutButton1);

			var ConnectUs = FindViewById<Button>(Resource.Id.ConnectUs);

			ConnectUs.Click += delegate
			{
				var uri = Android.Net.Uri.Parse("http://google.com");
				var intent = new Intent(Intent.ActionView, uri);
				StartActivity(Intent);
			};

			// Create your application here
		}
	}
}

