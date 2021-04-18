// Given a string
// return true or false (EDIT: DON'T NEED THIS "+ all permutations of palindromes, else false)

// 'Tact Coa' -> 'taco cat' 'atco cta'

// Each letter bar one needs a pair
// => If more than 1 letter has only 1 appearance in a string, no palindromes exist

// Slightly misunderstood this question, thought you had to return all permutaions
// Just needs to return boolean to check in input string is a palindrome!

using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysAndStrings {


    class Program {

        static void Main(string[] args)
        {
            Program program = new Program();

            
            List<string> testStrings = new List<string>{"Tact Coa", "racecar", "abc", "abba", "baca"};


            foreach(string inputString in testStrings)
            {
                Console.WriteLine(program.isPalindrome(inputString));
            }    
        }

        bool isPalindrome(string inputString)
        {
            string lowecaseInputString = inputString.ToLower();
            IDictionary<char, int> countMap = new Dictionary<char, int>();

            foreach(char c in lowecaseInputString)
            {
                if(c != ' ')
                {
                    if(!countMap.ContainsKey(c))
                    {
                        countMap.Add(c, 1);
                    }
                    else
                    {
                        countMap[c] += 1;
                    }
                }
            }

            // Check that there's only one odd number in the letters
            bool haveSingleChar = false;
            List<char> charactersWhichCanBePalindromed = new List<char>();
            foreach(KeyValuePair<char, int> kvp in countMap)
            {
                if(kvp.Value % 2 == 1)
                {
                    if(haveSingleChar)
                    {   
                        return false; 
                    }
                    else{
                        haveSingleChar = true;
                        for(int i=0; i < (kvp.Value-1); i++)
                        {
                            charactersWhichCanBePalindromed.Add(kvp.Key);
                        }
                    }
                }
                else
                {
                    for(int i=0; i < (kvp.Value/2); i++)
                    {
                        charactersWhichCanBePalindromed.Add(kvp.Key);
                    }
                }
            }

            return true;
        }
    }
}