using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EntryAndEditor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewStudentPage : ContentPage
    {
        public NewStudentPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = name.Text,
                Course = course.Text,
                EmailAdd = email.Text,
                MobileNumber = contact.Text,
                Password = password.Text,
                Remarks = remarks.Text
            };
            Student.List.Add(student);
            await Navigation.PopAsync();
        }
    }
}