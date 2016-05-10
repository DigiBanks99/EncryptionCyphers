using EncryptionCyphers.Cyphers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CypherTests.Cyphers
{
  [TestClass()]
  public class ColumnarTranspositionTests
  {
    [TestMethod()]
    [TestCategory("ColumnarTransposition")]
    public void GetKeyValuesTest()
    {
      var key = "Testing";
      var cipher = new ColumnarTranspositionCypher();
      var orderedItems = cipher.GetKeyValues(key);
      var expectedValues = new int[] { 1, 2, 6, 7, 4, 5, 3 };
      Assert.AreEqual(expectedValues.Length, orderedItems.Length);

      for (var i = 0; i < key.Length; i++)
      {
        Assert.AreEqual(expectedValues[i], orderedItems[i]);
      }

      key = "TESTING";
      orderedItems = cipher.GetKeyValues(key);
      expectedValues = new int[] { 6, 1, 5, 7, 3, 4, 2 };
      Assert.AreEqual(expectedValues.Length, orderedItems.Length);

      for (var i = 0; i < key.Length; i++)
      {
        Assert.AreEqual(expectedValues[i], orderedItems[i]);
      }
    }

    [TestMethod()]
    [TestCategory("ColumnarTransposition")]
    public void EncryptText()
    {
      var key = "ZEBRAS";
      var plainText = "WEAREDISCOVEREDFLEEATONCE";
      var expectedResult = "EVLNQACDTQESEAQROFOQDEECQWIREE";
      var cipher = new ColumnarTranspositionCypher();
      var encryptedText = cipher.Encrypt(key, plainText, 'Q');
      Assert.AreEqual(expectedResult, encryptedText);

      key = "BLUE DOVE";
      plainText = "Complex string being tested";
      expectedResult = "lgeCtne spntsidorgxbtmi  ee";
      encryptedText = cipher.Encrypt(key, plainText);
      Assert.AreEqual(expectedResult, encryptedText);
    }
  }
}
