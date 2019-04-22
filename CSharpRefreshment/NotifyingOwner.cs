using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    class NotifyingOwner : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notifying Owner");
        }
    }
}
