using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace CrashableTestApp.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public ICommand InitClickCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    DoOnInitClick();
                });
            }
        }

        public ICommand FileClickCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    DoOnFileClick();
                });
            }
        }

        private void DoOnInitClick()
        {

        }

        private void DoOnFileClick()
        {

        }
    }
}
