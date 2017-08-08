using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergies.Models;
using System;

namespace Allergies.Test
{
  [TestClass]
  public class AllergiesTest
  {
    [TestMethod]
    public void ReadBinary_ReturnAllergyStringBasedOnInputScore_List()
    {
      //Arrange
      AllergiesScore testScore = new AllergiesScore(31);
      List<string> expected = new List<string>{"tomatoes","strawberries","shellfish","peanuts","eggs"};
      //Act
      List<string> actual = testScore.ReadBinary();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
  }

}
