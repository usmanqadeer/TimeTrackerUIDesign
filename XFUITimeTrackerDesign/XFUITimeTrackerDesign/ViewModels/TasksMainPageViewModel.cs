using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XFUITimeTrackerDesign.Models;
using XFUITimeTrackerDesign.Services;

namespace XFUITimeTrackerDesign.ViewModels
{
    public class TasksMainPageViewModel : BaseViewModel
    {
        private ObservableCollection<TasksModel> tasksList;
        public ObservableCollection<TasksModel> TaskstList
        {
            get { return tasksList; }
            set
            {
                tasksList = value;
                OnPropertyChanged();
            }
        }
        public TasksMainPageViewModel()
        {
            TaskstList = new ObservableCollection<TasksModel>();
            AddItem();
        }
        private void AddItem()
        {
            var allTasks = MockDataStore.AddItemAsync();
            foreach (var item in allTasks)
            {
                TaskstList.Add(item);
            }
           
        }
    }
}
