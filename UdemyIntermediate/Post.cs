using System;

namespace UdemyIntermediate
{
    public class Post
    {
        private int votes;
        private readonly DateTime timestamp;
        private readonly string title;
        private string description; 

        public string Title { get => title; }
        public DateTime Timestamp { get => timestamp; }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description == null)
                {
                    description = value;
                }
                else
                {
                    throw new InvalidOperationException("Failed: post description has already been set. It cannot be changed.");
                }
            }
        }

        public Post(string title)
        {
            timestamp = DateTime.Now;
            this.title = title;
        }

        public void Upvote()
        {
            votes += 1;
        }

        public void DownVote()
        {
            votes -= 1;
        }

        public int GetVotes()
        {
            return votes;
        }

    }
}
