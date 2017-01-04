using Xamarin.Forms;
using XamIntro.Models;

namespace XamIntro.Pages
{
    public class ListViewOne : ContentPage
    {
        public ListViewOne()
        {
            var classNames = new[]
            {
                "String one",
                "String two",
                "String three",
                "Strign four",
                "String five"
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var lisView = new ListView();
            //lisView.ItemsSource = classNames;
            lisView.ItemsSource = PluralsightCourse.GetCourseList();
            lisView.ItemSelected += (sende, e) =>
            {
                if (e.SelectedItem != null)
                {
                    lisView.SelectedItem = null;
                }
            };

            Content = new StackLayout
            {
                Children =
                {
                    lisView
                }
            };
        }
    }
}
