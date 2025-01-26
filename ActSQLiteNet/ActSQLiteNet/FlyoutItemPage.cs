using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ActSQLiteNet
{
    public class FlyoutItemPage
    {
        public string Title { get; set; }
        public Type TargetPage { get; set; }
        public ImageSource Image { get; set; }
        public FlyoutItemPage()
        {
            
        }

        public FlyoutItemPage(string title, string imageResource, Type targetPage)
        {
            Title = title;
            Image = ImageSource.FromResource(imageResource);
            TargetPage = targetPage;
        }
    }
}
