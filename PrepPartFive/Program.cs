﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrepPartFive
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
		    List<int> ids = new List<int>();
		    StringBuilder myStringBuilder = new StringBuilder();
		    string newName;

		    Console.WriteLine("Please enter the students name (or press ENTER to exit)");
		    do
            {
                newName = Console.ReadLine();
                if (newName != "")
                {
                    names.Add(newName);
                }
            }
            while (newName != "");

		    // Get student Id's
            foreach (string name in names)
            {
                Console.WriteLine("Id for " + name + ": ");
                int newId = Convert.ToInt32(Console.ReadLine());
                ids.Add(newId);
            }

            // Print roster
            Console.WriteLine("\nClass roster:");      
	        for (int i = 0; i < names.Count; i++)
            {
			    myStringBuilder.Append(names[i] + "'s Id is " + ids[i] + "\n");
            }

		    Console.WriteLine(myStringBuilder);
        }
    }
}
