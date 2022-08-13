using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students and ID numbers (or ENTER to finish):");


            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID Number: ");
                    input = Console.ReadLine();
                    int idNumber = int.Parse(input);
                    students.Add(newStudent, idNumber);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));
            
            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine(student.Key + "'s ID: " + student.Value);
                sum += student.Value;
            }



        }
    }
}
