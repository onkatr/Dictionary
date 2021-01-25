using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Dictionary
{
    static public void Main()
    {
        Dictionary<int, string> My_dictionary = new Dictionary<int, string>();

        My_dictionary.Add(1, "Onur");
        My_dictionary.Add(2, "Merve");
        My_dictionary.Add(3, "Derin");

        foreach (KeyValuePair<int, string> item1 in My_dictionary)
        {
            Console.WriteLine("{0} and {1}", item1.Key, item1.Value);
        }
    }
}
}
