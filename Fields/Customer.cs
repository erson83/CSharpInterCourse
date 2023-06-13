using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fields

{



    public class Customer
    {
        public int Id;
        public string Name;
        // if class contains an empty list, we need to intialize it
        // we can intialize it here instead of creating another public customer...
        // if we only need to intialize ONLY once, use readonly
        // We use the readonly modifier to improve the robustness of our code. When a field is
        // declared with readonly, it needs to be initialized either during declaration or in a
        // constructor.The value cannot be changed. This prevents you from accidentally
        // overwriting the value of a field, which can result in an unexpected state.

        public readonly List<Order> Orders = new List<Order>();


               // we do not have to create another contructor,we can directly initiate
               // as above skipping the below part

               // public Orders
               //     {
               //        Orders = new List<Order>();
               //     }

        public Customer(int id)
        {
            this.Id = id;

        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;

        }

        public void Promote()
        {

            // once we use read only to declare and intialize a new  list, we cannot reintialize
            // it somewhere again
            // do not reintialize Orders = new List<Order>(); again else it will set everything empty
            // Orders = new List<Order>();

        }

    }
}

