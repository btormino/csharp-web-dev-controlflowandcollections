using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 1, 2, 3, 5, 8 };
            foreach(int num in numberArray) {
                if (num % 2 == 1)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
