using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LOGITgv21
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoxView_Page : ContentPage
    {
        public BoxView_Page()
        {
            BoxView box = new BoxView
            {
                Color = Color.FromRgb(0, 0, 0),
                CornerRadius = 15,
                WidthRequest = 100,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center

            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { box }
            };
            Content= st;
        }
    }
}