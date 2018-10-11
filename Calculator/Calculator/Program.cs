using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // lets user know whats going on an asks for input
            Console.WriteLine("Please enter a simple math equation. \n" +
                "The equation should include only 2 numbers and one of the following operators in the middle: +, - , *, / \n" +
                "Some examples include: 3 + 5 or 8 * 2");
            Console.Write("\nPlease enter your equation: ");

            //turns input into string
            string inputEquation = Console.ReadLine();

            //creates new calculator object
            Calculator calculator = new Calculator();

            //breaks down equation in order to calculate
            calculator.MakeEquation(inputEquation);

            Console.Write("\nYou answer is: ");

            //calculates equation
            calculator.Calculate();

            Console.ReadLine();

        }
    }
}
