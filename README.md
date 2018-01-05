test app for https://github.com/MvvmCross/MvvmCross/issues/955 issue on latest mvvmcross 5.6

to reproduce crash you neeed to 
1) install app, reboot, wait till recieve notification in notification bar - this means service is running 
2) start app, if not crashed goto 3 
3) kill app(close app from tasks manager) and faster click on app icon to run - 80% it will crash

modify this row from 'void'[here](https://github.com/sbokatuk/mvvmcross955/blob/master/CrashableTestApp.Droid/Services/TestTimerService.cs#L37) to 'async Task'[sample](https://github.com/sbokatuk/mvvmcross955/blob/nocrash/CrashableTestApp.Droid/Services/TestTimerService.cs#L37) and app will stop crashing 

