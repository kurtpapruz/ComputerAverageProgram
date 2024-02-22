using System;
namespace ComputerAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Enter 5 grades separated by new line: ");
            double add = 0;

                for (int i = 0; i < 5; i++) 
                {
                double grades = Convert.ToDouble(Console.ReadLine());
                add += grades;
                }

                double avg = add / 5;
                double roundAvg = Math.Round(avg);
                Console.WriteLine("The average is " + avg + " and round off to " + roundAvg );
               
            
        }
    }
}