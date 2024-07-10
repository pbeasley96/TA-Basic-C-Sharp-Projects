using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //Array of Integers
        int[] numArray = new int[5] { 2, 4, 8, 16, 32 };

        Console.WriteLine("Please select an index of the Array and display the integer at that index on the screen.");
        int input = Convert.ToInt32(Console.ReadLine());
        int intOutput = numArray[input];
        
        Console.WriteLine(intOutput);
        Console.ReadLine();

        //Array of Strings
        string[] strArray = new string[3] { "Element 1", "Element 2", "Element 3" };

        Console.WriteLine("Please select an index of the Array and display the string at that index on the screen.");
        int input1 = Convert.ToInt32(Console.ReadLine());
        string strOuput = strArray[input1];

        Console.WriteLine(strOuput);
        Console.ReadLine();

        //List of Strings
        List<string> colorList = new List<string>();
        colorList.Add("blue");
        colorList.Add("red");
        colorList.Add("orange");
        colorList.Add("black");

        Console.WriteLine("Please select an index of the list and display the content at that index on the screen.");
        int input2 = Convert.ToInt32(Console.ReadLine());
        string ListOutput = colorList[input2];

        Console.WriteLine(ListOutput);
        Console.ReadLine();

    }
}
