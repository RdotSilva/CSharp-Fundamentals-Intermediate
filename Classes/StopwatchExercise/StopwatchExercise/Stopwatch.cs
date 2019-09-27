using System;

namespace StopwatchExercise
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _previouslyStarted;

        public void StartTimer()
        {
            if (_previouslyStarted)
                throw new InvalidOperationException("Timer has already been started");
            

            Console.WriteLine("Timer started.");

            _startTime = DateTime.UtcNow;
            _previouslyStarted = true;
        }

        public void StopTimer()
        {
            if(!_previouslyStarted)
                throw new InvalidOperationException("Timer is not running");

            _endTime = DateTime.UtcNow;
            _previouslyStarted = false;

            Console.WriteLine("Timer stopped.");
            
        }

        public TimeSpan GetTimeElapsed()
        {
            return _endTime - _startTime;
        }
    }
}