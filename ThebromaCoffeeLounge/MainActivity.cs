using Android.App;
using Android.Widget;
using Android.OS;

namespace ThebromaCoffeeLounge
{
	[Activity(Label = "Thebroma Coffee Lounge", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Menu);


			//Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.Coffee);
			Button button1 = FindViewById<Button>(Resource.Id.button1);
			Button button2 = FindViewById<Button>(Resource.Id.button2);
			Button button3 = FindViewById<Button>(Resource.Id.button3);
			Button button4 = FindViewById<Button>(Resource.Id.button4);
			button.Click += delegate { StartActivity(typeof(coffee)); };
			button1.Click += delegate { StartActivity(typeof(Beverages)); };
			button2.Click += delegate { StartActivity(typeof(Food)); };
			button3.Click += delegate { StartActivity(typeof(Sweets)); };
			button4.Click += delegate { StartActivity(typeof(AboutUs)); };

			var LocateUs = FindViewById<Button>(Resource.Id.LocateUs);


			}
		}
	}


