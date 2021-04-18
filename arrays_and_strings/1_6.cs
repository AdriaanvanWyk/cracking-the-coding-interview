// String compression
// aaabbbcdda => a3b3c1d2a1

// My initial solution contained concatenation which is extremely inneficient (O(n^2))
// Should have used a StringBuiled instead
// StringBuilder is a mutable string class which allows appending, replacing or inserting characters
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ArraysAndStrings 
{
    class Program {

        static void Main(string[] args)
        {

            Program program = new Program();

            List<string> testInputs = new List<string>
            {"aaabbbcdda", "aaabbb", "abcd"};

            foreach(string inputString in testInputs)
            {
                Console.WriteLine(program.getCompressedString(inputString));   
            }
        }

        string getCompressedString(string s)
        {
            // If you want you can count the amount of compression needed
            // and initalize the string builder correctly
            StringBuilder compressedString = new StringBuilder();
            char currentChar = s[0];
            int currentCharCount = 0;
            bool onlyOnes = true;

            foreach(char c in s)
            {
                if(currentChar == c)
                {
                    currentCharCount += 1;
                }
                else
                {
                    compressedString.Append($"{currentChar}{currentCharCount}");
                    currentChar = c;
                    currentCharCount = 1;
                }

                if(currentCharCount > 1)
                {
                    onlyOnes = false;
                }
            }

            compressedString.Append($"{currentChar}{currentCharCount}");

            if(onlyOnes)
            {
                return s;
            }
            else
            {
                return compressedString.ToString();
            }


            
        }
    }
}