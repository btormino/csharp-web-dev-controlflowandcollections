using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> newList = new List<int> {1,6,3,9,22,56,66,25,73,54,86,34,85,23,60,37 };

            static int sumEven(List<int> arr)
            {
                int total = 0;
                foreach (int integer in arr)
                {
                    if (integer % 2 == 0)
                    {
                        total += integer;
                    }
                }
                return total;
            }

            Console.WriteLine(sumEven(newList));

            List<string> wordList = new List<string>();
            wordList.Add("surround");
            wordList.Add("foot");
            wordList.Add("pencil");
            wordList.Add("legs");
            wordList.Add("pancake"); 
            wordList.Add("robust");
            wordList.Add("possible");
            wordList.Add("helpful"); 
            wordList.Add("painful");
            wordList.Add("collect");
            wordList.Add("ugliest");
            wordList.Add("mourn");
            wordList.Add("event");
            wordList.Add("new");
            wordList.Add("grate");


            static void findFive(List<string> wordList)
            {
                foreach (string word in wordList) { 
                    if (word.Length == 5) 
                    {
                    Console.WriteLine(word);
                    }
                }
               
            }
            findFive(wordList);

            Console.WriteLine("Enter a word length: ");
            string numInput = Console.ReadLine();
            int numChars = int.Parse(numInput);

            printXLetterWords(wordList, numChars);

            static void printXLetterWords(List<string> wordList, int length)
            {
                foreach (string word in wordList)
                {
                    if (word.Length == length)
                    {
                        Console.WriteLine(word);
                    }
                }

            }
        }
    }
}
