using System;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Score { get; private set; } = 0;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedDate = DateTime.UtcNow;
        }

        public void Upvote()
        {
            Score++;
        }

        public void Downvote()
        {
            Score--;
        }
        public override string ToString()
        {
            string output = String.Format("Post title: {0}, post description: {1}, Current vote: {2}, post was created on {3}.", Title, Description, Score, CreatedDate);
            return output;
        }
    }
}
