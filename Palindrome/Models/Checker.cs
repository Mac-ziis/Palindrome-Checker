using System.Collections.Generic;
using System;

namespace Palindrome.Models
{
  public class Checker
  {
    public static bool validPalindrome(string input)
    {
      string reversedInput = ReverseString(input);

      return input == reversedInput;
    }

    private static string ReverseString(string input)
    {
      char[] charArray = input.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
  }
}