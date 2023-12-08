using StoryTeller.Models;
using StoryTeller.Services;
using StoryTeller.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoryTeller.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Roll> Rolls { get; set; }
        public IDataStore<Roll> RollStore => DependencyService.Get<IDataStore<Roll>>();

        public ItemsViewModel()
        {
            Title = "Броски";
            Rolls = new ObservableCollection<Roll>(RollStore.GetItemsAsync().Result);
            RollStore.GetItems += SetRolls;
        }

        async void SetRolls(ObservableCollection<Roll> rolls)
        {
            Rolls = rolls;
        }
     
    }
}