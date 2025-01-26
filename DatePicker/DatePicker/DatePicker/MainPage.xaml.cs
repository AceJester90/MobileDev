using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatePicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void startDate_DateSelected(object sender, DateChangedEventArgs e)
        {
            TimeSpan timeSpan = endDate.Date - startDate.Date;
            label.Text = $"Total day/s: {timeSpan.Days}";
        }

        private void endDate_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}
