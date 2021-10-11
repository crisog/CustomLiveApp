using System;
using System.Windows.Input;
using CustomLiveApp.Views;
using Xamarin.Forms;

namespace CustomLiveApp.ViewModels
{
    public class HomePageViewModel
    {
        public ICommand DependencyServiceCommand { get; set; }
        public HomePageViewModel()
        {
            DependencyServiceCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new DependencyServicePage());

            });

        }
    }
}
