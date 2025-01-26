using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PUP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert!", "You have been alerted!", "OK");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Question", "Would you like to play?", "Yes", "No");
            Button2.Text = result.ToString();
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel",
                null, "Copy Link", "Email", "Twitter", "Facebook");
            Button3.Text = action;
        }

        private async void Button4_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question?", "What is your age?",
                maxLength: 2, keyboard: Keyboard.Numeric);
            Button4.Text = result;
        }
    }
}
