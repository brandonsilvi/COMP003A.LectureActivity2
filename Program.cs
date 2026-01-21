using System;

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: "); //ask for # 
            string input1 = Console.ReadLine();  //read #

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            double a = double.Parse(input1); //convert string from above to #
            double b = double.Parse(input2);

            double sum = a + b; //use # for calcs
            double average = (a + b) / 2.0;
            
            //output the results w/ concatenation
            Console.WriteLine("\nUsing Concatenation");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            
            //output the results w/interpolation
            Console.WriteLine("\nUsing Interpolation");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            
        
        }
    }
}