using System;
using System.Collections.Generic;
using XFUITimeTrackerDesign.Models;

namespace XFUITimeTrackerDesign.Services
{
    public class MockDataStore{
        public MockDataStore()
        {
           
        }

        public static List<TasksModel> AddItemAsync()
        {
            List<TasksModel>  items = new List<TasksModel>()
            {
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "5:00",AddDate ="Sat 18Feb",EndDate="7:30",TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "7:00",AddDate ="Sat 18Feb",EndDate="6:30", TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "3:00", AddDate ="Sat 18Feb",EndDate="2:00",TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "1:00",AddDate ="Sat 18Feb",EndDate="4:00", TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "2:23:0",AddDate ="Sun 19 Feb",EndDate="6:00", TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "3:30:00",AddDate ="Sun 19 Feb",EndDate="1:00", TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "3:00", AddDate ="Sat 28Feb",EndDate="2:00",TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "1:00",AddDate ="Sat 28Feb",EndDate="4:00", TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "2:23:0",AddDate ="Sat 28Feb",EndDate="6:00", TaskDescription="This is an item description." },
                new TasksModel { Id = Guid.NewGuid().ToString(), StartDate = "3:30:00",AddDate ="Sat 28Feb",EndDate="1:00", TaskDescription="This is an item description." }
            };
            return items;
        }
    }
}