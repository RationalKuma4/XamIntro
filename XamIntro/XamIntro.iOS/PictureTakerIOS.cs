using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Media;
using XamIntro.Contracts;

//[assembly: DefaultDependency(typeof(XamIntro.iOS.PictureTakerIOS))]

namespace XamIntro.iOS
{
    class PictureTakerIOS : IPictureTaker
    {
        public async void SnapPic()
        {
            var cameraPtions = new StoreCameraMediaOptions
            {
                DefaultCamera = CameraDevice.Rear,
                Directory = "",
                Name = "Default"
            };
            var _picker = new MediaPicker();
            //var mediaFile = _picker.TakePhotoAsync(cameraPtions);
            var mediaFile = await _picker.PickPhotoAsync();

            MessagingCenter.Send<IPictureTaker, string>(this, "FotoTomada", mediaFile.Path);
        }
    }
}
