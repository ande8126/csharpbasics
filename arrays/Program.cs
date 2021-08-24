using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names; //can reference w/o value declared
            //allocate memory for four strings
            names = new string[4];
            //store values at index positions
            names[0] = "Pat";
            names[1] = "Jenna";
            names[2] = "Quinn";
            names[3] = "Casper";
            //loop thru names
            for ( int i = 0; i < names.Length; i++ )
            {
                Console.WriteLine("name: " +  names[i]);
            }
        }
    }
}
