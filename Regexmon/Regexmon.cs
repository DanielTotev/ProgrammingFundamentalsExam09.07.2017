using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Regexmon
    {
        public static void Main()
        {
            var bojomonRegex = new Regex(@"[A-Za-z]+\-[A-Za-z]+");
            var didiMonRegex = new Regex(@"[^a-zA-Z\-]+");
            var didiIndex = 0;
            var bojoIndex = 0;
            var input = Console.ReadLine();
            while (true)
            {

                var currentDidiRegexMatch = didiMonRegex.Match(input, didiIndex);
                if (!currentDidiRegexMatch.Success)
                {
                    break;
                }
                Console.WriteLine(currentDidiRegexMatch.Value);
                bojoIndex = input.IndexOf(currentDidiRegexMatch.Value, didiIndex) + currentDidiRegexMatch.Value.Length;
                var bojoMatch = bojomonRegex.Match(input, bojoIndex);
                if (!bojoMatch.Success)
                {
                    break;
                }
                Console.WriteLine(bojoMatch.Value);
                didiIndex = input.IndexOf(bojoMatch.Value, bojoIndex) + bojoMatch.Value.Length;
            }
        }
    }
}

