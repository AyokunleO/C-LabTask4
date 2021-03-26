using System;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); 
            Console.WriteLine($"The hypotenuse is {program.Hypotenuse(2, 2)}");
        }

        public double Hypotenuse(double side1, double side2)
        {
            double result;
            double temp;
            temp = Math.Pow(side1, 2) + Math.Pow(side2, 2);
            result = Math.Sqrt(temp);
            return result;
        }
        
    }
}
