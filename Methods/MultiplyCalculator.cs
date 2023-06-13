namespace Methods

{
    public class MultiplyCalculator
    {
        public int Multiply(params int[] numberMul)
        {
            var mul = 1;

            foreach (var num in numberMul)
            {
                mul *= num;

            }

            return mul;

        }

    }




}