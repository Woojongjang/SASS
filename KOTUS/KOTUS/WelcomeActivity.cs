using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace KOTUS
{
	[Activity (Label = "Log In", Icon = "@drawable/icon")]
	public class WelcomeActivity : Activity
	{

		private EditText user_email_field;
		private EditText user_password_field;
		private Button log_in_button;
		private TextView sign_me_up_link;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


			// find the layout objects
			user_email_field = FindViewById<EditText> (Resource.Id.editText1);
			user_password_field = FindViewById<EditText> (Resource.Id.editText2);
			log_in_button = FindViewById<Button> (Resource.Id.button1);
			sign_me_up_link = FindViewById<TextView> (Resource.Id.textView3);


			// designate what to do on button and link clicks

			log_in_button.Click += delegate {
				// this is where you tell it what to do when the button is pressed
				Console.WriteLine("Log In Button Pressed!!");
				StartActivity(typeof(UserDashActivity)); 
			};

			sign_me_up_link.Click += delegate {
				// this is where you tell it what to do when the link is pressed
				Console.WriteLine("Sign Up Text Pressed!!");
				StartActivity(typeof(signUpActivity));
			};



		}
	}
}


