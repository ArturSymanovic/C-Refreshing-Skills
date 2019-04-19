using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdOn;
        private int _votes;

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _createdOn = DateTime.Now;
            _votes = 0;
        }

        public void UpVote()
        {
            _votes++;
        }

        public void DownVote()
        {
            _votes--;
        }

        public int Votes
        {
            get
            {
                return _votes;
            }
        }

        public string Title{ get { return _title; } }
        public string Description { get { return _description; } }
        public DateTime CreatedOn { get { return _createdOn; } }
    }
}
