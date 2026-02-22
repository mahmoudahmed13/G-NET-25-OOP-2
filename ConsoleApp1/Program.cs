using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01

            #region Question 01
            //public class BankAccount
            //{
            //    public string Owner;
            //    public double Balance;

            //    public void Withdraw(double amount)
            //    {
            //        Balance -= amount;
            //    }
            //}
            //a) Identify at least two problems with this design from an encapsulation perspective.
            //1. the Field is public must be private.
            //2. public method must be with validation(properties).

            //b) Describe how you would fix this class to follow proper encapsulation principles.You do not need to write the full code.
            //use private field and controlled access.            

            //c) Explain why exposing fields directly(as public) is considered a bad practice in OOP.
            //because public can anyone assign it any where 

            #endregion

            #region Question 02

            ////Q02: What is the difference between a field and a property in C#?
            ////1. Field is dirct data storage and not provide validation BUT Propert is controlled access ans provide validation.

            ////Can a property contain logic? //yes
            ////Give an example of a read-only property that returns a calculated value.
            //ReadOnlyExample ex01 = new ReadOnlyExample(10);
            ////ex01.Number = 1; //Invalid 
            //Console.WriteLine(ex01.Number); //100

            #endregion

            #region Question 03
            //public class StudentRegister
            //{
            //    private string[] names = new string[5];

            //    public string this[int index]
            //    {
            //        get { return names[index]; }
            //        set { names[index] = value; }
            //    }
            //}
            //a) What is `this[int index]` called? Explain its purpose.
            //indexer. An indexer lets an object be accessed using array-like syntax

            //b) What happens if someone writes `register[10] = "Ali";` ? => throw exeption (OutOfRange)
            //How would you make the indexer safer?
            //use validation to throw exeption

            //c) Can a class have more than one indexer? If yes, give an example of when that would be useful.
            //when you want to access data in different ways for example, by numeric index or by string key.

            #endregion

            #region Question 04
            //    public class Order
            //{
            //    public static int TotalOrders = 0;
            //    public string Item;

            //    public Order(string item)
            //    {
            //        Item = item;
            //        TotalOrders++;
            //    }

            //a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?
            //it's shared field, we call it by class no instance. 
           
            //b) Can a static method inside `Order` access the `Item` field directly? Why or why not?
            //No, beacuase static method belong the class don't neet instance but Item field must need instance to assign it.
            #endregion

            #endregion
        }
    }
}
