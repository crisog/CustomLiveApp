using System;
using CustomLiveApp.Models;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(CustomLiveApp.iOS.DeviceOrientationService))]
namespace CustomLiveApp.iOS
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public Orientation GetOrientation()
        {
            switch (UIDevice.CurrentDevice.Orientation)
            {
                case UIDeviceOrientation.LandscapeLeft:
                    return Orientation.LandscapeLeft;
                case UIDeviceOrientation.LandscapeRight:
                    return Orientation.LandscapeRight;
                case UIDeviceOrientation.Portrait:
                    return Orientation.PortraitUp;
                case UIDeviceOrientation.PortraitUpsideDown:
                    return Orientation.PortraitDown;
                default:
                    return Orientation.None;
            }
        }
    }
}

