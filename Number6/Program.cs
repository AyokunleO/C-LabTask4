using System;

namespace Number6
{
    class Program
    {
            static void Main(string[] args)
            {
                Program program = new Program();

                Console.WriteLine($"Perfect Numbers: {program.CheckNum()}\n");

                
            }

            public int CheckNum()
            {
                for(int val = 2; val <= 1000; val++)
                {
                    if(Perfect(val))
                    {
                        return val;
                    }
                        for(int i = 1; i < val; i++)
                        {
                            if (val % i == 0)
                            {
                                return i;
                            }
                        }
                    
                }
            }
            public bool Perfect(int val)
            {
                int sum = 0;
                for (int i = 1; i < val/2; i++)
                {
                    if(val % i == 0)
                    {
                        sum+=i;
                    }
                } return sum == val;
            }
    }

}
