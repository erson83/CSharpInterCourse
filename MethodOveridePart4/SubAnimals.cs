namespace MethodOveride4

{
    public class Cat : Animals
    {
        public override void Speak()
        {
            Console.WriteLine("the cat goes meow");
        }
    }


    public class Dog : Animals
    {
        public override void Speak()
        {
            Console.WriteLine("the dog goes woof");
        }
    }


    public class Parrot : Animals
    {
    }

}

