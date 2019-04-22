using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    class NotifyingWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notification to the Web Service");
        }
    }
}
