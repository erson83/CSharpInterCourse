namespace DesignStopwatch
{

    class Program

        {

            static void Main(string[] args)
            {
            var timenow = DateTime.Now;
            var timelater = DateTime.Now.AddHours(1);
            var timedifference = new Timedifference(timelater,timenow);
            Console.WriteLine("Time Difference:" + timedifference.Timediff);

             }


        }




}