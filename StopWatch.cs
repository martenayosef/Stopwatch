using System;

namespace Stopwatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;
         
        public void Start ()
        {
            if (!_isRunning)
            {
                _startTime = DateTime.Now;
                _isRunning = true;
            } 
        }

        public void Stop ()
        {
            if (_isRunning)
            {
                _endTime = DateTime.Now;
                _isRunning = false;
            }
        }
        public TimeSpan GetDuration ()
        {
            return _endTime - _startTime;
        }
    }
}
