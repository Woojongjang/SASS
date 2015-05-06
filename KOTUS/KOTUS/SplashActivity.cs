
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

using Parse;

namespace KOTUS
{
	[Activity (Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]			
	public class SplashActivity : Activity
	{
		public SplashActivity (IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			ParseClient.Initialize ("essILhBBMMu4mcWdHW7Qtb4pZJdBU415083KdFXT", "qMWZn2Zjmln0OIMXjJltHBR3HW7cD1yR5J2IVdvk");
			Thread.Sleep(2500); // Simulate a long loading process on app startup.
			// when we have a lot of data to load or uncompress we can replace the thread sleep with that instead
			StartActivity(typeof(WelcomeActivity));
		}
	}
}

