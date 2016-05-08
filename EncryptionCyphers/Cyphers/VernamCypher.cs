using System;

namespace EncryptionCyphers.Cyphers
{
  public class VernamCypher : ICypher
  {
    public eCypher Cypher
    {
      get { return eCypher.Vernam; }
    }

    /// <summary>
    /// Performs the Vernam Cypher on the provided bytes.
    /// </summary>
    /// <param name="plainText">The data represented as a byte array</param>
    /// <param name="key">The key representes as a byte array</param>
    /// <exception cref="ArgumentNullException">If plainText or key is null</exception>
    /// <exception cref="CypherRuleException">If the lenghts of the data and they key arrays are not equal</exception>
    /// <returns>The encrypted byte array of the provided plain text. <seealso cref="byte[]"/></returns>
    public byte[] Encrypt(byte[] plainText, byte[] key)
    {
      if (plainText == null)
        throw new ArgumentNullException("plainText");

      if (key == null)
        throw new ArgumentNullException("key");

      if (plainText.Length != key.Length)
        throw new CypherRuleException("The key does not match the length of the data.", Cypher);

      var encryptedText = new byte[plainText.Length];

      for (var index = 0; index < plainText.Length; index++)
      {
        var plainTextInt = (int)plainText[index];
        var keyTextInt = (int)key[index];
        var encodedVal = plainTextInt ^ keyTextInt; // Apply XOR on each byte sequence
        encryptedText[index] = (byte)encodedVal; // Add the encrypted byte to the encryptedText array
      }

      return encryptedText;
    }

    /// <summary>
    /// Decrypts data encrypted using the Vernam Cypher.
    /// </summary>
    /// <param name="encryptedText">The data represented as a byte array</param>
    /// <param name="key">The key representes as a byte array</param>
    /// <exception cref="ArgumentNullException">If encryptedText or key is null</exception>
    /// <exception cref="CypherRuleException">If the lenghts of the data and they key arrays are not equal</exception>
    /// <returns>The decrypted byte array of the provided encrypted data. <seealso cref="byte[]"/></returns>
    public byte[] Decrypt(byte[] encryptedText, byte[] key)
    {
      if (encryptedText == null)
        throw new ArgumentNullException("encryptedText");

      if (key == null)
        throw new ArgumentNullException("key");

      if (encryptedText.Length != key.Length)
        throw new Exception("The key does not match the length of the data.");

      // Since in Vernam decryption and encryption is the inverse of eachother, the logic for 
      // encryption and decription is the same.
      return Encrypt(encryptedText, key);
    }

    /// <summary>
    /// Generates a random key of the same length as the provided data array.
    /// </summary>
    /// <param name="data">The byte array representation of the data.</param>
    /// <returns>A randomises byte array of the same length as the data provided. <seealso cref="byte[]"/></returns>
    public byte[] GenerateKey(byte[] data)
    {
      if (data == null)
        throw new ArgumentNullException("data");

      var key = new byte[data.Length];

      // This is not truly random, as required by Vernam, but meets our purposes for this project
      var randomiser = new Random();
      randomiser.NextBytes(key);

      return key;
    }
  }
}
