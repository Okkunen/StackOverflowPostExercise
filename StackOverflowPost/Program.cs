using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{

    class Program
    {
        static void Main(string[] args)
        {
            //Code for testing
            Post postTest = new Post("Test post", "Test description for post");
            postTest.Upvote();
            postTest.Upvote();
            Console.WriteLine(postTest);
            postTest.Downvote();
            Console.WriteLine(postTest);
            postTest.Downvote();
            postTest.Downvote();
            Console.WriteLine(postTest);
            Console.ReadLine();

        }
    }
}
