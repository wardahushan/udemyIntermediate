using System;
using System.Threading;

namespace UdemyIntermediate
{
    public abstract class DbConnection
    {
        private readonly string connectionString;
        protected bool connectionOpened = false; 

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        public TimeSpan TimeOut { get; set; }

        protected void CheckOpenConnection()
        {
            if (!connectionOpened)
            {
                throw new NotSupportedException("Failed: Failed to close connection since there is no active connection.");
            }
        }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new NotSupportedException("Failed: Connection string must be provided in order to initialise the Database connection.");
            }

            this.connectionString = connectionString;
            this.TimeOut = TimeSpan.FromSeconds(10); // default value for timeout; user can udpate from outside the program if they need to 
        }

        protected void AttemptConnection()
        {
            Random randomNumberGenerator = new Random();
            int timeForConnection = randomNumberGenerator.Next(11); // random number between 1 and 10;

            Console.WriteLine("Attempting to establish connection...");
            Thread.Sleep(timeForConnection * 1000);

            if (timeForConnection > TimeOut.Seconds)
            {
                throw new TimeoutException($"Failed: Connection could not be established within the time out of {TimeOut.Seconds} seconds."); 
            }

            connectionOpened = true;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();

    }
}