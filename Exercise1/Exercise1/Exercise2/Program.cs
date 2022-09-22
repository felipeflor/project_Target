using System;

namespace Exercise2
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please type a number to verify is it's part of the Fibonacci sequence: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            int on = 0;
            int x = 0;
            int y = 1;


            while(on == 0)
            {
                result = x + y;
                
                if (result < number)
                {
                    
                } else if(result == number){
                    Console.WriteLine("Number typed is part of the Fibonaci Sequence");
                    on = 1;
                } else
                {
                    Console.WriteLine("Number typed isn't part of the Fibonaci Sequence");
                    break;
                }

                x = y;
                y = result;


            }


        }
    }
}
