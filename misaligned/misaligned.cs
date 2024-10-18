using System;
using System.Diagnostics;

namespace MisalignedSpace
{
    class Misaligned
    {
        ExcpectedStrings ExpectedColorMap = new ExcpectedStrings();
        public static int printColorMap()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                }
            }
            return i * j;
        }


        static void Main(string[] args)
        {
            ExcpectedStrings.TestPrintColorMap();
            Console.WriteLine("All tests passed!");
        }
    }
}
