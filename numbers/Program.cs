using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //unsigned int = positive whole number, including zero
            uint naturalNumber = 23;
            //int can be negative
            int integerNumber = -23;
            //float = single-precision floating point
            float realNumber = 2.3F; //note the F after the digits
            double anotherRealNumber = 2.3; //double literal
            //Beyond Base 10 numbers...
            //three ways to store 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            //checking values...
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
            //using operators to learn more about numbers
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range of {int.MinValue:N0} to {int.MaxValue:N0}");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range of {double.MinValue:N0} to {double.MaxValue:N0}");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range of {decimal.MinValue:N0} to {decimal.MaxValue:N0}");
            //comparing doubles and decimals 
            //THIS SHOWS DOUBLES NOT ALWAYS ACCURATE - some numbers cant be represented as floating-point values
            Console.WriteLine("Using doubles:");
            double a = 0.1; //computer stores .1 in binary form that repeates infinitely (0.0001100110011....)
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
            //USING DECIMALS
            Console.WriteLine("Using decimals:");
            //decimal type stores the value as an integer and shifts the decimal point
            decimal c = 0.1M; //computer stores .1 in binary form that repeates infinitely (0.0001100110011....)
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }

        }
    }
}
