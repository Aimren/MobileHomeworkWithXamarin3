using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace MobileHw3
{
    [Activity(Label = "MailActivity")]
    public class MailActivity : AppCompatActivity
    {
        TextView subject;
        TextView mail;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.mail_activity_layout);


            subject = FindViewById<TextView>(Resource.Id.Text2);
            mail = FindViewById<TextView>(Resource.Id.Text);

            string subjectText = "Subject:" + base.Intent.Extras.GetString("key", "------NAN------");
            string mailText = base.Intent.Extras.GetString("mail", "------NAN------");
            subject.Text = subjectText;
            mail.Text = mailText;
        }
    }
}