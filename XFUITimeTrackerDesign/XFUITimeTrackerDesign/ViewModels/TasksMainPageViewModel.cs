using MvvmHelpers;
using System;
using System.Collections.ObjectModel;
using System.Timers;
using Xamarin.Forms;
using XFUITimeTrackerDesign.Models;
using XFUITimeTrackerDesign.Services;

namespace XFUITimeTrackerDesign.ViewModels
{
    public class TasksMainPageViewModel : BaseViewModel
    {
        public ObservableCollection<TasksModel> Tasks { get; set; }
        public ObservableCollection<Grouping<string, TasksModel>> TasksGrouped { get; set; }
        
        private double _ProgressValue;
        public double ProgressValue
        {
            get
            {
                return _ProgressValue;
            }
            set
            {
                _ProgressValue = value;
                OnPropertyChanged();
            }
        }
        private double _Minimum;
        public double Minimum
        {
            get
            {
                return _Minimum;
            }
            set
            {
                _Minimum = value;
                OnPropertyChanged();
            }
        }
        private double _Maximum;
        public double Maximum
        {
            get
            {
                return _ProgressValue;
            }
            set
            {
                _ProgressValue = value;
                OnPropertyChanged();
            }
        }
        private Timer time = new Timer();
        private bool timerRunning;
       
        public TasksMainPageViewModel(bool designData)
        {
            Minimum = 0;
            Maximum = 60;
            ProgressValue = 60;
            timerRunning = true;
            time.Start();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (ProgressValue > Minimum)
                {
                    ProgressValue--;
                    return true;
                }
                else if (ProgressValue == Minimum)
                {
                    time.Start();
                    timerRunning = false;
                    return false;
                }
                else
                {
                    return true;
                }
            });

            if (designData)
            {
                Tasks = MockDataStore.Tasks;
                TasksGrouped = MockDataStore.TasksGrouped;
            }
            else
            {
                //Setup web requests and such
            }
        }

        public bool IsBusy { get; set; }

        public int TasksCount => Tasks?.Count ?? 0;
    }
}
