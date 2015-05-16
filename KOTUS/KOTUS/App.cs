using System;
using Android.App;
using Android.Runtime;
using Parse;

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
			Console.WriteLine("Initializing Parse Client");
			ParseClient.Initialize ("essILhBBMMu4mcWdHW7Qtb4pZJdBU415083KdFXT", "qMWZn2Zjmln0OIMXjJltHBR3HW7cD1yR5J2IVdvk");

		}
	}
}