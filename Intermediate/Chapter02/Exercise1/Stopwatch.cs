namespace Exercise1
{
    public class Stopwatch
    {
        private bool _isTicking;
        private DateTime _startTime;

        public Stopwatch()
        {
            _isTicking = false;
        }

        public void Start()
        {
            if (_isTicking)
            {
                throw new InvalidOperationException("Stopwatch already running!");
            }

            _startTime = DateTime.Now;
            _isTicking = true;
            Console.WriteLine("Stopwatch is running");
        }

        public void Stop() 
        {
            if (!_isTicking)
            {
                throw new InvalidOperationException("Stopwatch already stoped!");
            }

            DateTime endTime = DateTime.Now;
            TimeSpan duartion = endTime - _startTime;
            _isTicking = false;
            Console.WriteLine("Milliseconds: " + duartion.Milliseconds);
            Console.WriteLine("Stopwatch has stoped");
        }
    }
}