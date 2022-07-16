using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleProject1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DisplayExampleInput();
        }

        private static void DisplayExampleInput()
        {
            var triangleInput = @"1
							 8 4
							 2 6 9
							8 5 9 3";
            var splittedInput = ConvertToStringArray(triangleInput);
            var TwoDimensionalArray = Build2DArray(splittedInput);





            foreach (var splitcumle in TwoDimensionalArray)
            {
                Console.WriteLine(splitcumle.ToString());
            }

        }

        private static string[] ConvertToStringArray(string triangleInput)
        {
            return triangleInput.Split('\n');
        }

        private static int[,] Build2DArray(string[] splittedStringArray)
        {

            var twoDimensionalArray = new int[splittedStringArray.Length, splittedStringArray.Length + 1];
            var rowIndex = 0;
            foreach (var row in splittedStringArray)
            {
                var integerArray = row.ConvertStringToIntegerArray();
                var columnIndex = 0;
                foreach (var integer in integerArray)
                {
                    twoDimensionalArray[rowIndex, columnIndex] = integer;
                    columnIndex++;
                }
                rowIndex++;
            }
            return twoDimensionalArray;
        }

        private static int[] ConvertStringToIntegerArray(this string rows)
        {
            return
                Regex
                    .Matches(rows, "[0-9]+")
                    .Cast<Match>()
                    .Select(m => int.Parse(m.Value)).ToArray();
        }

    }
}
