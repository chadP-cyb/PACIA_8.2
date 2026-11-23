using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Hashtable stu = new Hashtable();

        stu.Add("101", new string[] { "Jose Marie Chou", "Solano", "N/A" });
        stu.Add("102", new string[] { "Marites Alcantara", "Bayombong", "09273744546" });
        stu.Add("103", new string[] { "Pepito Montalban", "Aritao", "09184476548" });

        Console.WriteLine("Welcome to my HASHTABLE program!");

        while (true)
        {
            Console.WriteLine("\nHere are the recorded data: ");
            Console.WriteLine("Student ID");
            Console.WriteLine("101");
            Console.WriteLine("102");
            Console.WriteLine("103");

            Console.WriteLine("\nLook up ID: ");

            string id = Console.ReadLine();

            if (stu.ContainsKey(id))
            {
                string[] info = (string[])stu[id];
                Console.WriteLine("\n Detailed Information: ");
                Console.WriteLine($"Student ID: \t{id}");
                Console.WriteLine($"Name:    \t{info[0]}");
                Console.WriteLine($"Address: \t{info[1]}");
                Console.WriteLine($"Contact: \t{info[2]}");
            }
            else
            {
                Console.WriteLine("Student ID not found.");
            }

            Console.WriteLine("\nDo you want to look up another ID? (y/n)");
            string rep = Console.ReadLine();

            if (rep != "Y" && rep != "y")
            {
                break;
            }
        }
    }
}

