using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace MobileHw3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button mail;
        Button mail2;
        Button mail3;
        Button mail4;
        Button mail5;
        Button mail6;
        TextView txtView;
        TextView txtView2;
        TextView txtView3;
        TextView txtView4;
        TextView txtView5;
        TextView txtView6;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            mail = FindViewById<Button>(Resource.Id.btnmail);
            mail2 = FindViewById<Button>(Resource.Id.btnmail2);
            mail3 = FindViewById<Button>(Resource.Id.btnmail3);
            mail4 = FindViewById<Button>(Resource.Id.btnmail4);
            mail5 = FindViewById<Button>(Resource.Id.btnmail5);
            mail6 = FindViewById<Button>(Resource.Id.btnmail6);
            txtView = FindViewById<TextView>(Resource.Id.txtMail);
            txtView2 = FindViewById<TextView>(Resource.Id.txtMail2);
            txtView3 = FindViewById<TextView>(Resource.Id.txtMail3);
            txtView4 = FindViewById<TextView>(Resource.Id.txtMail4);
            txtView5 = FindViewById<TextView>(Resource.Id.txtMail5);
            txtView6 = FindViewById<TextView>(Resource.Id.txtMail6);
            mail.Click += btn_click_handle;
            mail2.Click += btn_click_handle;
            mail3.Click += btn_click_handle;
            mail4.Click += btn_click_handle;
            mail5.Click += btn_click_handle;
            mail6.Click += btn_click_handle;
        }

        private void btn_click_handle(object sender, EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, (Button)sender);
            menu.MenuInflater.Inflate(Resource.Menu.popup, menu.Menu);
            string text = "";
            switch (((Button)sender).Id)
            {
                case Resource.Id.btnmail:
                    text = txtView.Text;
                    break;
                case Resource.Id.btnmail2:
                    text = txtView2.Text;
                    break;
                case Resource.Id.btnmail3:
                    text = txtView3.Text;
                    break;
                case Resource.Id.btnmail4:
                    text = txtView4.Text;
                    break;
                case Resource.Id.btnmail5:
                    text = txtView5.Text;
                    break;
                case Resource.Id.btnmail6:
                    text = txtView6.Text;
                    break;
            }

            menu.MenuItemClick += (s, arg) =>
            {
                var bundle = new Bundle();
                bundle.PutString("kwy", (arg.Item.TitleFormatted).ToString());
                bundle.PutString("mail", text);

                Intent inte = new Intent(this, typeof(MailActivity));
                inte.PutExtras(bundle);
                StartActivity(inte);
            };

          

            menu.Show();
        }
    }
}