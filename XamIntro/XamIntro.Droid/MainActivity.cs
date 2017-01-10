using Android.App;
using Android.Content.PM;
using Android.OS;
using XamIntro.Contracts;
using Xamarin.Media;
using Xamarin.Forms;
using Android.Content;

[assembly: Dependency(typeof(XamIntro.Droid.MainActivity))]

namespace XamIntro.Droid
{
    [Activity(Label = "XamIntro", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IPictureTaker
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        void IPictureTaker.SnapPic()
        {
            var activityContext = Forms.Context as Activity;
            var _picker = new MediaPicker(activityContext);
            var camerOtions = new StoreCameraMediaOptions
            {
                DefaultCamera = CameraDevice.Rear,
                Directory = "",
                Name = "Default.jpg"
            };

            var intent = _picker.GetTakePhotoUI(camerOtions);

            activityContext.StartActivityForResult(intent, 1);
        }

        protected override async void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Canceled)
                return;

            var mediaFile = await data.GetMediaFileExtraAsync(Forms.Context);
            MessagingCenter.Send<IPictureTaker, string>(this, "FotoTomada", mediaFile.Path);
        }
    }
}

