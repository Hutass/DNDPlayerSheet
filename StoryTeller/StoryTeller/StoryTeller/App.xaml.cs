using StoryTeller.Models;
using StoryTeller.Services;
using StoryTeller.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryTeller
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            RollDataStore rollDataStore = new RollDataStore();
            DependencyService.RegisterSingleton<RollDataStore>(rollDataStore);
            DependencyService.Get<IDataStore<Roll>>();
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
