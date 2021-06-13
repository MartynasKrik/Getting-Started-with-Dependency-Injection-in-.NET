using PeopleViewer.Presentation;
using PeopleViewer.View;
using PersonDataReader.CSV;
using PersonDataReader.Decorators;
using PersonDataReader.Service;
using System.Windows;

namespace PeopleViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ComposeObjects();
            Application.Current.MainWindow.Title = "Injected";
            Application.Current.MainWindow.Show();
        }

        private static void ComposeObjects()
        {
            var reader = new CachingReader(new ServiceReader());
            var viewModel = new PeopleViewModel(reader);
            Application.Current.MainWindow = new PeopleViewerWindow(viewModel);
        }
    }
}
