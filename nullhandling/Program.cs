using System;
//enable or disable nullable types
#nullable enable

namespace nullhandling
{
    class Address
    {
        //nullable field
        public string? Building;
        //non-nullable fields:
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            //thisCannotBeNull = null //throws compile err
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            //using GetValueOrDefault method
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            //instantiate a new Address
            var address = new Address();
            //set off warnings with:
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

            //checking for null
            if (thisCouldBeNull != null)
            {
                // int length = thisCouldBeNull.Length; //could throw exception
            }

        }
    }
}
