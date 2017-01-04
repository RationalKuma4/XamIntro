using Xamarin.Forms;

namespace XamIntro.Controls
{
    class CellCourse : ViewCell
    {
        public CellCourse()
        {
            var titleLabel = new Label
            {
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium)
            };

            var aouthorLabel = new Label
            {
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));
            aouthorLabel.SetBinding(Label.TextProperty, new Binding("Author"));

            View = new StackLayout
            {
                Children =
                {
                    titleLabel,
                    aouthorLabel
                },
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}

