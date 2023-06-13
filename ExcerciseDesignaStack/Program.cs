using System;
using System.Collections;


namespace DesignStack

{

    // https://learn.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-8.0
    // Stack<object> is a ready method
    class Program

    {

        static void Main(string[] args)
        {

            var stack = new Stack();
            stack.Push(1);
            stack.Push("Mosh");
            stack.Push(DateTime.Now);


            // use stack.Clear to force error to appear
            // stack.Clear();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }


    }

}
