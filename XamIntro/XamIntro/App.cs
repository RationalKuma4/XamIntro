using Xamarin.Forms;
using XamIntro.Pages;

namespace XamIntro
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //var content = new ContentPage
            //{
            //    Title = "XamIntro",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};


            MainPage = new NavigationPage(new FirstPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
