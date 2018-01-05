using Android.App;
using Android.Content;
using Android.Util;

namespace CrashableTestApp.Droid.Services
{
    [BroadcastReceiver]
    [IntentFilter(new[] { Intent.ActionBootCompleted })]
    public class BootCompletedBroadcastReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            AndroidMvxInitializer.SafeEnsureInitialized();
            context.StartService(new Intent(context, typeof(TestTimerService)));
        }
    }
}
