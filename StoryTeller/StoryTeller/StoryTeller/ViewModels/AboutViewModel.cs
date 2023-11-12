using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StoryTeller.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Лист персонажа";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}