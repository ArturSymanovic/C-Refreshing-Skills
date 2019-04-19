using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    class Stopwatch
    {
        private bool _isStarted;
        private bool _isStartedOnce;
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _duration;

        public Stopwatch()
        {
            _isStarted = false;
            _isStartedOnce = false;
        }

        public void Start()
        {
            if (_isStarted) throw new InvalidOperationException("Stopwatch has been already started");
            _isStarted = true;
            _isStartedOnce = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!_isStarted) throw new InvalidOperationException("Stopwatch must be started first");
            _endTime = DateTime.Now;
            _duration = _endTime.Subtract(_startTime);
            _isStarted = false;
        }

        public TimeSpan GetDuration()
        {
            if (!_isStartedOnce) throw new InvalidOperationException("Stopwatch has never been started. Duration is not available.");
            if (_isStarted) throw new InvalidOperationException("Stopwatch must be stopped first.Duration is not available.");
            return _duration;
        }
    }
}
