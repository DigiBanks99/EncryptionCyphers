using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncryptionCyphers.Cyphers.Tests
{
  [TestClass()]
  public class VigenereTests
  {
    [TestMethod()]
    [TestCategory("Vinegere")]
    public void GetReorderedAlphabetTest()
    {
      char[] baseAlphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
      char[] offset1Alphabet = new char[] { 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A' };
      char[] offset5Alphabet = new char[] { 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E' };
      char[] offset11Alphabet = new char[] { 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K' };

      var vigenere = new VigenereCypher();
      var reordered1 = vigenere.GetReorderedAlphabet(1, baseAlphabet);
      var reordered5 = vigenere.GetReorderedAlphabet(5, baseAlphabet);
      var reordered11 = vigenere.GetReorderedAlphabet(11, baseAlphabet);

      Assert.AreEqual(reordered1.Length, offset1Alphabet.Length);

      for (var i = 0; i < reordered1.Length; i++)
      {
        Assert.AreEqual(reordered1[i], offset1Alphabet[i]);
      }

      Assert.AreEqual(reordered5.Length, offset5Alphabet.Length);

      for (var i = 0; i < reordered5.Length; i++)
      {
        Assert.AreEqual(reordered5[i], offset5Alphabet[i]);
      }

      Assert.AreEqual(reordered11.Length, offset11Alphabet.Length);

      for (var i = 0; i < reordered11.Length; i++)
      {
        Assert.AreEqual(reordered11[i], offset11Alphabet[i]);
      }
    }

    [TestMethod()]
    [TestCategory("Vinegere")]
    public void GetVinegereTableTest()
    {
      char[,] testTable = new char[5, 5] { { 'A', 'B', 'C', 'D', 'E' }, { 'B', 'C', 'D', 'E', 'A' }, { 'C', 'D', 'E', 'A', 'B' }, { 'D', 'E', 'A', 'B', 'C' }, { 'E', 'A', 'B', 'C', 'D' } };

      var vinegere = new VigenereCypher();
      var table = vinegere.GetVinegereTable(5);

      Assert.AreEqual(testTable.Length, table.Length);

      for (var offset = 0; offset < table.Rank; offset++)
      {
        for (var position = 0; position < table.GetLength(offset); position++)
        {
          Assert.AreEqual(testTable[offset, position], table[offset, position]);
        }
      }
    }

    [TestMethod()]
    [TestCategory("Vinegere")]
    public void BuildFullLengthKeyTest()
    {
      var key = "MYKEY";
      var longKey = "MYKEYMYKEYMYKEY";
      var shortKey = "MYK";
      var vinegere = new VigenereCypher();
      var generatedKey = vinegere.BuildFullLengthKey(key, 15);
      Assert.AreEqual(longKey, generatedKey);
      generatedKey = vinegere.BuildFullLengthKey(key, 3);
      Assert.AreEqual(shortKey, generatedKey);
    }

    [TestMethod()]
    [TestCategory("Vinegere")]
    public void EncryptTest()
    {
      var plainText = "ATTACKATDAWN";
      var key = "LEMON";
      var testCypherResult = "LXFOPVEFRNHR";

      var vinegere = new VigenereCypher();
      var cypherResult = vinegere.Encrypt(plainText, key, 26);
      Assert.AreEqual(cypherResult, testCypherResult);
      Assert.AreEqual(cypherResult.Length, testCypherResult.Length);

      var complexString = "T3sting @ string with var1oUs values, s!gns.";
      var complexKey = "C0mP13XkeY";
      var complexEncryptedString = vinegere.Encrypt(complexString, complexKey, VigenereCypher.FULLALPHABET.Length);

      Assert.AreNotEqual(complexEncryptedString, complexString);
      Assert.AreEqual(complexEncryptedString.Length, complexString.Length);
    }

    [TestMethod()]
    [TestCategory("Vinegere")]
    public void DecryptTest()
    {
      var plainText = "ATTACKATDAWN";
      var key = "LEMON";
      var testCypherResult = "LXFOPVEFRNHR";

      var vinegere = new VigenereCypher();
      var cypherResult = vinegere.Encrypt(plainText, key, 26);
      Assert.AreEqual(cypherResult, testCypherResult);
      Assert.AreEqual(cypherResult.Length, testCypherResult.Length);

      var decryptedText = vinegere.Decrypt(cypherResult, key, 26);
      Assert.AreEqual(decryptedText, plainText);
      Assert.AreEqual(decryptedText.Length, plainText.Length);

      var complexString = "T3sting @ \"string\" with var1oUs 'values', s!gns. patTerN5 etC.";
      var complexKey = "C0mP13XkeY";
      var complexEncryptedString = vinegere.Encrypt(complexString, complexKey, VigenereCypher.FULLALPHABET.Length);

      Assert.AreNotEqual(complexEncryptedString, complexString);
      Assert.AreEqual(complexEncryptedString.Length, complexString.Length);

      var decryptedComplexText = vinegere.Decrypt(complexEncryptedString, complexKey, VigenereCypher.FULLALPHABET.Length);
      Assert.AreEqual(decryptedComplexText, complexString);
      Assert.AreEqual(decryptedComplexText.Length, complexString.Length);
    }
  }
}
