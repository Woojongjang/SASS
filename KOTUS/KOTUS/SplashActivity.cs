
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KOTUS
{
	[Activity (Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]			
	public class SplashActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Thread.Sleep(2500); // Simulate a long loading process on app startup.
			// when we have a lot of data to load or uncompress we can replace the thread sleep with that instead
			StartActivity(typeof(WelcomeActivity));
		}
	}
}

