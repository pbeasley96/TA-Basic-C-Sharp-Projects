using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            string[] charNames = {"Goku", "Vegeta", "Gohan", "Piccolo", "Broly", "Frieza" }; //A one-dimensional array of strings.

            Console.WriteLine("Please select a character."); //Ask the user to input some text.
            for (int i =0; i < charNames.Length; i++) //A loop that iterates through each string in the array and adds the user's text input to the end of each string.
            {
                Console.WriteLine("Character Name: " + charNames[i]); // A loop that prints off each string in the array one at a time.
            }
            Console.ReadLine();

            //Assignment 2
            //for (int a =0; a < 10; a--) //Created an Infinite Loop, value of a will never be above 10 and the condition will be true always.
            //{
            //    Console.WriteLine("Value: {0}", a);
            //}
            //Console.ReadLine();
            for (int a = 0; a < 10; a++) //Avodied the loop by changing the value of a decrements after each iteration from "a--" to "a++".
            {
                Console.WriteLine("Value: {0}", a);
            }
            Console.ReadLine();

            //Assignment 3
            int[] fibNumbers = { 2, 4, 6, 8, 10, 12, 14, 16 }; //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            foreach (int element in fibNumbers )
            {
                Console.Write($"{element < 10} ");
            }
            Console.ReadLine();

            foreach (int element in fibNumbers) // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            {
                Console.Write($"{element <= 10} ");
            }
            Console.ReadLine();

            //Assignment 4
            List<string> famNames = new List<string>() { "Phillip", "Darian", "Reggie", "Devin", "Regina", "Tisha", "Danielle" }; //A list of strings where each item in the list is unique. 

            Console.WriteLine("Select Name from the List"); //Ask the user to input text to search for in the list.
            foreach (string name in famNames) //A loop that iterates through the list and then displays the index of the list.
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //Assignment 5
            List<string> strNumbers = new List<string>() { "one", "two", "three", "three", "four", "five" }; //A list of strings that has at least two identical strings in the list. 

            Console.WriteLine("Please select to search item within the List. "); //Ask the user to select text to search for in the list.


            //Assignment 6
            List<string> strLetters = new List<string>() { "Z", "Y", "X", "W", "Z" }; //A list of strings that has at least two identical strings in the list.
            List<string> strLetters1 = new List<string>();

            foreach (string element in strLetters) //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            {
                if (strLetters1.Contains(element))
                {
                    Console.WriteLine(element + "this item is a duplicate.");
                }
                else
                {
                    Console.WriteLine(element + "this item is unique.");
                }
                strLetters1.Add(element);
            }
            Console.ReadLine();
        }

    }

