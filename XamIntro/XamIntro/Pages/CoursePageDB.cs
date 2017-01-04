using Xamarin.Forms;

namespace XamIntro.Pages
{
    class CoursePageDB : ContentPage
    {
        public CoursePageDB()
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            BackgroundColor = Color.Gray;

            SetBinding(TitleProperty, new Binding("TitleShort"));
            var titleLabel = new Label
            {
                //Text = course.Title,
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            var authorLabel = new Label
            {
                //Text = course.Author,
                Font = Font.SystemFontOfSize(NamedSize.Small)
            };

            authorLabel.SetBinding(Label.TextProperty, new Binding("Author"));
            var descriptionLabel = new Label
            {
                //Text = course.Description,
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };
            descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));

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
