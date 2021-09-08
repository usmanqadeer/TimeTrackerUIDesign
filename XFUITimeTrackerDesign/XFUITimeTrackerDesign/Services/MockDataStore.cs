using MvvmHelpers;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using XFUITimeTrackerDesign.Models;

namespace XFUITimeTrackerDesign.Services
{
    public class MockDataStore
    {
        public static ObservableCollection<Grouping<string, TasksModel>> TasksGrouped { get; set; }
        public static ObservableCollection<TasksModel> Tasks { get; set; }
        private static Random random;

        public static TasksModel GetRandomMonkey()
        {
            //var output = Newtonsoft.Json.JsonConvert.SerializeObject(Monkeys);
            return Tasks[random.Next(0, Tasks.Count)];
        }
        static MockDataStore()
        {
            random = new Random();
            Tasks = new ObservableCollection<TasksModel>();
            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "5:00",
                AddDate = "Sat 18Feb",
                EndDate = "7:30",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "7:00",
                AddDate = "Sat 18Feb",
                EndDate = "6:30",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "3:00",
                AddDate = "Sat 18Feb",
                EndDate = "2:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "3:00",
                AddDate = "Sat 18Feb",
                EndDate = "2:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "3:00",
                AddDate = "Sat 18Feb",
                EndDate = "2:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "1:00",
                AddDate = "Sat 18Feb",
                EndDate = "4:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "2:23:0",
                AddDate = "Sun 19 Feb",
                EndDate = "6:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "3:30:00",
                AddDate = "Sun 19 Feb",
                EndDate = "1:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "3:00",
                AddDate = "Sat 28Feb",
                EndDate = "2:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "1:00",
                AddDate = "Sat 28Feb",
                EndDate = "4:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "2:23:0",
                AddDate = "Sat 28Feb",
                EndDate = "6:00",
                TaskDescription = "This is an item description."
            });

            Tasks.Add(new TasksModel
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = "3:30:00",
                AddDate = "Sat 28Feb",
                EndDate = "1:00",
                TaskDescription = "This is an item description."
            });

            var sorted = from tasks in Tasks
                         orderby tasks.AddDate
                         group tasks by tasks.NameSort into tasksGroup
                         select new Grouping<string, TasksModel>(tasksGroup.Key, tasksGroup);

            TasksGrouped = new ObservableCollection<Grouping<string, TasksModel>>(sorted);
        }
    }
}