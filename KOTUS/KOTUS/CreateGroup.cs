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
using Android.Util;

using Parse;

namespace KOTUS
{
	[Activity (Label = "Create Group")]
	public class CreateGroup : Activity
	{
		private Button create_group_button;
		private EditText group_name;
		//private Spinner privacy_Setting;


		private async void create_group_in_parse(){
			var user = new ParseUser ();

			user["groupName"] = group_name.Text;
			//user["privacy"] = ?;

			await user.SignUpAsync();
		}

		private bool check_groupName(){
			//check if valid name inputted
			if(group_name.Text.Length == 0){
				group_name.SetError ("Create a valid Group Name!");
				return false;
			}
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set the current layout
			SetContentView (Resource.Layout.GroupCreate);

			create_group_button = FindViewById<Button> (Resource.Id.groupCreateButton);
			group_name = FindViewById<EditText> (Resource.Id.groupName);
			Spinner privacy_setting = FindViewById<Spinner> (Resource.Id.privacy_setting);

			var adapter = ArrayAdapter.CreateFromResource (
				              this, Resource.Array.privacy_array, Android.Resource.Layout.SimpleSpinnerItem);
			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			privacy_setting.Adapter = adapter;

			//Check if valid Group Name then create group, parse stuff, and generate group id, got to Group Dash
			if (group_name == check_groupName ()) {

				create_group_in_parse ();

				//create group id number

				create_group_button.Click += delegate {
					// this is where you tell it what to do when the button is pressed
					Console.WriteLine("Create Group Button Pressed!!");
					StartActivity(typeof(GroupDashActivity)); 
				};
			}

		}
	}
}

