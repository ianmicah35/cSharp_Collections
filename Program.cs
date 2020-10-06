using System;
using System.Collections.Generic;

namespace Collections
{
        class Program
        {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

// Create an array to hold integer values 0 through 9
        // int [] newArr = new int [10];
        // Console.WriteLine("My array of ints:");
        // for (int i= 0; i < newArr.Length; i ++)
        // {
        //     Console.WriteLine(i);
        // }

// Create an array of the names "Tim", "Martin", "Nikki", "Lina" & "Sara"
        // string [] Names = new string[] {"Tim", "Martin", "Nikki", "Lina", "Sara"};
        // // for(int idx = 0; idx < Names.Length; idx++)
        // foreach(string i in Names)
        // {
        //     Console.WriteLine(i);
        // }

// Create an array of length 10 that alternates between true and false values, starting with true
        // bool[] array = new bool [10];
        // array[0] = true;
        // array[1] = false;
        // array[2] = true;
        // array[3] = false;
        // array[4] = true;
        // array[5] = false;
        // array[6] = true;
        // array[7] = false;
        // array[8] = true;
        // array[9] = false;

        // foreach (bool value in array)
        // {
        //     Console.WriteLine(value);
        // }

// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
        // List<string> flavors = new List<string>();

        // flavors.Add("Strawberry");
        // flavors.Add("Butter Pecan");
        // flavors.Add("Toffee");
        // flavors.Add("Mint Chocolate");
        // flavors.Add("Vanilla");

        // foreach (string f in flavors)
        // {
        //     Console.WriteLine(f);
        // }

// Output the length of this list after building it
        // Console.WriteLine(flavors.Count);

// Output the third flavor in the list, then remove this value
        // Console.WriteLine(flavors[2]);
        // flavors.RemoveAt(2);

// Output the new length of the list (It should just be one fewer!)
        // Console.WriteLine(flavors.Count);

// Create a dictionary that will store both string keys as well as string values
        Dictionary<string,string> profile = new Dictionary<string,string>();

// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly select a flavor from your flavors list.
        string [] Names = new string[] {"Tim", "Martin", "Nikki", "Lina", "Sara"};

        List<string> flavors = new List<string>();
        flavors.Add("Strawberry");
        flavors.Add("Butter Pecan");
        flavors.Add("Toffee");
        flavors.Add("Mint Chocolate");
        flavors.Add("Vanilla");

// Loop through the dictionary and print out each user's name and their associated ice cream flavor

        Random rnd = new Random ();

        foreach (string n in Names)
        {
                profile.Add(n, flavors[rnd.Next(0,flavors.Count)]);
        }

        foreach (KeyValuePair<string,string> entry in profile)
        {
        Console.WriteLine(entry.Key + " - " + entry.Value);
        }

        }  // MAIN ENDS

    } // PROGRAM CLASS ENDS

}  // COLLECTIONS NAMESPACE ENDS

