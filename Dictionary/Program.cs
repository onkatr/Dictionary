using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Dictionary
{
    static public void Main()
    {
        Dictionary<int, string> My_dictionary1 = new Dictionary<int, string>();

        My_dictionary1.Add(1, "Onur");
        My_dictionary1.Add(2, "Merve");
        My_dictionary1.Add(3, "Derin");

        foreach (KeyValuePair<int, string> item1 in My_dictionary1)
        {
            Console.WriteLine("{0} and {1}", item1.Key, item1.Value);
        }
    }
}
}