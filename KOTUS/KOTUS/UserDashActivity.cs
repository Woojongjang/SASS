
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
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set the current layout
			SetContentView (Resource.Layout.UserDash);

		}
	}
}

