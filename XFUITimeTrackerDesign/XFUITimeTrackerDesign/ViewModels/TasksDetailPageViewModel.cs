using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using XFUITimeTrackerDesign.Models;
using XFUITimeTrackerDesign.Services;
using Xamarin.Forms;

namespace XFUITimeTrackerDesign.ViewModels
{
    public class TasksDetailPageViewModel : BaseViewModel
    {
        public ObservableCollection<TasksModel> TasksModel { get; set; }
        public Command CloseTasksDetailsPageCommand { get; set; }
        public TasksDetailPageViewModel()
        {
            TasksModel = new ObservableCollection<TasksModel>();
            CloseTasksDetailsPageCommand = new Command(() => CloseTasksDetailsPage());
            GetTasks();
        }

        private async void CloseTasksDetailsPage()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync(false);
        }

        private void GetTasks()
        {
            var tasks = MockDataStore.AddItemAsync();
            foreach (var item in tasks)
            {
                TasksModel.Add(item);
            }
        }
    }
}
