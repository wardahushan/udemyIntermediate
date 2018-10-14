using System.Collections.Generic;

namespace UdemyIntermediate
{
    public interface IWorkflow
    {
        void AddActivity(IActivity workflowItem);

        void RemoveActivity(IActivity workflowItem);

        IEnumerable<IActivity> GetActivities();
    }
}
