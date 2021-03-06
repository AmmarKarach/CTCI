﻿using System;

namespace CTCI
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            Console.WriteLine(UniqueString.StringWithUniqueCharacters("ab"));

            //1.2
            Console.WriteLine(CheckPermuatations.Check("aba","aab"));

            //1.3
            Console.WriteLine(Urlify.UrlifyString("Mr John Smith     "));

            //1.4
            Console.WriteLine(PalindromePermuation.Check("Tact Coa"));

            //1.5
            Console.WriteLine(OneAway.IsStringOneAway("pale", "bale"));

            //1.6
            Console.WriteLine(StringCompression.Compress("aabcccccaa"));
            Console.WriteLine(StringCompression.Compress("aaAAAAbbcc"));
        }
    }
}
