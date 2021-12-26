using ImageTutorial1.Services;
using ImageTutorial1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageTutorial1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
