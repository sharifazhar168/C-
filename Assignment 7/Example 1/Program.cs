using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public void Introduce()
        {
            Console.WriteLine("Hello ! , My name is " + firstName +" "+ lastName);
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            var Thomas = new Person();
            Thomas.firstName = " Thomas";
            Thomas.lastName = " Newt";
            Thomas.Introduce();
        }
    }
}