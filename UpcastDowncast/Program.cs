using System;
using System.IO;
using System.Collections;
using Microsoft.VisualBasic;

namespace UpcastDowncast

{
    //- Upcasting: conversion from a derived class to a base class
    //- Downcasting: conversion from a base class to a derived class
    //- All objects can be implicitly converted to a base class reference.

    class Program

    {

        static void Main(string[] args)
        {
            var text = new Text();
                // converting object reference to base class reference
                // 1. upcasting
            var shape = text;

            text.Width = 200;
            shape.Width = 100;


            // parent takes control! shape > text
            Console.WriteLine(text.Width);


            // upcasting
            // MomeoryStream will take streamreader class
            StreamReader reader = new StreamReader(new MemoryStream());

            // array can contain any datatype
            var list = new ArrayList();
            list.Add(1);
            list.Add("Most");
            list.Add(new Text());
            Console.WriteLine(list[1]);

            // list is enforced. Upcast so that any new list added, must be of same type
            var anotherlist = new List<int>();
            anotherlist.Add(1);
            anotherlist.Add(2);
            Console.WriteLine(anotherlist[0]); 


            var shape2 = new Text2();
            // not able to get Fontsize and FontType from Text2 child class
            // only able to get from Shape2 parent class
            shape2.Width = 100;   // width is from parent class
            Console.WriteLine(shape2.FontName); // will not be able to fetch variable from child unless u downcast
            // 2. downcasting
            // in order to access the Text child class, we need to downcast from parent to child class
            var text2 = (Text2)shape2;
            text2.FontName = "Arial";    // font is from child class
            Console.WriteLine(text2.FontName);

            // casting might throw exception, we need to handle it

            if (text2 != null)
            {

            }
            


        }


    }




}

