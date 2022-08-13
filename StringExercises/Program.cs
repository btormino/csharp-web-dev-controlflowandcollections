using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string foxSocks = "I would not, could not, in a box. I would not, could not with a fox.\r\nI will not eat them in a house. I will not eat them with a mouse.";
            string[] words = foxSocks.Split(' ');
            Console.WriteLine(string.Join("/", words));
            string[] sentences = foxSocks.Split(".");
            Console.WriteLine(string.Join("/", sentences));        }
    }
}
