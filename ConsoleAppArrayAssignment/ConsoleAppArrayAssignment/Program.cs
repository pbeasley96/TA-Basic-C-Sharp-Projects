using System;
using System.Collections.Generic;


class Program
 {
    static void Main()
    {
        //Array of Integers
        int[] numArray = new int[] { 5, 2, 120, 2000, 500 };

        Console.WriteLine("Please select an index of the Array and display the integer at that index on the screen.");
        Console.ReadLine();

        //Array of Strings
        string[] strArray = new string[] { "Element 1", "Element 2", "Element 3", "Element 4", "Element 5" };

        Console.WriteLine("Please select an index of the Array and display the string at that index on the screen.");
        Console.ReadLine();

        Console.WriteLine("You have selected and index that doesn't exist. Please select again.");
        Console.ReadLine();

        //List of Strings
        List<string> colorList = new List<string>();
        colorList.Add("blue");
        colorList.Add("red");
        colorList.Add("orange");
        colorList.Add("black");

        Console.WriteLine("Please select an index of the list and display the content at that index on the screen.");
        Console.ReadLine();
    }
}
