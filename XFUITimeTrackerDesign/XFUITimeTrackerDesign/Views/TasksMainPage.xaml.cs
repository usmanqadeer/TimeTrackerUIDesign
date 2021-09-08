using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFUITimeTrackerDesign.ViewModels;

namespace XFUITimeTrackerDesign.Views
{
    public partial class TasksMainPage : ContentPage
    {
        public TasksMainPage()
        {
            InitializeComponent();
            this.BindingContext = new TasksMainPageViewModel(true);
        }

        private async void listTap_Tapped(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new TasksDetailsPage());
        }
    }
}