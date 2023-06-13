using System;
using System.Collections.Generic;

public class MyClass
{
    private List<int> myIntList;

    public MyClass()
    {
        myIntList = new List<int>() { 1, 2, 3, 4, 5 };
    }

    public void PrintList()
    {
        foreach (int num in myIntList)
        {
            Console.WriteLine(num);
        }
    }
}


class Program
{
    static void Main(string[] args)
    {

        var myClass = new MyClass();
        myClass.PrintList();
    }
}
