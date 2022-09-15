using System;

namespace Exercise2
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please type a number to verify is it's part of the Fibonacci sequence: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[number];
            numbers[0] = 0;
            numbers[1] = 1;
            int x = 0;
            int y = 1;


                for (int i = 2; i <= number; i++)
                {
                    if(numbers[y] <= numbers.Length)
                    { 
                    numbers[i] = numbers[x] + numbers[y];
                    Console.WriteLine(numbers[i]);
                    x++;
                    y++;
                    }
                    else
                    {
                        break;
                    }

                }



        }
    }
}
