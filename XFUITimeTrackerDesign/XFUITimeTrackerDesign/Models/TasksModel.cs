using System;

namespace XFUITimeTrackerDesign.Models
{
    public class TasksModel
    {
        public string Id { get; set; }
        public string AddDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TaskDescription { get; set; }
        public string NameSort => AddDate.ToString();
    }
}