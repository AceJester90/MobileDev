using SQLitenets.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SQLitenets.Views
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