using System;
using CustomLiveApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomLiveApp.ViewModels
{
    public class DependencyServicePageViewModel
    {
        public Orientation Orientation { get; set; }

        public DependencyServicePageViewModel()
        {
            Orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();

        }

    }
}
