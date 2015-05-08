
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
	[Activity (Label = "Sign Up")]			
	public class signUpActivity : Activity
	{

		// private member variables
		private EditText first_name;
		private EditText last_name;
		private EditText email;
		private EditText password;
		private EditText confirm_pass;
		private EditText phone_number;
		private Button sign_up;

		// private member functions

		// this function creates a new user account in the parse database
		// Completed
		private async void create_user_in_parse(){
			var user = new ParseUser()
			{
				Username = email.Text,
				Password = password.Text,
				Email = email.Text
			};

			user["phone"] = phone_number.Text;
			user ["firstName"] = first_name.Text;
			user ["lastName"] = last_name.Text;

			await user.SignUpAsync();
		}

		// returns true if the email address is of a valid format
		private bool check_email(){
			// need to impelemt
			//TODO

			return false;
		}
			
		// returns true if the passwords are of the valid format
		private bool check_passes_are_valid(){
			//need to implement
			//TODO
			return false;
		}

		// returns true if the first and last name is valid
		private bool check_names(){
			// need to implement
			//TODO
			return false;
		}

		// this function checks that the passwords that were entered both match
		// Completed
		private bool check_passwords_match(){
			if (password.Text.Equals(confirm_pass.Text)){
				return true;
			} else{
				return false;
			}
		}

		// this will check if the entered phone number is valid
		// returns true if the phone number is valid
		private bool check_phone_number(){
			// need to implement
			//TODO
			return false;
		}

		// this function will return true if user does not already exist
		private bool check_that_user_does_not_exist(){
			// need to implement
			//TODO
			return false;
		}

		// this function controls the view/layout and user interaction
		// INCOMPLETE
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

				// check that email address is valid
				bool email_valid = check_email();

				// check that name is valid
				bool name_valid = check_names();

				// check that phone number is valid
				bool phone_valid = check_phone_number();

				// check that passwords are valid
				bool pass_valid = check_passes_are_valid();

				// check that the passwords match
				bool pass_match = check_passwords_match();

				// check that user doesn't already exist
				bool unique_user = check_that_user_does_not_exist();

				// if all valid then create the user
				if(email_valid && name_valid && phone_valid && pass_match && unique_user){ // check that the user can be created
					// create user account
					create_user_in_parse();

					// now log the user in
					//TODO

					// redirect the logged in user to the dashboard
					StartActivity(typeof(UserDashActivity)); 
				} else {
					// something went wrong, need to display error and keep them on this page
					//TODO
				}


			};


		}
	}
}

