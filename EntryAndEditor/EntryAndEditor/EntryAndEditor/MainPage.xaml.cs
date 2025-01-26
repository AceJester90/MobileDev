using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntryAndEditor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myListView.ItemsSource = Student.List;
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewStudentPage());
        }
    }
}
