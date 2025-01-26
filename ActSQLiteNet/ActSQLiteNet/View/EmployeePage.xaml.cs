using ActSQLiteNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ActSQLiteNet.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmployeePage : ContentPage
	{
        public EmployeePage ()
		{
			InitializeComponent ();
        }
		protected override async void OnAppearing()
		{
			try
			{
				base.OnAppearing();
				myCollectionView.ItemsSource = await App.MyDataBase.ReadEmployee();
			}
			catch { }
		}

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new EmployeeDetail());
        }

        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
			var item = sender as SwipeItem;
			var emp = item.CommandParameter as EmployeeModel;
			await Navigation.PushAsync (new EmployeeDetail(emp));
        }

        private async void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var emp = item.CommandParameter as EmployeeModel;
			var result = await DisplayAlert("Delete", $"Delete {emp.Name} from the database","Yes","No");
			if (result)
			{
				await App.MyDataBase.DeleteEmployee(emp);
				myCollectionView.ItemsSource = await App.MyDataBase.ReadEmployee();
			}
        }

        private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
			if (string.IsNullOrWhiteSpace(e.NewTextValue)) 
			{
				myCollectionView.ItemsSource = await App.MyDataBase.ReadEmployee(); 
			} else
			myCollectionView.ItemsSource = await App.MyDataBase.Search(e.NewTextValue);
        }

    }
}