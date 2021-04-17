# Given two strings write a method to decide if one is a permutation of another
                    #True
EXAMPLE_INPUTS = [('abc', 'cba'), ('abc', 'dct'), ('ret', 're t')]

def is_permutaion(s1, s2):

    # If the strings aren't the same size, they can't be permutations
    # (I managed to get this myself)
    if len(s1) != len(s2):
        return False
    
    for char in s1:
        if not char in s2:
            return False
    
    return True


# Her solution used a 128 size array where chars are inserted at their ASCII value
# eg 'a' would be insterted at 97 as ord('a') == 97
# Good space complexity
# My function above uses a built in function of Python, but how does the function work under the hood? 


for input in EXAMPLE_INPUTS:

    print(input, is_permutaion(input[0], input[1]))



# Questions I didn't ask:
# ASCII or Unicode
# Does Casing matter
# Whitespace??