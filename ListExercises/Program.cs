using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of integers and add in 10 integers to it
            // int[] arrayName = etc....
            List<int> integerList = new List<int>();
            integerList.Add(1);
            integerList.Add(2);
            integerList.Add(3);
            integerList.Add(4);
            integerList.Add(5);
            integerList.Add(6);
            integerList.Add(42);
            integerList.Add(43);
            integerList.Add(103);
            integerList.Add(500);

            // invoke the SumEvens method and pass it our integerList as an argument
            // and print it to the console
            int evenSum = SumEvens(integerList);
            Console.WriteLine(evenSum);

            List<string> stringList = new List<string>();
            stringList.Add("Pearce");
            stringList.Add("Susan");
            stringList.Add("Pri");

            printXLetterWords(stringList, 3);
        }

        // create a static method that returns the sum of all the even numbers in a list of integers
        // input: list of integers
        // output: sum of even integers in list
        public static int SumEvens(List<int> intList) 
        {
            int sum = 0;
            // now iterate through intList, and add each even integer to our sum
            foreach (int integer in intList)
            {
                // determine if integer is even
                // if it is even, add it on to the sum, if it's odd, don't do anything
                if(integer % 2 == 0)
                {
                    sum += integer;
                }
            }
            return sum;
        }

        // method takes a list of strings and a length value x
        // prints all words from the string list that are x letters long
        public static void printXLetterWords(List<string> wordList, int x)
        {
            foreach (string word in wordList)
            {
                if (word.Length == x)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
