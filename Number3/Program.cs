using System;

namespace Number3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program ();
            Console.WriteLine($"The amount paid for parking is {program.Calculate_Charges(19):C}");
        }
        public double Calculate_Charges(double hour){
            double charges = 2.00;
            if (hour <= 3){
                return charges;
            }else if (hour > 3 && hour <= 19 ){
                return charges = charges + ((hour-3) * 0.5);
            }else {
                return charges = charges + (double)8.00;
            }
        }
    }
}


