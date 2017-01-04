using Xamarin.Forms;

namespace XamIntro.Pages
{
    public class RelaView : ContentPage
    {
        public RelaView()
        {
            var lay = new RelativeLayout();
            var labelOne = new Label
            {
                Text = "This is a line of text"
            };
            var labelTwo = new Label
            {
                Text = "Another line of text"
            };
            var labeThree = new Label
            {
                Text = "More much text here"
            };

            lay.Children.Add(labelOne, Constraint.Constant(0),
                Constraint.RelativeToParent(parent => { return parent.Height / 2; }));
            lay.Children.Add(labelTwo,
                Constraint.RelativeToView(labelOne, (parent, otherView) => { return otherView.X + otherView.Width; }),
                Constraint.RelativeToView(labelOne, (parent, otherView) => { return otherView.Y - otherView.Height; }));
            lay.Children.Add(labeThree,
                Constraint.RelativeToView(labelTwo, (parent, otherView) => { return (otherView.X + otherView.Width) - labeThree.Width; }),
                Constraint.RelativeToView(labelOne, (parent, otherVire) => { return otherVire.Y; }));

            labeThree.SizeChanged += (o, e) => { lay.ForceLayout(); };
            Content = lay;

        }
    }
}
