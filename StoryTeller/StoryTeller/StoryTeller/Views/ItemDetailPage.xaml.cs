using StoryTeller.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StoryTeller.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}