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

      //Act
      bool result = Checker.IsPalindrome(validPalindrome);

      //Assert
      Assert.IsTrue(result);
    }
  }
}
