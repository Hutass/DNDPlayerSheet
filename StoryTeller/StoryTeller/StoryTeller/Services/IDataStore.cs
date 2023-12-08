using StoryTeller.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StoryTeller.Services
{
    public interface IDataStore<T>
    {
        public delegate void GetItemsDelegate(ObservableCollection<T> rolls);

        event GetItemsDelegate GetItems;
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
