using System.Linq;
using Xamarin.Forms;
using XamIntro.Models;

namespace XamIntro.Pages
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            Title = "Menu Principal";

            var button1 = new Button { Text = "Primer Pagina" };
            button1.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new CoursePage(PluralsightCourse.GetCourseList().First()));
            };

            var button2 = new Button { Text = "Master / Detail" };
            button2.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new CourseMasterDetail());
            };

            var button3 = new Button { Text = "Master Binding" };
            button3.Clicked += (o, e) =>
            {
                Navigation.PushAsync(new CourseMasterDetailDB());
            };

            var button4 = new Button { Text = "Tabbed" };
            button4.Clicked += (o, e) =>
            {
                var page = new TabbedPage();
                page.Title = "Courses";
                foreach (var item in PluralsightCourse.GetCourseList())
                {
                    var coursePage = new CoursePageDB();
                    coursePage.BindingContext = item;
                    page.Children.Add(coursePage);
                }
                Navigation.PushAsync(page);
            };

            var button5 = new Button { Text = "Carousel" };
            button5.Clicked += (o, e) =>
            {
                var page = new CarouselPage();
                page.Title = "Courses";
                foreach (var item in PluralsightCourse.GetCourseList())
                {
                    var coursePage = new CoursePageDB();
                    coursePage.BindingContext = item;
                    page.Children.Add(coursePage);
                }
                Navigation.PushAsync(page);
            };

            Content = new StackLayout
            {
                Spacing = 10,
                Children = { button1, button2, button3, button4, button5 }
            };
        }
    }
}
