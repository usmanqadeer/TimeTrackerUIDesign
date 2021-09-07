using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFUITimeTrackerDesign.Views
{
    public partial class TasksMainPage : ContentPage
    {
        public TasksMainPage()
        {
            InitializeComponent();
        }

        private async void listTap_Tapped(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new TasksDetailsPage());
        }
    }
}