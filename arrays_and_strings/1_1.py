# Implement an algrithm to determine if a string has all unique characters
# What if you cannot use additional data structures

EXAMPLE_INPUTS = ['abcde', 'abba', 'aseoifjaslewfkjaseifjlkf', 'aaaaaa', 'abcdefga']

# BRUTE FORCE SOLUTION: involves iterating over the string for each char to check for equality

# This is my initial solution
def all_unique_chars(input_string):

    count_map = {}
    for char in input_string:

        if char in count_map:
            return False
        else:
            count_map[char] = True
    
    return True

# Using sets seems a bit more pythonic?
def all_unique_chars_with_sets(input_string):

    if len(input_string) != len(set(input_string)):
        return False
    else:
        return True
    

for input in EXAMPLE_INPUTS:

    print(all_unique_chars_with_sets(input))


# Book mentions asking if the strings are in ASCII or Unicode