namespace MethodOveride4

{
    //    - Method overriding means changing the implementation of an inherited method.
    //- If a declare a method as virtual in the base class, we can override it in a derived
    //class.


    public class LoopThroughList
    {
        // loop through animal list

        public void SpeakAnimals(List<Animals> animals)
        {
            // for each item in list, invoke method

            foreach (var animal in animals)
            {
                animal.Speak();

            }
        }


    }




}
