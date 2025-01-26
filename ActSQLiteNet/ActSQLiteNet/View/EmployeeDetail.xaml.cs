using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using ActSQLiteNet.Model;
using Plugin.Media.Abstractions;
using Plugin.Media;

namespace ActSQLiteNet.View
{
    public class IntegerEntry : Entry
    {
        public IntegerEntry()
        {
            this.TextChanged += OnTextChanged;
        }

        void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            if (string.IsNullOrEmpty(entry.Text))
                return;

            if (!char.IsDigit(entry.Text[entry.Text.Length - 1]))
            {
                entry.Text = entry.Text.Remove(entry.Text.Length - 1);
            }
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeDetail : ContentPage
    {
        Model.EmployeeModel _employee;
        byte[] imageData;

        public EmployeeDetail()
        {
            InitializeComponent();
        }

        public EmployeeDetail(Model.EmployeeModel employee)
        {
            InitializeComponent();
            Title = "Edit Information";
            _employee = employee;
            nameEntry.Text = employee.Name;
            addressEntry.Text = employee.Address;
            priceEntry.Text = employee.Price.ToString(); 
            nameEntry.Focus();
        }

        private async void btnUpload_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("No Gallery", "Gallery is not available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.Medium,
                CompressionQuality = 92
            });

            if (file == null)
                return;

            using (var memoryStream = new System.IO.MemoryStream())
            {
                file.GetStream().CopyTo(memoryStream);
                imageData = memoryStream.ToArray();
            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameEntry.Text) || string.IsNullOrWhiteSpace(addressEntry.Text) || string.IsNullOrWhiteSpace(priceEntry.Text))
            {
                await DisplayAlert("Invalid", "Blank or WhiteSpace value is invalid!", "OK");
            }
            else if (_employee != null)
            {
                UpdateEmployee();
            }
            else
            {
                AddNewEmployee();
            }
        }

        async void AddNewEmployee()
        {
            int price;
            if (int.TryParse(priceEntry.Text, out price))
            {
                await App.MyDataBase.CreateEmployee(new Model.EmployeeModel
                {
                    Name = nameEntry.Text,
                    Address = addressEntry.Text,
                    ImageData = imageData,
                    Price = price
                });
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Invalid", "Price must be a valid number!", "OK");
            }
        }

        async void UpdateEmployee()
        {
            int price;
            if (int.TryParse(priceEntry.Text, out price))
            {
                _employee.Name = nameEntry.Text;
                _employee.Address = addressEntry.Text;
                _employee.ImageData = imageData;
                _employee.Price = price;

                await App.MyDataBase.UpdateEmployee(_employee);
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Invalid", "Price must be a valid number!", "OK");
            }
        }

    }
}
