using System;
using System.Collections;


namespace BoxingUnboxing

{
    //- Boxing happens when a value type instance is converted to an object reference.
    // Boxing:
    // int number = 10;
    // object obj = number;

    //- Unboxing is the opposite: when an object reference is converted to a value type.
    // Unboxing:
    // object obj = 10;
    // int number = (int) obj;

    class Program

    {

        static void Main(string[] args)
        {
            // ArrayList() contains objects by default
            var list = new ArrayList();
            // boxing happens below
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Now);


            // unboxing here
            var number = (int)list[0];
            Console.WriteLine(number);


            // error will occur below because when unboxing
            // "Mosh" is not of int type
            try
            {
                var number2 = (int)list[1];
                Console.WriteLine(number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("invalid data type being unboxed.");
            }




            // by declaring a list<int>, we are declaring int inside the list
            var anotherList = new List<int>();
            // no boxing happened becasue all are of int type within list
            anotherList.Add(1);


        }


    }

}
