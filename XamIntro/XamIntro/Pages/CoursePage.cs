using Xamarin.Forms;
using XamIntro.Models;

namespace XamIntro.Pages
{
    public class CoursePage : ContentPage
    {
        public CoursePage(PluralsightCourse course)
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            BackgroundColor = Color.Gray;

            Title = course.TitleShort;

            var titleLabel = new Label
            {
                Text = course.Title,
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };

            var authorLabel = new Label
            {
                Text = course.Author,
                Font = Font.SystemFontOfSize(NamedSize.Small)
            };

            var descriptionLabel = new Label
            {
                Text = course.Description,
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Spacing = 10,
                    Children =
                    {
                        titleLabel,
                        authorLabel,
                        descriptionLabel
                    }
                }
            };
        }
    }
}
