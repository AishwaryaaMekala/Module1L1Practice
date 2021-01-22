using System;

namespace Module1L1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //variables and native operations
            int x;
            int y;
            x = 3;
            y = 5;
            int sum = x + y;
            //Console.WriteLine("x + y is " + sum);

            // obtaining user input      
            //Console.WriteLine("Please provide your input");      
            //string userInput = Console.ReadLine();
            //Console.WriteLine("You entered " + userInput);

            // parsing to specific data types      
            //int inputNumber = Convert.ToInt32(userInput);
            //Console.WriteLine(inputNumber);
            //Console.WriteLine("Hello " + userInput);
            //Console.WriteLine(3 + inputNumber);

            // parsing with error handling      
            //Console.WriteLine("Please provide your input");      
            //string userInputToCheck = Console.ReadLine();
            //try
            //{
            //    int inputNumberChecked = Convert.ToInt32(userInputToCheck);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // example 1 - simple computation      
            // M disambiguates between double and decimal      
            decimal income = 10000000.45M;
            decimal taxRate = 0.1M;
            decimal taxLiability = income * taxRate;
            //Console.WriteLine("Tax liability is " + taxLiability);

            //// example 2 - API usage      
            //double rate = 0.06;
            //double doublingTime = Math.Log(2) / Math.Log(1 + rate);
            //Console.WriteLine("Doubling time is " + doublingTime + " years");

            // example 3 - selection      
            //if (income < 400000)        
            //    taxLiability = 0;      
            //else      
            //{        
            //    taxRate = 0.5M;        
            //    taxLiability = taxRate * income;      
            //}      
            //Console.WriteLine("Tax liability is " + taxLiability);

            // example 5 - loop      
            //bool stopProgram = false; 
            //while (stopProgram == false)
            //{
            //    Console.Write("Please enter income: $"); 
            //    income = Convert.ToDecimal(Console.ReadLine()); 
            //    if (income > 400000)
            //    {
            //        taxRate = 0.5M; 
            //        taxLiability = taxRate * income;
            //    }
            //    else if (income >= 0) 
            //    { 
            //        taxLiability = 0; 
            //    } 
            //    else 
            //    { 
            //        stopProgram = true; 
            //    }
            //    Console.WriteLine("Tax liability is " + taxLiability);
            //} // end while loop

            // example 6 - method      
            income = Convert.ToDecimal(Console.ReadLine()); 
            taxLiability = ComputeTaxes(income);
            Console.WriteLine("Tax liability is " + taxLiability);
        }
        static decimal ComputeTaxes(decimal funInputs) 
        { 
            decimal taxLiability; 
            decimal taxRate;
            if (funInputs < 400000)
            {
                taxLiability = 0;
            }
            else
            {
                taxRate = 0.5M;
                taxLiability = taxRate * funInputs;
            } 
            return taxLiability; 
        }
    }
}


