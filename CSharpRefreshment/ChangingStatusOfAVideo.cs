using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    class ChangingStatusOfAVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change Status of a video n DB");
        }
    }
}
