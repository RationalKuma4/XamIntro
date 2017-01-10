using Xamarin.Forms;
using XamIntro.Contracts;

namespace XamIntro.Pages
{
    public class TheLastPage : ContentPage
    {
        public TheLastPage()
        {
            Padding = new Thickness(20, Device.OnPlatform(40, 20, 0), 10, 20);

            var theButton = new Button
            {
                Text = "Tomar Foto"
            };
            theButton.Clicked += (sender, e) =>
            {
                IPictureTaker pictureTaker = DependencyService.Get<IPictureTaker>();
                pictureTaker.SnapPic();
            };

            var imageTaken = new Image
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            MessagingCenter.Subscribe<IPictureTaker, string>(this, "FotoTomada",
                (sender, arg) => { imageTaken.Source = ImageSource.FromFile(arg); });

            Content = new StackLayout
            {
                Spacing = 10,
                Children =
                {
                    theButton,
                    imageTaken
                }
            };
        }
    }
}
