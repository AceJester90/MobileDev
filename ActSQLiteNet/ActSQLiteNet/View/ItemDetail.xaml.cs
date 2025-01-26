using ActSQLiteNet.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ActSQLiteNet.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetail : ContentPage
    {
        public ItemDetail()
        {
            InitializeComponent();
        }

        public ItemDetail(EmployeeModel employee)
        {
            InitializeComponent();
            BindingContext = employee;
        }
    }
}
