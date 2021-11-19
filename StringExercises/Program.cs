using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string rhyme = "I would not, could not, in a box. I would not, could not with a fox. " +
                "I will not eat them in a house. I will not eat them with a mouse.";

            // Use the Split method to divide the string at each space and
            // store the individual words in an array
            // rhyme.Split(" ") returns an array like this: ["I", "would", "not,", "could", etc...]
            // store return in an array of strings variable
            string[] wordsArray = rhyme.Split(" ");
            Console.WriteLine(string.Join(",", wordsArray));
            // repeat line 16 and 17 except split the rhyme string into an array that contains each sentence
            string[] sentenceArray = rhyme.Split(".");
            /*Console.WriteLine(string.Join("/", sentenceArray));*/
            foreach (string sentence in sentenceArray)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
