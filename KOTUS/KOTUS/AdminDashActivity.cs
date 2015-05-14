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

using Parse;

namespace KOTUS
{
	[Activity (Label = "AdminActivity")]			
	public class AdminActivity : Activity
	{
		private Button delete_groups;
		private Button ban_members;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.AdminDash);
			delete_groups = FindViewById<Button>(Resource.Id.button1);
			ban_members = FindViewById<Button>(Resource.Id.button2);

			delete_groups.Enabled = false;

			/* sign_up.Click += (object sender, EventArgs e) =>
			{
				if(){
					delete_groups.Enabled = true;
				}
				else{
					delete_groups.Enabled = false;
				}			
			}
			*/
		}


	}
}


