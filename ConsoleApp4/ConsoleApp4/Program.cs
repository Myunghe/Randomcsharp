using System;
using System.Collections.Generic;




    class Program
    {
    static string NameGenerator()
    {
        string FirstName; //
        string LastName;
        System.Random random = new System.Random();
        List<string> firstName = new List<string>(6) { "Liam", "Noah", "Oliver", "Olivia", "Emma", "Charlotte" };
        List<string> lastName = new List<string>(4) { "Smith", "Johnson", "Williams", "Brown" };


        int index1 = random.Next(firstName.Count);
        int index2 = random.Next(lastName.Count);

        FirstName = firstName[index1];
        LastName = lastName[index2];

        return FirstName + " " + LastName;

    }
    static void Main(string[] args)
    {
        Console.WriteLine(NameGenerator());
    }
}
