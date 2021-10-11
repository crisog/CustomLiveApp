using System;
using Android.Views;
using Android.Content;
using Android.Runtime;
using CustomLiveApp.Models;
using Xamarin.Forms.Internals;
using Android.App;
using CustomLiveApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientationService))]
namespace CustomLiveApp.Droid
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        private readonly IWindowManager _windowManager;

        public DeviceOrientationService()
        {
            _windowManager = Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
        }

        public Orientation GetOrientation()
        {
            switch (_windowManager.DefaultDisplay.Rotation)
            {
                case SurfaceOrientation.Rotation0:
                    return Orientation.PortraitUp;
                case SurfaceOrientation.Rotation180:
                    return Orientation.PortraitDown;
                case SurfaceOrientation.Rotation90:
                    return Orientation.LandscapeLeft;
                case SurfaceOrientation.Rotation270:
                    return Orientation.LandscapeRight;
                default:
                    return Orientation.None;
            }
        }
    }
}
