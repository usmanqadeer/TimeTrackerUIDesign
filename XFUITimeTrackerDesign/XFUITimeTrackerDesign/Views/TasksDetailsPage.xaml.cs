using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFUITimeTrackerDesign.ViewModels;

namespace XFUITimeTrackerDesign.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TasksDetailsPage : ContentPage
    {
        public TasksDetailsPage()
        {
            InitializeComponent();
            this.BindingContext = new TasksMainPageViewModel(true);
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync(false);
        }
    }
}