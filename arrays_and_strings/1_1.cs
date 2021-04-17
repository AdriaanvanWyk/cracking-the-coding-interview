// Implement an algrithm to determine if a string has all unique characters
// What if you cannot use additional data structures

using System;

namespace ArraysAndStrings {

    class Program {

        static void Main(string[] args) {

            Program program = new Program();

            string[] input_strings = {"abcde", "abba", "aseoifjaslewfkjaseifjlkf", "aaaaaa", "abcdefga", "aqwertyu"};
            
            foreach (string input_string in input_strings)
            {
                Console.WriteLine(program.all_unique_chars(input_string));
            }

        }

        bool all_unique_chars(string input_string)
        {
            bool[] count_map = new bool[128];

            foreach (char letter in input_string)
            {
                if(count_map[(int)letter])
                {
                    return false;
                }
                else
                {
                    count_map[(int)letter] = true;
                }
            }

            return true;
        }
    }
}