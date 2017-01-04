using Xamarin.Forms;
using XamIntro.Controls;
using XamIntro.Models;

namespace XamIntro.Pages
{
    public class ListViewThree : ContentPage
    {
        public ListViewThree()
        {
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            var lisView = new ListView();
            lisView.ItemsSource = PluralsightCourse.GetCourseList();

            lisView.ItemTemplate = new DataTemplate(typeof(CellCourse));

            Content = lisView;
        }
    }
}
