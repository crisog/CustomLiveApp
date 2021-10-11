using System;
using System.Collections.Generic;
using CustomLiveApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomLiveApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DependencyServicePage : ContentPage
    {
        public DependencyServicePage()
        {
            InitializeComponent();
            BindingContext = new DependencyServicePageViewModel();
        }
    }
}
