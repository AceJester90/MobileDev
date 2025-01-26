using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nav_Hierarchical
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class about : ContentPage
    {
        public about()
        {
            InitializeComponent();
        }

        async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}