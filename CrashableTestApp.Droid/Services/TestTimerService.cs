using System;
using Android.App;
using Android.Content;
using System.Timers;
using Android.OS;
using System.Threading.Tasks;

namespace CrashableTestApp.Droid.Services
{
    [Service]
    public class TestTimerService : Service
    {
        private Timer _iTimer = new Timer()
        {
            Enabled = true,
            Interval = 500,
            AutoReset = true,
        };

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override void OnCreate()
        {
            TestStuff();
            _iTimer.Elapsed += _iTimer_Elapsed;
        }

        void _iTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TestStuff();
        }

        //replace void to async Task and you will see a magic
        private async Task TestStuff()
        {
            Console.WriteLine($"Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            AndroidMvxInitializer.SafeEnsureInitialized();

            Notification.Builder notificationBuilder = new Notification.Builder(this)
                .SetSmallIcon(Resource.Mipmap.Icon)
                .SetContentTitle($"Background Tick {System.Threading.Thread.CurrentThread.ManagedThreadId}")
                .SetContentText(DateTime.Now.ToString());

            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            notificationManager.Notify(9000, notificationBuilder.Build());
        }
    }
}
