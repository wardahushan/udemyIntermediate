using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIntermediate
{
    public class Stopwatch
    {
        private bool stopwatchStarted;
        private DateTime startTime;
        private List<TimeSpan> durations = new List<TimeSpan>();  

        public void Start()
        {
            ValiidateStopwatchStart();
            stopwatchStarted = true;
            startTime = DateTime.Now; 
        }

        public void Stop()
        {
            ValiidateStopwatchStop();
            stopwatchStarted = false;
            durations.Add(DateTime.Now - startTime);
        }

        public List<TimeSpan> Durations()
        {
            return durations;
        }

        private void ValiidateStopwatchStop()
        {
            if (!stopwatchStarted)
            {
                throw new InvalidOperationException("Failed: stopwatch has not been started. Cannot execute method Stop() if stopwatch is not running.");
            }
        }

        private void ValiidateStopwatchStart()
        {
            if (stopwatchStarted)
            {
                throw new InvalidOperationException("Failed: stopwatch has already been started. Cannot execute method Start() while stopwatch is running.");
            }
        }
    }
}
