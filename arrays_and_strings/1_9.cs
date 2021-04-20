// Assume you have a methos isSubsting which checks if one word is a substring of another.
// Given two strings, s1, s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring

using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysAndStrings
{

    class Program
    {

        static void Main(string[] args)
        {

            Program program = new Program();

            List<(string, string)> inputStrings = new List<(string, string)>()
            {
                ("waterbottle", "bottlewater"),
                ("drip", "ripd"),
                ("dertesdf", "wefioisdjf"),
                ("hello", "hello")

            };

            foreach((string s1, string s2) inputs in inputStrings)
            {
                Console.WriteLine(program.isSubsting(inputs.s1, inputs.s2));
            }
        }

        bool isSubsting(string s1, string s2)
        {

            if(s1.Equals(s2))
            {
                return true;
            }

            char firstChar;
            for(int i=0; i<s1.Length; i++)
            {
                firstChar = s1[0];
                s1 = s1.Substring(1)+firstChar;
                
                if(s1.Equals(s2))
                {
                    return true;
                }
            }

            return false;
        }
    }
}