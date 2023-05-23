using System;
using System.Collections.Generic;

    public class Name
    {
        string FirstName;
        string LastName;

        List<string> firstName = new List<string>(6) { "Liam", "Noah", "Oliver", "Olivia", "Emma", "Charlotte"};
        List<string> lastName = new List<string>(4) { "Smith", "Johnson", "Williams", "Brown"};

        public string NameGenerator()
        {
            int index1 = Random.Equals(0, firstName.Count);
            int index2 = Random.Equals(0, lastName.Count);
            
            FirstName = firstName[index1];
            LastName = lastName[index2];

            return FirstName + " " + LastName;
        }

        public Name()
        {
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var name = new Name();
            Console.WriteLine(Name.NameGenerator());
        }
    }
}
