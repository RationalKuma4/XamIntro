using System.Linq;
using Xamarin.Forms;
using XamIntro.Models;

namespace XamIntro.Pages
{
    public class CourseMasterDetail : MasterDetailPage
    {
        public CourseMasterDetail()
        {
            var listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();

            listView.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail = new CoursePage(e.SelectedItem as PluralsightCourse);
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Courses",
                Content = listView
            };

            Detail = new CoursePage(PluralsightCourse.GetCourseList().First());
        }
    }
}
