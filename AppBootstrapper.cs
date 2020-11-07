using Caliburn.Micro;
using MCDemo.ViewModels;
using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace MCDemo
{
    public class AppBootstrapper : BootstrapperBase
    {
        private CompositionContainer container;

        public AppBootstrapper()
        {
            Initialize();
        }


        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //DisplayRootViewFor<MCFillingViewModel>();

            DisplayRootViewFor<MCMainViewModel>();
        }
    }
}
