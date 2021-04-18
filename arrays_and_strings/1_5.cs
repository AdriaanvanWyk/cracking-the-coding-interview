// There are 3 types of edits that can be performed on strings: insert, remove or replace a single character
// Given two strings, wrtie a functions to check if they one/zero edits away

// EXAMPLE
// pale, ple = true
// pales, pale = true
// pale, bale = true
// pale, bake = false

// I initially did a char count mapping and then compared but this obviously fails due to 
// it not considering ordering

using System;
using System.Collections.Generic;

namespace ArraysAndStrings
{
    class Program {

        static void Main(string[] args)
        {
            Program program = new Program();

            var inputStrings = new List<(string, string)>
            {
                ("pale", "paleos"),
                ("pale", "paleo"),
                ("pale", "payle"),
                ("pale", "ple"),
                ("pales", "pale"),
                ("pale", "bale"),
                ("pale", "bake"),
                ("pale", "lape")
            };

            foreach((string os, string ms) stringTuple in inputStrings)
            {
                Console.WriteLine($"OS: {stringTuple.os}, MS: {stringTuple.ms}, Return Val: {program.isValidEdit(stringTuple.os, stringTuple.ms)}");
            }
        }

        bool isValidEdit(string os, string ms)
        {

            const int ALLOWED_CHANGES = 1;
            // If the string length is less or more than the allowed change limit
            // Return false
            if(Math.Abs(os.Length-ms.Length) > ALLOWED_CHANGES)
            {
                return false;
            }

            bool oneChangeRegistered = false;
            if(os.Length > ms.Length)
            {
                // Character removed
                for(int i=0; i < ms.Length; i++)
                {
                    if(os[i] != ms[i])
                    {
                        if(oneChangeRegistered)
                        {
                            return false;
                        }
                        else
                        {
                            os = os.Remove(i, 1);
                            oneChangeRegistered = true;
                        }
                        
                    }
                }
            }
            else if(os.Length < ms.Length)
            {
                // Character added    
                for(int i=0; i < os.Length; i++)
                {
                    if(os[i] != ms[i])
                    {
                        if(oneChangeRegistered)
                        {
                            return false;
                        }
                        else
                        {
                            ms = ms.Remove(i, 1);
                            oneChangeRegistered = true;
                        }
                        
                    }
                }            
            }
            else
            {
                // Character(s) replaced
                for(int i=0; i < os.Length; i++)
                {
                    if(os[i] != ms[i])
                    {
                        if(oneChangeRegistered)
                        {
                            return false;
                        }
                        else
                        {
                            oneChangeRegistered = true;
                        }
                        
                    }
                }
            }

            return true;
        }
    }
}