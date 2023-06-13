namespace Methods

{
    public class Point
    {

        //to intialize Point variables

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x; 
            this.Y = y; 
        }
        // to include method inside Point class
        // to intialize Move Class
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // to intiatite Move class, we use overload method.
        // we use Point object 
        public void Move(Point newLocation)
        {

            // using the if null is defensive programming
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation is null");
            }
            else
            {
                Move(newLocation.X, newLocation.Y);
            }
        }


        // commented out the lines below away as this is not effificient

        // public void Move(int x, int y)
        //{
        //  this.X = x;
        //  this.Y = y;
        //}

        // public void Move(Point newLocation)
        //}        
        // this.x = newLocation.x;
        // this.y = newLocation.y;
        //}


    }




}