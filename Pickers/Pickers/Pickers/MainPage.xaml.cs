using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pickers
{
    public partial class MainPage : ContentPage
    {
        List<CompanyModel> companyList = new List<CompanyModel>();
        public MainPage()
        {
            InitializeComponent();
            ceoPicker.Items.Add("Ace");
            ceoPicker.Items.Add("Jester");
            ceoPicker.Items.Add("Alicante");
            ceoPicker.Items.Add("Ace Jester");
            ceoPicker.Items.Add("Ace Jester Alicante");

            companyList.Add(new CompanyModel
            {
                Name = "Walmart",
                Logo = "https://s.yimg.com/fz/api/res/1.2/Ts_On1_5F0JSWy8bMxXx2g--~C/YXBwaWQ9c3JjaGRkO2ZpPWZpdDtoPTI0MDtxPTgwO3c9MjQw/https://s.yimg.com/zb/imgv1/6dbe4582-929e-30be-8ecc-9fe5050ad3b0/t_500x300",
                Description = "Largest Company in the world"
            });
            companyList.Add(new CompanyModel
            {
                Name = "Amazon",
                Logo = "https://s.yimg.com/fz/api/res/1.2/Hhy.C7Wid6WzEyupz7r53Q--~C/YXBwaWQ9c3JjaGRkO2ZpPWZpdDtoPTI0MDtxPTgwO3c9MjQw/https://s.yimg.com/zb/imgv1/c3132a48-f61b-36b9-8788-fc36b1395833/t_500x300",
                Description = "Amazon, Online shopping store"
            });
            companyList.Add(new CompanyModel
            {
                Name = "Apple",
                Logo = "https://s.yimg.com/fz/api/res/1.2/8DP.pEvw8H39uWAoQGlDZg--~C/YXBwaWQ9c3JjaGRkO2ZpPWZpdDtoPTI0MDtxPTgwO3c9MjQw/https://s.yimg.com/zb/imgv1/2cc2074d-9408-3c85-a3a8-6bc85315781d/t_500x300",
                Description = "Company that created iPhone"
            });
            companyPicker.ItemsSource = companyList;
        }

        private void companyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCompany = companyPicker.SelectedIndex;
            Logo.Source = companyList[selectedCompany].Logo;
            lblDescription.Text = companyList[selectedCompany].Description;
        }

    }
}
