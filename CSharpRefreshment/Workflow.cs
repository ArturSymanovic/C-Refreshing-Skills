using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    class Workflow
    {
        private readonly List<IActivity> _activities;
        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}
