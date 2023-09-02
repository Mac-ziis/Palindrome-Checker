using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
using System.Collections.Generic;
using System;

namespace Palindrome.Tests
{
  [TestClass]
  public class CheckerTests
  {
    [TestMethod]
    public void IsPalindrome_PalindromeString_ReturnsTrue()
    {
      //Arrange
      string validPalindrome = "civic";

      //Act
      bool result = Checker.IsPalindrome(validPalindrome);

      //Assert
      Assert.IsTrue(result);
    }

    // [TestMethod]
    // public void GetText_ReturnsText_String()
    // {
    //   string word = "meow";
    //   Text newText = new Text(word);
    //   string result = newText.Word;
    //   Assert.AreEqual(word, result);
    // }

    // [TestMethod]
    // public static void IsPalindrome_PalindromeString_ReturnsTrue()
    // {
    //   // Arrange
    //   string word = "racecar";

    //   // Act
    //   bool isPalindrome = PalindromeChecker.IsPalindrome(word);

    //   // Assert
    //   Assert.IsTrue(isPalindrome);
    // }
  }
}
