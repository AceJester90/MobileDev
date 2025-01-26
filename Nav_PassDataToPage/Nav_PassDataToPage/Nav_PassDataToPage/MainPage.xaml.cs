using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nav_PassDataToPage.DataModel;
using Xamarin.Forms;

namespace Nav_PassDataToPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<Student> myList = new List<Student>
            {
               new Student{Name="Maloi", Status="Enrolled", Address="Batangas", Course="Education", ImageUrl="https://nylonmanila.com/wp-content/uploads/2023/11/IMG_0465.jpg"},
               new Student{Name="Aiah", Status="Enrolled", Address="Cebu", Course="Education", ImageUrl="https://i.pinimg.com/736x/1e/49/37/1e49371209e85091c5fddfa4837ef8f1.jpg"},
               new Student{Name="Mikha", Status="Enrolled", Address="Manila", Course="Education", ImageUrl="https://i.pinimg.com/originals/83/3a/57/833a57296ba9049759bc495dcb9880fa.jpg"},
               new Student{Name="Colet", Status="Enrolled", Address="Bohol", Course="Education", ImageUrl="https://asset-ent.abs-cbn.com/album/entertainment/2021/05/29/Bini-Born-To-Win/Bini-Colet-5.jpg"},
               new Student{Name="Sheena", Status="Enrolled", Address="Isabela", Course="Education", ImageUrl="https://images.summitmedia-digital.com/preview/images/2022/03/16/bini-makeup-looks-insert2.jpg"}
            };
            myListView.ItemsSource = myList;
        }

        async void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var student = e.SelectedItem as Student;
            var studentPage = new StudentInfoPage();
            studentPage.BindingContext = student;
            await Navigation.PushAsync(studentPage);
        }
    }
}
