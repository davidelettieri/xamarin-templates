using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Views;

namespace Xamarin.BottomNavigation
{
    [Activity(Label = "Xamarin.BottomNavigation", MainLauncher = true, Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private TextView _textMessage;

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    _textMessage.Text = GetString(Resource.String.title_home);
                    return true;
                case Resource.Id.navigation_dashboard:
                    _textMessage.Text = GetString(Resource.String.title_dashboard);
                    return true;
                case Resource.Id.navigation_notifications:
                    _textMessage.Text = GetString(Resource.String.title_notifications);
                    return true;
            }
            return false;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            _textMessage = FindViewById<TextView>(Resource.Id.message);

            var navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);

            navigation.SetOnNavigationItemSelectedListener(this);
        }
    }
}

