
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
	[Activity(Label = "Food")]
	public class Food : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Breaky);
			// Create your application here
			var button = FindViewById<ImageButton>(Resource.Id.FoodButton);
		}
	}
}

