using System;

namespace PriyeshTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] PersonArray = new Person[2];
            PersonArray[0] = new Adult();
            PersonArray[0].FirstName = "Priyesh";
            PersonArray[0].LastName = "Prasannan";
            PersonArray[1] = new Child();
            PersonArray[1].FirstName = "Vishwa";
            PersonArray[1].LastName = "P";
            foreach(Person person in PersonArray)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }

    }

    abstract class Person
    {

        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
    }
    class Adult:Person
    {
        public  override string FirstName { get; set; }
        public override string LastName { get; set; }
    }
    class Child:Person
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
    }

}