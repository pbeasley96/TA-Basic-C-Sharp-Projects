using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //Array of Integers
        int[] numArray = new int[5] { 2, 4, 8, 16, 32 }; //Created a one-dimensional Array of integers.

        Console.WriteLine("Please select an index of the Array."); //Have the user to select an index of the Array and then display the integer at that index on the screen.
        int input = Convert.ToInt32(Console.ReadLine());
        int intOutput = numArray[input];

        int[] array = { 1, 2, 3, 4, 5 };

        if (input >= 0 && input < array.Length)
        {
            Console.WriteLine(intOutput);
        }
        else
        {
            Console.WriteLine("You have selected an index that doesn’t exist."); //A message that displays when the user selects an index that doesn’t exist.
        }
        Console.ReadLine();


        //Array of Strings
        string[] strArray = new string[5] { "Element 1", "Element 2", "Element 3", "Element 4", "Element 5"}; //Created a one-dimensional Array of strings.

        Console.WriteLine("Please select an index of the Array."); //Have the user to select an index of the Array and then display the string at that index on the screen.
        int input1 = Convert.ToInt32(Console.ReadLine());
        string strOuput = strArray[input1];

        if (input1 >= 0 && input1 < array.Length)
        {
            Console.WriteLine(strOuput);
        }
        else
        {
            Console.WriteLine("You have selected an index that doesn’t exist."); //A message that displays when the user selects an index that doesn’t exist.
        }
        Console.ReadLine();


        //List of Strings
        List<string> colorList = new List<string>(); //Create a list of strings.
        colorList.Add("blue");
        colorList.Add("red");
        colorList.Add("orange");
        colorList.Add("black");

        Console.WriteLine("Please select an index of the list and display the content at that index on the screen."); //Have the user to select an index of the list and then display the content at that index on the screen.
        int input2 = Convert.ToInt32(Console.ReadLine());
        string ListOutput = colorList[input2];

        Console.WriteLine(ListOutput);
        Console.ReadLine();

    }
}
