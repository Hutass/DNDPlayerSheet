using Firebase.Database;
using Firebase.Database.Query;
using StoryTeller.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace StoryTeller.Services
{
    public class RollDataStore : IDataStore<Roll>
    {
        public event IDataStore<Roll>.GetItemsDelegate GetItems;

        public RollDataStore()
        {
            rolls = new ObservableCollection<Roll>();
            firebaseClient = new FirebaseClient("https://storyteller-dnd-default-rtdb.europe-west1.firebasedatabase.app");
            firebaseClient.
                Child("Rolls").
                AsObservable<Roll>().
                Subscribe((dbevent) =>
                {
                    if (dbevent.Object != null)
                    {
                        rolls.Add(dbevent.Object);
                        GetItems?.Invoke(rolls);
                    }
                });
        }

        public ObservableCollection<Roll> rolls { get; set; }

        private Firebase.Database.FirebaseClient firebaseClient;


        public async Task<bool> AddItemAsync(Roll item)
        {
            await firebaseClient.Child("Rolls").PostAsync<Roll>(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Roll item)
        {

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {

            return await Task.FromResult(true);
        }

        public async Task<Roll> GetItemAsync(string id)
        {
            return await Task.FromResult(new Roll());
        }

        public async Task<IEnumerable<Roll>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(rolls);
        }
    }
}