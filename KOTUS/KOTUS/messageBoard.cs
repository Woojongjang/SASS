
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

namespace Application
{
	[Activity (Label = "messageBoard")]			
	public class messageBoard : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			private EditText message;

			private Button writeMessage;

			protected override void OnCreate (Bundle bundle)
			{
				base.OnCreate (bundle);

				// set the current layout
				SetContentView (Resource.Layout.signUp);

				writeMessage = FindViewById<Button> (Resource.Id.button1);

				writeMessage.Click += delegate {
					// implement here

					StartActivity(typeof(writeMessageActivity));
				};

			}
		}
	}
}

