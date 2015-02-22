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

namespace ImgMobileAndroid
{
    [Activity(Label = "@string/LoginActivity", MainLauncher = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.KeyboardHidden | Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.ActivityLogin);

            var loginButton = FindViewById<Button>(Resource.Id.ActivityLoginButton);
            loginButton.Click += LoginClick;
        }

        private void LoginClick(object sender, EventArgs e)
        {
            Finish();

            var galleryIntent = new Intent(this, typeof(MainActivity));
            StartActivity(galleryIntent);
        }
    }
}