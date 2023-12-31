﻿namespace AccessModifiers

{
    public class Customer

    {

        // the first example is using a private field (_id) to store the value of
        // the Id property. The Id property has a getter that returns the value of
        // the private _id field and a setter that does nothing. This means that the
        // value of Id can be retrieved from outside the class using the getter, but
        // it cannot be set from outside the class using the setter.

                    //private int _id;

                    //public Customer()
                    //{
                    //}

                    //public int Id
                    //{
                    //    get { return _id; }
                    //    set { }

                    //}


        //the second example is using an auto-implemented property to define the Id
        //    and Name properties.Auto-implemented properties are a shorthand notation
        //    in C# that allow you to define a property without having to explicitly
        //    declare a backing field. In this case, the get and set accessors for Id
        //           and Name are automatically generated by the compiler, and a hidden
        //           backing field is used to store the property value.


        // In general, auto-implemented properties are preferred when you don't
        // need any custom logic in your getter or setter, and you just need to get
        // or set a value. However, if you need to add custom logic to your getter
        // or setter (for example, to enforce some validation rules), you need to u
        // se a private backing field and a custom getter/setter.


        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()

        {
            var rating = CalculateRating(excludeOrders:true);
            if (rating == 0)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");
        }


        // protected class is a class that can only be accessed by its own class
        // members and any derived classes (i.e., classes that inherit from
        // the protected class). This means that classes outside of the
        // protected class or its derived classes cannot access the protected
        // class directly.

        protected int CalculateRating(bool excludeOrders)
        {
            if (excludeOrders is true)
                return 0;
            else
                return 1;
        }

    }




}

