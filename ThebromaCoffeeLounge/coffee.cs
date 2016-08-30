
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
	[Activity(Label = "coffee")]
	public class coffee : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			//set the reference to the layout
			SetContentView(Resource.Layout.Maincoffee);
			var button = FindViewById<ImageButton>(Resource.Id.CoffeeButton);
			// Create your application here

		}
	}
}

