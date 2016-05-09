using System;
using System.Text;

namespace EncryptionCyphers.Cyphers
{
  public class VigenereCypher : ICypher
  {
    public eCypher Cypher
    {
      get { return eCypher.Vigenere; }
    }

    public const string FULLALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 `~!@#$%^&*()_+-={}|[]\\:\";'<>?,./";

    /// <summary>
    /// Gets the alphabet for the specified base number, limited to unicode characters
    /// </summary>
    /// <param name="baseNumber">The integer value of the number of unique characters to use in the alphabet</param>
    /// <exception cref="CypherRuleException">If the base is longer than <see cref="FULLALPHABET"/>.</exception>
    /// <returns>A <seealso cref="char[]"/> of unique alphabet characters</returns>
    public static char[] GetAlphabet(int baseNumber)
    {
      if (baseNumber > FULLALPHABET.Length)
        throw new CypherRuleException(string.Format("The base number cannot exceed {0} charcters.", FULLALPHABET.Length), eCypher.Vigenere);

      var alphabet = new char[baseNumber];

      for (var i = 0; i < baseNumber; i++)
      {
        alphabet[i] = FULLALPHABET[i];
      }

      return alphabet;
    }


    /// <summary>
    /// Gets a new alphabet built from <paramref name="alphabet"/> starting 
    /// at the character matching the offset and continuing with the skipped characters once the last character has been reached."/>
    /// </summary>
    /// <param name="offset">The offset value indicating where the alphabet will start.</param>
    /// <param name="alphabet">The alphabet that is being used as the base alphabet.</param>
    /// <returns>An alphabet similar to <paramref name="alphabet"/> but reordered as <seealso cref="char[]"/></returns>
    public char[] GetReorderedAlphabet(int offset, char[] alphabet)
    {
      if (alphabet == null)
        return GetAlphabet(26);

      var reorderedAlphabet = new char[alphabet.Length];

      for (var i = 0; i < alphabet.Length; i++)
      {
        var index = i + offset;
        if (index >= alphabet.Length)
          index = index - alphabet.Length;

        reorderedAlphabet[i] = alphabet[index];
      }

      return reorderedAlphabet;
    }

    /// <summary>
    /// Builds a Vinegere Table with an alphabet using the provided base number.
    /// </summary>
    /// <param name="baseNumber">The number of different characters to be used in the alphabet in the table.</param>
    /// <returns>A <seealso cref="char[,]"/> table of characters.</returns>
    public char[,] GetVinegereTable(int baseNumber)
    {
      var table = new char[baseNumber, baseNumber];

      var alphabet = GetAlphabet(baseNumber);
      AddAlphabetToTable(table, alphabet, 0);

      for (var offset = 0; offset < baseNumber; offset++)
      {
        var reorderedAlphabet = GetReorderedAlphabet(offset, alphabet);
        AddAlphabetToTable(table, reorderedAlphabet, offset);
      }

      return table;
    }

    /// <summary>
    /// Appends the provided alphabet to the table.
    /// </summary>
    /// <param name="table">The table being appended to.</param>
    /// <param name="alphabet">The alphabet being append to <paramref name="table"/>.</param>
    /// <param name="tableOffset">The first dimension offset of <paramref name="table"/> where <paramref name="alphabet"/> 
    /// will be appended to.</param>
    /// <exception cref="IndexOutOfRangeException">When the item being added to the table is out of bound of the table.</exception>
    private void AddAlphabetToTable(char[,] table, char[] alphabet, int tableOffset)
    {
      if (table.GetUpperBound(0) < tableOffset)
        throw new IndexOutOfRangeException();

      if (table.GetUpperBound(1) < alphabet.Length - 1)
        throw new IndexOutOfRangeException();

      for (var i = 0; i < alphabet.Length; i++)
      {
        table[tableOffset, i] = alphabet[i];
      }
    }

    /// <summary>
    /// Builds a new key of the length specified, by repeating the key's characters for the provided length.
    /// </summary>
    /// <param name="key">The original key.</param>
    /// <param name="length">The length the key should be after computation.</param>
    /// <exception cref="CypherRuleException">A key is required.</exception>
    /// <returns>A new key of repeating characters of the specified length.</returns>
    public string BuildFullLengthKey(string key, int length)
    {
      if (string.IsNullOrWhiteSpace(key))
        throw new CypherRuleException("A key must be supplied", eCypher.Vigenere);

      var keyBuilder = new StringBuilder();
      keyBuilder.Length = length;

      var offset = 0;
      for (var index = 0; index < length; index++)
      {
        if (offset >= key.Length)
          offset = 0;

        keyBuilder[index] = key[offset++];
      }

      return keyBuilder.ToString();
    }


    /// <summary>
    /// Encrypt the plain text, using the key provided, according to the Vigenere Cipher.
    /// </summary>
    /// <param name="plainText">The text to be encrypted.</param>
    /// <param name="key">The key provided for the encryption.</param>
    /// <param name="baseNumber" default="26">The number of unique characters to be considered during the encryption algorithm.</param>
    /// <returns>An encrypted string of the same length as the plain text.</returns>
    public string Encrypt(string plainText, string key, int baseNumber = 26)
    {
      var table = GetVinegereTable(baseNumber);
      var genereatedKey = BuildFullLengthKey(key, plainText.Length);

      var encryptedTextBuilder = new StringBuilder();
      encryptedTextBuilder.Length = plainText.Length;

      for (var index = 0; index < plainText.Length; index++)
      {
        char plainTextChar = plainText[index];
        char keyChar = genereatedKey[index];

        int colIndex = 0;
        int rowIndex = 0;

        bool colSet = false, rowSet = false;
        for (var lookup = 0; lookup < baseNumber; lookup++)
        {
          if (colSet && rowSet)
            break;

          if (table[lookup, 0] == plainTextChar)
          {
            colIndex = lookup;
            colSet = true;
          }

          if (table[0, lookup] == keyChar)
          {
            rowIndex = lookup;
            rowSet = true;
          }
        }
        
        encryptedTextBuilder[index] = table[colIndex, rowIndex];
      }

      return encryptedTextBuilder.ToString();
    }

    /// <summary>
    /// Decrypts a string that has been encrypted with the supplied key.
    /// </summary>
    /// <param name="cypherText">The encrypted text.</param>
    /// <param name="key">The key that was used to encrypt the text.</param>
    /// <param name="baseNumber" default="26">The number of unique characters to be considered during the encryption algorithm.</param>
    /// <returns>A decrypted string.</returns>
    public string Decrypt(string cypherText, string key, int baseNumber = 26)
    {
      var table = GetVinegereTable(baseNumber);
      var genereatedKey = BuildFullLengthKey(key, cypherText.Length);

      var plainTextBuilder = new StringBuilder();
      plainTextBuilder.Length = cypherText.Length;

      for (var index = 0; index < cypherText.Length; index++)
      {
        char keyChar = genereatedKey[index];
        char cypherTextChar = cypherText[index];

        int rowIndex = 0;
        int colIndex = 0;
        for (var row = 0; row < baseNumber; row++)
        {
          if (table[0, row] != keyChar)
            continue;

          rowIndex = row;
          break;
        }

        for (var col = 0; col < baseNumber; col++)
        {
          if (table[col, rowIndex] != cypherTextChar)
            continue;

          colIndex = col;
          break;
        }

        plainTextBuilder[index] = table[colIndex, 0];
      }

      return plainTextBuilder.ToString();
    }
  }
}
