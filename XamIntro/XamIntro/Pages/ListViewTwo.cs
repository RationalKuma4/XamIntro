using Xamarin.Forms;
using XamIntro.Models;

namespace XamIntro.Pages
{
    public class ListViewTwo : ContentPage
    {
        public ListViewTwo()
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

            var cell = new DataTemplate(typeof(TextCell));
            //cell.SetBinding(TextCell.TextProperty, new Binding("."));
            cell.SetBinding(TextCell.TextProperty, new Binding("Author"));
            cell.SetBinding(TextCell.DetailProperty, new Binding("Title"));

            cell.SetValue(TextCell.TextColorProperty, Color.Black);
            cell.SetValue(TextCell.DetailProperty, Color.Gray);

            lisView.ItemTemplate = cell;

            Content = lisView;
        }
    }
}
