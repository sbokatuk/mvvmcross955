using System;
using System.Runtime.CompilerServices;
using Android.App;
using MvvmCross.Droid.Platform;

namespace CrashableTestApp.Droid
{
    public static class AndroidMvxInitializer
    {
        /// <summary>
        /// If the app is already initializing async (via the splash screen), attempting to call MvxAndroidSetupSingleton.EnsureInitialized would normally crash
        /// https://github.com/MvvmCross/MvvmCross/issues/955
        /// </summary>
        public static void SafeEnsureInitialized([CallerMemberName]string caller = null)
        {
            System.Console.WriteLine("{0} SafeEnsureInitialized: Trying EnsureInitialized() from {1}", nameof(AndroidMvxInitializer), caller);
            MvxAndroidSetupSingleton.EnsureSingletonAvailable(Application.Context).EnsureInitialized();
        }

    }
}
