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
    class ApiConstants
    {
        private Context _ctx;

        public String ApiClientId
        {
            get
            {
                return "";
            }
        }

        public String ApiClientSecret
        {
            get
            {
                return "";
            }
        }

        public ApiConstants(Context context)
        {
            _ctx = context;
        }

        
    }
}