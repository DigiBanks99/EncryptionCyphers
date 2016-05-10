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
      var expectedResult = "EVLNACDTESEAROFODEECWIREE";
      var cipher = new ColumnarTranspositionCypher();
      var encryptedText = cipher.Encrypt(key, plainText);
      Assert.AreEqual(expectedResult, encryptedText);

      key = "BLUE DOVE";
      plainText = "Complex string being tested";
      expectedResult = "lgeCtne spntsidorgxbtmi  ee";
      encryptedText = cipher.Encrypt(key, plainText);
      Assert.AreEqual(expectedResult, encryptedText);
    }

    [TestMethod()]
    [TestCategory("ColumnarTransposition")]
    public void DetermineColumnDepthTest()
    {
      var plainText = "Complex string being tested";
      var key = "BLUE DOVE";
      var cipher = new ColumnarTranspositionCypher();
      var columnDepth = cipher.DetermineColumnDepth(plainText, key);
      Assert.AreEqual(columnDepth, 3);

      key = "ZEBRAS";
      plainText = "WEAREDISCOVEREDFLEEATONCE";
      columnDepth = cipher.DetermineColumnDepth(plainText, key);
      Assert.AreEqual(columnDepth, 4);
    }

    [TestMethod()]
    [TestCategory("ColumnarTransposition")]
    public void DecryptionTest()
    {
      var key = "ZEBRAS";
      var plainText = "WEAREDISCOVEREDFLEEATONCE";
      var expectedResult = "EVLNACDTESEAROFODEECWIREE";
      var cipher = new ColumnarTranspositionCypher();
      var encryptedText = cipher.Encrypt(key, plainText);
      Assert.AreEqual(expectedResult, encryptedText);

      var decryptedText = cipher.Decrypt(key, encryptedText);
      Assert.AreEqual("WEAREDISCOVEREDFLEEATONCE", decryptedText);

      key = "BLUE DOVE";
      plainText = "Comp!ex string being tested";
      expectedResult = "!geCtne spntsidorgxbtmi  ee";
      encryptedText = cipher.Encrypt(key, plainText);
      Assert.AreEqual(expectedResult, encryptedText);

      var secondKey = "N3w l0nGer KeY @A";
      encryptedText = cipher.Encrypt(secondKey, encryptedText);

      decryptedText = cipher.Decrypt(secondKey, encryptedText);
      decryptedText = cipher.Decrypt(key, decryptedText);
      Assert.AreEqual(plainText, decryptedText);
    }
  }
}
