namespace ExDBConnection2

{

    public abstract class DbConnection
        {

        // declare variables

        public string ConnectionString;
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        // initialize variables

        public DbConnection(string connectionstring)
        {
            if (string.IsNullOrWhiteSpace(connectionstring))
                throw new ArgumentException("Connection string cannot be null or empty");
            this.ConnectionString = connectionstring;

        }


        // declaring methods

        public abstract void Open();
        public abstract void Close();


        public void Starttimer()
        {
            if (_isRunning)
                throw new InvalidOperationException("time running!");

            _startTime = DateTime.Now;
            Thread.Sleep(5000);
            _isRunning = true;
        }

        public void Stoptimer()
        {
            if (!_isRunning)
                throw new InvalidOperationException("time is not running!");

            _stopTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan GetDuration()
        {
            return _stopTime - _startTime;
        }

    }

}


