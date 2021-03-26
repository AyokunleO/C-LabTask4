using System;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter base: ");
            int baseNum =  Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter exponent(negative quits)");
            int exponent = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"{baseNum} to the {exponent} is {program.IntegerPower(baseNum, exponent)}");
        }


        public int IntegerPower(int baseNum, int exponent){
            
                int result = 1;
                for(int i = 0; i < exponent; i++){
                    result*= baseNum;
            }
                return result;
            
        }
    }
}
