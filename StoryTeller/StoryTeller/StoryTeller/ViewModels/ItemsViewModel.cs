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
            Init();
            RollStore.GetItems += SetRolls;
        }
        async void Init()
        {
            Rolls = new ObservableCollection<Roll>(await RollStore.GetItemsAsync()); ;
        }
        void SetRolls(ObservableCollection<Roll> rolls)
        {
            Rolls = rolls;
            OnPropertyChanged(nameof(Rolls));
        }
     
    }
}