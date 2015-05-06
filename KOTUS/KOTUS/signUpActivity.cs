
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
	[Activity (Label = "Sign Up")]			
	public class signUpActivity : Activity
	{

		private EditText first_name;
		private EditText last_name;
		private EditText email;
		private EditText password;
		private EditText confirm_pass;
		private EditText phone_number;

		private Button sign_up;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set the current layout
			SetContentView (Resource.Layout.signUp);


			// find all resources in the layout
			first_name = FindViewById<EditText> (Resource.Id.firstName);
			last_name = FindViewById<EditText> (Resource.Id.lastName);
			email = FindViewById<EditText> (Resource.Id.userEmail);
			phone_number = FindViewById<EditText> (Resource.Id.phone);
			password = FindViewById<EditText> (Resource.Id.userPass);
			confirm_pass = FindViewById<EditText> (Resource.Id.confirmPass);

			sign_up = FindViewById<Button> (Resource.Id.button1);

			// assign button actions

			sign_up.Click += delegate {
				// implement here
				Console.WriteLine("First Name: " + first_name.Text);
				Console.WriteLine("Last Name: " + last_name.Text);
				Console.WriteLine("User Email: " + email.Text);
				Console.WriteLine("User Phone: " + phone_number.Text);
				Console.WriteLine("Password: " + password.Text);
				Console.WriteLine("Confirm Pass: " + confirm_pass.Text);

				StartActivity(typeof(UserDashActivity));
			};


		}
	}
}

