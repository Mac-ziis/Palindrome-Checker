using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
// using System.Collections.Generic;
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
      Checker checker = new Checker();
      
      //Act
      bool result = Checker.validPalindrome(validPalindrome);

      //Assert
      Assert.IsTrue(result);
    }

    [TestMethod] 
    public void IsPalindrome_PalindromeString_ReturnsFalse()
    {
      //Arrange
      string validPalindrome = "hello";
      Checker checker = new Checker();

      //Act
      bool result = CheckerTests.validPalindrome(validPalindrome);

      //Assert
      Assert.IsFalse(result);
    }
  }
}
