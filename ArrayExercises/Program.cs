using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and initialize an array with the values 1, 1, 2, 3, 5, 8
            int[] integerArray = { 1, 1, 2, 3, 5, 8 };

            // print out all the values in the array with a loop
            foreach (int integer in integerArray)
            {
                Console.WriteLine(integer);
            }

            // create a new loop that only prints the odd integers in array
            // ie 1, 1, 3, and 5 NOT 2 or 8
            // how did we check even/odd integers in javascript?
            // modulus operator: %
            // if integer % 2 is not 0, then the integer is odd
            // if integer is odd, print it
            foreach (int integer in integerArray)
            {
                if(integer % 2 != 0)
                {
                    Console.WriteLine(integer);
                }
            }

        }
    }
}
