using Syncfusion.DataSource;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFUITimeTrackerDesign.Models;

namespace XFUITimeTrackerDesign.Helpers
{
    public class SfListViewGroupingBehavior : Behavior<Syncfusion.ListView.XForms.SfListView>
    {

        #region Fields

        private Syncfusion.ListView.XForms.SfListView ListView;

        #endregion

        #region Overrides
        protected override void OnAttachedTo(Syncfusion.ListView.XForms.SfListView bindable)
        {
            ListView = bindable;
            ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "AddDate",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as TasksModel);
                    return item.AddDate.ToString();
                },
            });
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Syncfusion.ListView.XForms.SfListView bindable)
        {
            ListView = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

    }
}
