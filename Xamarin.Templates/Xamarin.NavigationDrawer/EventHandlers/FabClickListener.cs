using Android.Support.Design.Widget;
using Android.Views;

namespace Xamarin.NavigationDrawer.EventHandlers
{
    public class FabClickListener : Java.Lang.Object, View.IOnClickListener
    {
        public void OnClick(View v)
        {
            Snackbar.Make(v, "Replace with your own action", Snackbar.LengthLong)
                      .SetAction("Action", (View.IOnClickListener)null).Show();
        }
    }
}