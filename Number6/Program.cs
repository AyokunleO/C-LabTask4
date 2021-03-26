using System;

namespace Number6
{
    class Program
    {
            static void Main(string[] args)
            {
                Program program = new Program();

                Console.WriteLine($"Perfect Numbers: {program.Perfect()}\n");

                
            }

        //     public int Factor() {

        //     for(int num=2;num<=1000;num++)
        //     {
        //         if(perfect(num))
        //         {
        //             return num;
        //             System.out.println(num + " is perfect.");
        //             System.out.printf("Factors: ");

        //             for(int i=1; i<num; i++)
        //             {
        //                 if (num % i == 0)
        //                 {
        //                     System.out.print(i+" ");
        //                 }
        //             }
        //         }
        //     }
        // }

        
            public int Perfect()
            {
            int sum = 0;
            for(int num=2;num<=1000;num++){
            for(int i = 1; i<num; i++)
            {
                if (num % i == 0)
                {
                    sum+=i;
                }return sum;
            }
            }
            // return sum==num;
            // return sum;
        }
    }

}
