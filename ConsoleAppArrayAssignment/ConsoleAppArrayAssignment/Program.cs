using System;
using System.Collections.Generic;


class Program
 {
    static void Main()
    {
        //Array of Integers
        int[] numArray = new int[5];
        numArray[0] = 2;
        numArray[1] = 4;
        numArray[2] = 8;
        numArray[3] = 16;
        numArray[4] = 32;

        Console.WriteLine("Please select an index of the Array and display the integer at that index on the screen.");
        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numArray.Length; i++)
        {
            if (input >= 0 && input < 4)
            {
                Console.WriteLine(numArray[i]);
            }
            else
            {
                Console.WriteLine("You have selected and index that doesn't exist. Please select again.");
            }

        }
        Console.ReadLine();

        //Array of Strings
        string[] strArray = new string[3] { "Element 1", "Element 2", "Element 3"};

        Console.WriteLine("Please select an index of the Array and display the string at that index on the screen.");
        string input2 = Console.ReadLine();

        if (input2.Contains(strArray[0]))
        {
            Console.WriteLine("");
        }
        else if (input2.Contains(strArray[1]))
        {
            Console.WriteLine("");
        }
        else if (input2.Contains(strArray[2]))
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("You have selected and index that doesn't exist. Please select again.");
        }
        Console.ReadLine();

        //List of Strings
        List<string> colorList = new List<string>();
        colorList.Add("blue");
        colorList.Add("red");
        colorList.Add("orange");
        colorList.Add("black");

        Console.WriteLine("Please select an index of the list and display the content at that index on the screen.");
        Console.ReadLine();

        foreach (string item in colorList)
        {
            if (item.Contains(LinkedList))
                return item;
        }
        Console.ReadLine();
    }
}
