using Caliburn.Micro;
using ItemsControlCaliburnMicro.ViewModels;
using System.Windows;

namespace ItemsControlCaliburnMicro
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
