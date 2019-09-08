using System;

namespace StopwatchExercise
{
    public class Stopwatch
    {
        private DateTime _startTime = DateTime.UtcNow;
        private DateTime _endTime;
        private bool _previouslyStarted;

        public void StartTimer()
        {
            // Start timer if it hasn't already been started.
            if (_previouslyStarted)
            {
                throw new InvalidOperationException("Timer has already been started");
            }

            Console.WriteLine("Timer started.");

            _startTime = DateTime.UtcNow;
            _previouslyStarted = true;
        }

        public void StopTimer()
        {
            this._endTime = DateTime.UtcNow;
            _previouslyStarted = false;
            Console.WriteLine("Timer stopped.");
            
        }

        public TimeSpan Duration()
        {
            // Returns the total time elapsed.
            return _endTime - _startTime;
        }
    }
}