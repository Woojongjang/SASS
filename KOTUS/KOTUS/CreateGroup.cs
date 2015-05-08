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
	[Activity (Label = "Create Group")]
	public class CreateGroup : Activity
	{
		private Button create_group_button;
		private EditText group_name;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set the current layout
			SetContentView (Resource.Layout.GroupCreate);

			create_group_button = FindViewById<Button> (Resource.Id.createGroupButton);
			group_name = FindViewById<EditText> (Resource.Id.groupName);
			Spinner spinner = FindViewById<Spinner> (Resource.Id.spinner);

			var adapter = ArrayAdapter.CreateFromResource (
				              this, Resource.Array.privacy_array, Android.Resource.Layout.SimpleSpinnerItem);
			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			spinner.Adapter = adapter;



		}
	}
}

