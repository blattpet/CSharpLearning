namespace Exercise1
{
    public class Stopwatch
    {
        // Fields
        private bool _isTicking;
        private DateTime _startTime;

        // Constructor
        public Stopwatch()
        {
            _isTicking = false;
        }

        // Method
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

        // Method
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