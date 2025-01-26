using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselView
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<AnimalModel> animals;
        public MainPage()
        {
            InitializeComponent();
            animals = new ObservableCollection<AnimalModel>
            {
                new AnimalModel{Name = "Cat", Image="https://tse3.mm.bing.net/th?id=OIP.PpXYnCYEVMuPIBkn15PFZQHaFj&pid=Api&P=0&h=220", Group=AnimalModel.Category.Land},
                new AnimalModel{Name = "Fish", Image="https://tse1.mm.bing.net/th?id=OIP.xXWtbngf9cCfbHhPCgs1qwHaFj&pid=Api&P=0&h=220", Group=AnimalModel.Category.Water},
                new AnimalModel{Name = "Parrot", Image="https://tse2.mm.bing.net/th?id=OIF.BCKbKN9iEA%2bPzSB6pa7QRQ&pid=Api&P=0&h=220", Group=AnimalModel.Category.Air}
            };
            myCarouselView.ItemsSource = animals;
        }

        private void myCarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            try
            {
                var prev = e.PreviousItem as AnimalModel;
                var curr = e.CurrentItem as AnimalModel;
                previousItem.Text = $"Previous Item: {prev.Name}";
                currentItem.Text = $"Current Item: {curr.Name}";
            }
            catch { }
        }
    }
}
