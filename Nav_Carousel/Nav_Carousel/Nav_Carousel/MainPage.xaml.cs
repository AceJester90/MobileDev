using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Nav_Carousel.DataModel;

namespace Nav_Carousel
{
    public partial class MainPage : CarouselPage
    {
        ObservableCollection<StudentInfo> myList;

        public MainPage()
        {
            InitializeComponent();

            myList = new ObservableCollection<StudentInfo>
            {
                new StudentInfo{Name="Ace", Status = "Enrolled", ImageUrl = "https://i.imgur.com/7Sx7bNm.jpeg"},
                new StudentInfo{Name="Jester", Status = "Bounce na ako sir", ImageUrl = "https://media.tenor.com/images/8e4580922ccc51e61214f1cfb6be53ae/tenor.gif"}
            };

            ItemsSource = myList;
        }
    }
}
