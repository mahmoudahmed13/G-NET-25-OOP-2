using System.Collections.Generic;
using System.Security.Principal;

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

            #endregion
        }
    }
}
