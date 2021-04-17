// Given two strings write a method to decide if one is a permutation of another

using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysAndStrings {

    class Program {

        static void Main(string[] args) {

            Program program = new Program();

            var inputStrings = new List<(string, string)>
            {
                ("abc", "cba"),
                ("abc", "dct"), 
                ("ret", "re t"),
                ("gert", "ter")
            };
            
            foreach ((string string1, string string2) the_string in inputStrings)
            {
                //Console.WriteLine(the_string.string1);
                Console.WriteLine(program.is_permutation(the_string.string1, the_string.string2));
            }

        }

        bool is_permutation(string string1, string string2)
        {
            
            if(string1.Length != string2.Length)
            {
                return false;
            }

            int[] count_map = new int[128];

            for(int i=0; i < string1.Length; i++)
            {
                count_map[(int)string1[i]] += 1;
                Console.WriteLine($"Value: {count_map[(int)string1[i]]}");
            }

            for(int i=0; i < string1.Length; i++)
            {
                count_map[(int)string2[i]] -= 1;
                if(count_map[(int)string2[i]] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}