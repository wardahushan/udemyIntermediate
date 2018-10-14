namespace UdemyIntermediate
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IActivity workItem in workflow.GetActivities())
            {
                workItem.Execute();
            }
        }
    }
}
