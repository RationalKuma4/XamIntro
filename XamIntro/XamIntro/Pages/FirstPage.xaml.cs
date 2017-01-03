using System;
using Xamarin.Forms;

namespace XamIntro.Pages
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            boxViewColor.Color = Color.Black;
        }

        private void OnColorSlideChanged(object sneder, EventArgs e)
        {
            var red = sliderRed.Value;
            var blue = sliderBlue.Value;
            var green = sliderGreen.Value;

            boxViewColor.Color = Color.FromRgb(red, green, blue);

        }
    }
}
