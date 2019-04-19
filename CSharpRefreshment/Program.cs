using System;
using System.Collections.Generic;
using System.Text;
using CSharpRefreshment.Math;
using System.IO;
using System.Threading;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("a", "b");
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("Post Title: {0}\nPost Description: {1}\nPost Created On: {2}\nPost Rating: {3}",
                post.Title, post.Description,post.CreatedOn,post.Votes);
        }
    }
}