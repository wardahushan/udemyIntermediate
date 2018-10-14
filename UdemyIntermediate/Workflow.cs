using System.Collections.Generic;

namespace UdemyIntermediate
{
    public class Workflow : IWorkflow
    {
        private List<IActivity> workflowList;

        // Constructor to initialise a workflow with multiple activities
        public Workflow(List<IActivity> workflow)
        {
            workflowList = workflow;
        }

        // Constructor to initialise a workflow with just one acitivity
        public Workflow(IActivity workflowItem)
        {
            workflowList.Add(workflowItem);
        }

        // Constructor to initialise an empty workflow 
        public Workflow()
        {
            workflowList = new List<IActivity>();
        }

        public void AddActivity(IActivity workflowItem)
        {
            workflowList.Add(workflowItem);
        }

        public void RemoveActivity(IActivity workflowItem)
        {
            workflowList.Remove(workflowItem);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return workflowList;
        }
    }
}
