using System;
// #error version;
using System.Linq;
using System.Reflection;


namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop thru assemblies this app references
            foreach ( var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                //declaring unused variable using types...
                System.Data.DataSet dataSet;
                System.Net.Http.HttpClient client; //both of these bring in more assemblies


                //load assembly so we can read details
                var a = Assembly.Load( new AssemblyName( r.FullName ) );
                //declare var to count number of methods
                int methodCount = 0;
                //loop thru all types in assembly
                foreach ( var t in a.DefinedTypes )
                {
                    //add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }
                //output the count of types and their methods
                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
                arg0: a.DefinedTypes.Count(),
                arg1: methodCount,
                arg2: r.Name);
            }
        }
    }
}


