using System;
using System.IO;
using System.Xml;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //using object to declare variables
            object height = 1.88;
            object name = "Amir";
            Console.WriteLine($"{name} is {height} meters tall.");
            //int length1 = name.Length; //will give error
            int length2 = ((string)name).Length; //tell compiler its a string
            Console.WriteLine($"{name} is {length2} characters.");
            //DYNAMICS
            dynamic anotherName = "Ahmed";
            int length = anotherName.Length; //will compile but throw err at runtime
            //LOCAL VARIABLES
            //modify types using 'var'
            // int population = 66_000_000;
            // double weight = 1.88;
            // decimal price = 4.99M;
            // string fruit = "Apples";
            // char letter = 'Z'; // chars in single quotes
            // bool happy = true;

            var population = 66_000_000;
            var weight = 1.88;
            var price = 4.99M;
            var fruit = "Apples";
            var letter = 'Z'; // chars in single quotes
            var happy = true;
            //best practices for using 'var' is when the type is clear
            var xml1 = new XmlDocument();
            //above, you avoid repeating type. Unlike this...
            XmlDocument xml2 = new XmlDocument();
            //bad use of 'var' is when type isn't clear like this..
            var file1 = File.CreateText(@"C:\something.txt");
            StreamWriter file2 = File.CreateText(@"C:\something.txt");
            XmlDocument xml3 = new(); //target typed

            //DEFAULT VALUES
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");


        }
    }
}
