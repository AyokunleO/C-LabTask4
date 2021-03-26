using System;

namespace Number4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine($"Integer status? {program.Integers(2,100)} ");
        }

        public bool Integers(int num1, int num2)
        {
            if (num2 % num1 == 0)
            {
                return true;
            }else{
                return false;
            }
        }
    }
}
