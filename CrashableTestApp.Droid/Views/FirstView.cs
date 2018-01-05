using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using CrashableTestApp.Core;
using CrashableTestApp.Droid.Services;
using MvvmCross.Droid.Views;

namespace CrashableTestApp.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            StartService(new Intent(this, typeof(TestTimerService)));
            SetContentView(Resource.Layout.FirstView);
            FindViewById<Button>(Resource.Id.initButton).Click += Handle_InitClick;
            FindViewById<Button>(Resource.Id.fileButton).Click += Handle_FileClick;
        }

        void Handle_InitClick(object sender, System.EventArgs e)
        {
            AndroidMvxInitializer.SafeEnsureInitialized();
            var intent = new Intent(Consts.InitIntentFilter);
            SendBroadcast(intent);
        }

        void Handle_FileClick(object sender, System.EventArgs e)
        {
            var intent = new Intent(Consts.FileIntentFilter);
            SendBroadcast(intent);
        }
    }
}
