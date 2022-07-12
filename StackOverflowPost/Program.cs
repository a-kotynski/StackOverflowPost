using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://drive.google.com/open?id=106X9o_Y0jR80vw50RZpiph24LKRRY0JV&authuser=arzej2k%40gmail.com&usp=drive_fs
// Exercise 2: Design a StackOverflow Post
namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public List<string> UpVoteList { get; set; }
        public List<string> DownVoteList { get; set; }
        public Post(string postTitle, string postDesc, DateTime postTime)
        {
            this.Title = postTitle;
            this.Description = postDesc;
            this.CreationTime = postTime;
        }
        public void UpVote()
        {
            Console.WriteLine("Upvote!");
            List<string> upVoteList = new List<string>();
            while (true)
            {
                var userUpVoteInput = Console.ReadLine();
                upVoteList.Add(userUpVoteInput);
                if (userUpVoteInput == "exit")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("\nUpvote Count: " + upVoteList.Count);
        }
        public void DownVote()
        {
            Console.WriteLine("Downvote!");
            List<string> downVoteList = new List<string>();
            while (true)
            {
                var userDownVoteInput = Console.ReadLine();
                downVoteList.Add(userDownVoteInput);
                if (userDownVoteInput == "exit")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("\nDownvote Count: " + downVoteList.Count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Post Title: ");
            var title = Console.ReadLine();

            Console.WriteLine("Post Description: ");
            var description = Console.ReadLine();

            var creationTime = DateTime.Now;

            Post post = new Post(title, description, creationTime);
            
            Console.WriteLine($"Post title: \"{post.Title}\"\n" +
                $"Post description: \"{post.Description}\"\n" +
                $"Post creation time: \"{post.CreationTime}\"\n");
            
            Console.WriteLine("Vote time! Type 'exit' to exit.");
            post.UpVote();
            post.DownVote();
        }
    }
}