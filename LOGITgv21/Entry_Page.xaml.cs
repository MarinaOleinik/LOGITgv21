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
    public partial class Entry_Page : ContentPage
    {
        Editor ed;
        Button btn;
        public Entry_Page()
        {
            ed = new Editor
            {
                Placeholder = "Sisesta siia tekst",
                BackgroundColor = Color.White,
                TextColor = Color.Plum
            };
            btn = new Button
            {
                Text="Tagasi"
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { ed , btn},
                BackgroundColor = Color.Pink
            };
            Content= st;
            btn.Clicked += Btn_Clicked;
    }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}