using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SimpleCalculator
{
    class Calculator
    {
        //properties for user input to be manipulated later
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string Operator { get; set; }
        public List<string> Equation = new List<string>();


        public void MakeEquation(string inputEquation)
        {
            double output = 0;

            //exception in case user enters nothing 
            if (string.IsNullOrWhiteSpace(inputEquation))
            {
                Console.WriteLine("Sorry, there is no equation to calculate.");
                return;
            }

            //splits input into smaller string and adds to list
            Equation = inputEquation.Split(' ').ToList();

            //assigns the operator for later use
            Operator = Equation[1];

            //if user doesn't enter a valid first number
            if (!Double.TryParse(Equation[0], out output))
            {
                Console.WriteLine("Sorry, your first number is not valid.");
            }

            //assigns first number 
            else if (Double.TryParse(Equation[0], out output))
            {
                FirstNumber = Double.Parse(Equation[0]);
            }

            //if user doesn't enter valid operator
            if (Operator != "+" && Operator != "-" && Operator != "*" && Operator != "/")
            {           
                Console.WriteLine("Operator must be +, -, *, or /");
            }

            //in case user doesn't enter valid second number
            if (!Double.TryParse(Equation[2], out output))
            {
                Console.WriteLine("Sorry, your second number is not valid.");
            }

            //assigns second number
            else if (Double.TryParse(Equation[2], out output))
            {
                SecondNumber = Double.Parse(Equation[2]);
            }
        }

        public void Calculate()
        {
            double result;

            //if user tries to divide by zero 
            if (Operator == "/" && SecondNumber == 0)
            {
                Console.WriteLine("Sorry, cannot divide by zero.");
            }

            //switch statements to handle all the equations and give proper math results
            switch (Operator)
            {
                case "+":
                    result = FirstNumber + SecondNumber;
                    Console.WriteLine(result);
                    break;

                case "-":
                    result = FirstNumber - SecondNumber;
                    Console.WriteLine(result);
                    break;

                case "*":
                    result = FirstNumber * SecondNumber;
                    Console.WriteLine(result);
                    break;

                case "/":
                    result = FirstNumber / SecondNumber;
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("We're sorry, we cannot compute your equation.");
                    break;
            }
        }
    }
}
