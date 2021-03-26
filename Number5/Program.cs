using System;

namespace Number5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine($"The minimum is {program.Minimum3 (10F,3F,4F)}");
        }

        public float Minimum3(float num1, float num2, float num3)
        {
             float minimum;
            minimum = Math.Min(num1, Math.Min(num2, num3));
            return minimum;
        }
    }
}
