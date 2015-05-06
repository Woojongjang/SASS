using System;
using Android.App;
using Android.Runtime;
using Parse;

// placed parse initialize in the splash loading activity so that it is initialized when the app opens.. leaving this file here for now until ready for removal
/*
namespace KOTUS
{
	[Application]
	public class App : Application
	{
		public App (IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

			// Initialize the Parse client with your Application ID and .NET Key found on
			// your Parse dashboard
			ParseClient.Initialize ("essILhBBMMu4mcWdHW7Qtb4pZJdBU415083KdFXT", "qMWZn2Zjmln0OIMXjJltHBR3HW7cD1yR5J2IVdvk");
		}
	}
}
*/