using System;
using System.Collections.Generic;

namespace UdemyIntermediate
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunStopWatchExercise();
            RunStackOverflowExercise();
            RunStackExercise();
            RunDatabaseConnectionExercise();
            RunDatabaseCommandExercise();
            RunWorkflowEngineExercise();
        }

        private static void RunWorkflowEngineExercise()
        {
            List<IActivity> workflowActivities = new List<IActivity>();
            workflowActivities.Add(new UploadVideo());
            workflowActivities.Add(new EncodeVideo());
            workflowActivities.Add(new NotifyUploader());

            Workflow workflow = new Workflow(workflowActivities);
            workflow.AddActivity(new UpdateDatabase());

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }

        private static void RunDatabaseCommandExercise()
        {
            DbConnection dbConnection = new OracleConnection("Connection");
            DbCommand dbCommand = new DbCommand(dbConnection, "Instruction");
            dbCommand.Execute();
        }

        private static void RunDatabaseConnectionExercise()
        {
            SqlConnection databaseConnection = new SqlConnection("Connection to database");
            databaseConnection.TimeOut = new TimeSpan(0, 0, 5); // Update the timeout
            databaseConnection.OpenConnection();
            databaseConnection.CloseConnection();
        }

        private static void RunStackExercise()
        {
            Stack stack = new Stack();
            stack.Push(0); stack.Push(1); stack.Push(2);

            Console.WriteLine(stack.Pop()); Console.WriteLine(stack.Pop()); Console.WriteLine(stack.Pop());

            //Console.WriteLine(stack.Pop()); // try pop one more time 
            //stack.Push(null); // try add null
        }

        private static void RunStackOverflowExercise()
        {
            Post post = new Post("Learning encapsulation");
            post.Description = "This is my first exercise from Mosh's course learning how to apply the concepts of encapsulation.";
            // post.Description = "Trying to update the description here.";

            post.DownVote(); post.DownVote(); post.DownVote(); // 3 downvotes 
            post.Upvote(); post.Upvote(); post.Upvote(); post.Upvote(); post.Upvote(); // 5 upvotes 

            Console.WriteLine($"Post title: {post.Title}");
            Console.WriteLine($"Post description: {post.Description}");
            Console.WriteLine($"Post timestamp: {post.Timestamp}");
            Console.WriteLine($"Number of votes: {post.GetVotes()}");
        }

        private static void RunStopWatchExercise()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();

            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            stopwatch.Stop();

            Console.WriteLine($"Elapsed time(s) are:");
            foreach (TimeSpan duration in stopwatch.Durations())
            {
                Console.WriteLine(duration);
            }
        }
    }
}
