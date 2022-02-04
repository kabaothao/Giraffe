using System;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Giraffe
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //normally we would have to create an actual instance of the math class.
            //for example Math myMath = newMath();
            //Console.WriteLine(Math.Sqrt(144)); //there is this class in c# called Math which are a bunch of methods. i'm able to use this method without creating an instance
            
            //What are static methods and classes?
            //static methods belongs to the class itself. So a lot of times when we create methods inside of our c# class.
            //usually those methods 
            UsefulTools.SayHi("Mike");
            CookAssistant.SayHi("Amy");
            

            //What is inheritance?
            //inheritance is a technique that we can use in c#, where we can have one class inherit all of the functionality of another class.
            //
            //i created an object for the chef and told it to make chicken. 
            Chef chef = new Chef();
            chef.MakeSpecialDish();
            chef.MakeSalad();
            chef.MakeChicken();


            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            HmongChef hmongChef = new HmongChef();
            hmongChef.MakeSpecialDish();

            Console.ReadLine();

        }


    }



}

//inheritance

//1- is just inheriting all the functionality.

//2- is extending that functionality. such as by creating  subclass from a superclass 

//3- overide a method. 