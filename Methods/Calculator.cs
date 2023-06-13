namespace Methods

{
    public class Calculator
    {

        //passing params mean can pass any number of parameters into method
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;


            }

            return sum;
        }


    }




}

