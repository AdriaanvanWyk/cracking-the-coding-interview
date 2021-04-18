// Replace all spaces in a string with %20
// String has spaces at the end to hold additional characters
// You are given the size of the string without the extra spaces
// Do operations in place
// EXAMPLE: Input: "Mr John Smith      ", 13
//          Output: "Mr%20John%20Smith"


using System;
using System.Collections.Generic;

namespace ArraysAndStrings {

    class Program {

        static void Main(string[] args) {

            Program program = new Program();

            var inputs = new List<(string, int)>
            {
                ("Mr John Smith    ", 13),
                ("My name is John      ", 15),
                ("JohnSmith", 9),
                ("", 0),
                ("   ", 1),
            };

            foreach((string inputString, int actualStringLength) input in inputs)
            {
                Console.WriteLine(program.urlify(input.inputString, input.actualStringLength));
            }
        }

        string urlify(string inputString, int actualStringLength)
        {

            string returnString;
            // If string has no ending spaces, no spaces exist in string
            if(inputString.Length == actualStringLength)
            {
                return inputString;
            }

            // If empty string
            if(actualStringLength == 0)
            {
                
                returnString = "You gave an empty string!!!!"; 
                return returnString;
            }

            string spaceEncoding = "%20";
            int nextFreeSpace = inputString.Length - 1;
            char[] charArray = inputString.ToCharArray();

            for(int i = actualStringLength-1; i >= 0; i--)
            {
                if(charArray[i] != ' ')
                {
                    charArray[nextFreeSpace] = charArray[i];
                    nextFreeSpace -= 1;
                }
                else 
                {

                    for(int j=spaceEncoding.Length-1; j >= 0; j--)
                    {
                        charArray[nextFreeSpace] = spaceEncoding[j];
                        nextFreeSpace -= 1;
                    }
                }
            }


            returnString = new string(charArray);

            return returnString;





        }
    }
}