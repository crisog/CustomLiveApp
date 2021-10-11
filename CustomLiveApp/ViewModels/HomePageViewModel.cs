using System;
using System.Windows.Input;
using CustomLiveApp.Views;
using Xamarin.Forms;

namespace CustomLiveApp.ViewModels
{
    public class HomePageViewModel
    {
        public ICommand DependencyServiceCommand { get; set; }
        public ICommand CustomRenderCommand { get; set; }
        public ICommand FocusedEffectCommand { get; set; }
        public ICommand PlatformSpecificCommand { get; set; }

        public HomePageViewModel()
        {
            DependencyServiceCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new DependencyServicePage());

            });

            CustomRenderCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new CustomRenderPage());

            });

            FocusedEffectCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new FocusedEffectPage());

            });

            PlatformSpecificCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new PlatformSpecificPage());

            });

        }
    }
}
