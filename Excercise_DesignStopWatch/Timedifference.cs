namespace DesignStopwatch
{
    public class Timedifference
    {

        // declare variables
        public DateTime X { get; set; }
        public DateTime Y { get; set; }


        // initialize variables
        public Timedifference(DateTime x,DateTime y)
        {
            this.X = x;
            this.Y = y;
        }

        // get set method

        public TimeSpan Timediff
        {
            get
            {
                TimeSpan timediff = X - Y;

                return timediff;


            }


        }


    }




}