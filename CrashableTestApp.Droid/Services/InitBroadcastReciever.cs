using System;
using Android.App;
using Android.Content;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using CrashableTestApp.Core;

namespace CrashableTestApp.Droid.Services
{
    [BroadcastReceiver(Name = "crashabletestapp.droid.services.InitBroadcastReciever", Enabled = true)]
    [IntentFilter(new[] { Consts.InitIntentFilter })]
    public class InitBroadcastReciever : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            AndroidMvxInitializer.SafeEnsureInitialized();
        }
    }
}
