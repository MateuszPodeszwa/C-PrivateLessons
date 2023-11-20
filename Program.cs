// See https://aka.ms/new-console-template for more information
/*
 * Build a program with a variable of all 14 types
 * Assign each of them a value
 * Use Console.WriteLine to display them
 * 
 */

using System;

namespace The_Variable_Shop
{
    class PartOneTypes
    {
        static void Main()
        {
            byte @byte = 12;
            short @short = 31;
            int @int = 32;
            long @long = 5645;
            sbyte @sbyte = 64;
            ushort @ushort = 45;
            uint @uint = 542;
            ulong @ulong = 23;
            string @string = "Hello";
            char @char = '^';
            float @float = 345.43f;
            double @double = 876.865345;
            decimal @decimal = 534255.345667456m;
            
            Console.WriteLine($"{@byte}, {@decimal}, {@short}, {@int}, {@long}, {@sbyte}, {@ushort}, {@uint}" +
                              $"{@ulong}, {@string}, {@char}, {@float}, {@double}");
        }
    }
}


