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

namespace KOTUS
{
	[Activity (Label = "User Dashboard")]			
	public class UserDashActivity : Activity
	{
		//private Button event_create_button;
		//private Button browse_group_button;
		//private Button group_list_button;
		private Button group_create_button;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set the current layout
			SetContentView (Resource.Layout.UserDash);

			group_create_button = FindViewById<Button> (Resource.Id.createGroupButton);

			group_create_button.Click += delegate {
				// this is where you tell it what to do when the button is pressed
				Console.WriteLine("Create A Group Button Pressed!!");
				StartActivity(typeof(CreateGroup)); 
			};
		}
	}
}

