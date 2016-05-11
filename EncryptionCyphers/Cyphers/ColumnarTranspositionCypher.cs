using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptionCyphers.Cyphers
{
  public class ColumnarTranspositionCypher : ICypher
  {
    public eCypher Cypher { get { return eCypher.ColumnarTransposition; } }

    /// <summary>
    /// Assign an incremental value to each character in the key, ensuring that no duplicate values are assigned.
    /// </summary>
    /// <param name="key">A string of characters.</param>
    /// <returns>A <see cref="int[]"/> of values matching the apprioptrate key character.</returns>
    public int[] GetKeyValues(string key)
    {
      var values = new int[key.Length];

      for (var index = 0; index < key.Length; index++)
      {
        values[index] = (int)key[index];
      }

      int[] orderedKey = new int[key.Length];

      for (var index = 1; index <= key.Length; index++)
      {
        var minIndex = -1;
        var minVal = int.MaxValue;

        for (var position = 0; position < values.Length; position++)
        {
          if (position == minIndex)
            continue;

          if (values[position] < minVal)
          {
            minVal = values[position];
            minIndex = position;
          }
        }

        orderedKey[minIndex] = index;
        values[minIndex] = int.MaxValue; // So, set values are not considered as min again.
      }

      return orderedKey;
    }

    /// <summary>
    /// Builds the columns from the plaintext using the key supplied.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="plainText">The plaintext being encrypted.</param>
    /// <param name="padCharacter">A character that can be supplied to fill spaces not fille by the key</param>
    /// <returns>A <see cref="Dictionary{int, char?[]}"/> with the column order as the key and characters from the plain text
    /// as values in a <see cref="char?[]"/>.</returns>
    public Dictionary<int, List<char?>> GetColumns(string key, string plainText)
    {
      var columns = BuildColumnStructure(key);
      FillEncryptionColumns(plainText, columns);

      return columns;
    }

    /// <summary>
    /// Builds the structure of the key column lookup table.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <returns>A <seealso cref="Dictionary{int, List{char?}}"/> with the key as the encryption key character value,
    /// and the value the column structure containing the text characters.</returns>
    private Dictionary<int, List<char?>> BuildColumnStructure(string key)
    {
      var columns = new Dictionary<int, List<char?>>();
      var keyColValues = GetKeyValues(key);

      for (var index = 0; index < keyColValues.Length; index++)
        columns.Add(keyColValues[index], new List<char?>());

      return columns;
    }

    /// <summary>
    /// Builds the structure of the key column lookup table.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="columnDepth">The depth the columns must reach.</param>
    /// <returns>A <seealso cref="Dictionary{int, char?[]}"/> with the key as the encryption key character value,
    /// and the value the column structure containing the text characters.</returns>
    private Dictionary<int, char?[]> BuildColumnStructure(string key, int columnDepth)
    {
      var columns = new Dictionary<int, char?[]>();
      var keyColValues = GetKeyValues(key);

      for (var index = 0; index < keyColValues.Length; index++)
        columns.Add(keyColValues[index], new char?[columnDepth]);

      return columns;
    }

    /// <summary>
    /// Fills the lookup structure's columns with the appropriate values.
    /// </summary>
    /// <param name="plainText">The text to be encrypted.</param>
    /// <param name="columns">The lookup structure to be filled.</param>
    private void FillEncryptionColumns(string plainText, Dictionary<int, List<char?>> columns)
    {
      var colText = plainText;
      while (!string.IsNullOrEmpty(colText))
      {
        int index = 0;
        foreach (var col in columns)
        {
          if (colText.Length > index)
            col.Value.Add(colText[index++]);
          else
            col.Value.Add(null);
        }

        colText = colText.Substring(index);
      }
    }

    /// <summary>
    /// Encrypt the plain text using the provided key.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="plainText">The text to be encrypted.</param>
    /// <returns></returns>
    public string Encrypt(string key, string plainText)
    {
      var columns = GetColumns(key, plainText);
      var encryptedText = string.Empty;

      for (var i = 1; i <= columns.Count; i++)
      {
        var characters = columns[i];
        foreach (char? character in characters)
        {
          if (character.HasValue)
            encryptedText += character.ToString();
        }
      }

      return encryptedText;
    }

    /// <summary>
    /// Decrypt the encrypted text using the provided key.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="encryptedText">The text to be decrypted.</param>
    /// <returns></returns>
    public string Decrypt(string key, string encryptedText)
    {
      var columnDepth = DetermineColumnDepth(encryptedText, key);
      var remainder = DetermineColumnDepthRemainder(encryptedText, key);
      var columns = GetDecryptionColumns(encryptedText, key, columnDepth, remainder);
      return BuildDecryptedString(key, columns);
    }

    /// <summary>
    /// Determine the depth of each column.
    /// </summary>
    /// <param name="text">The text to be encrypted.</param>
    /// <param name="key">The key for the encryption.</param>
    /// <returns>A <see cref="int"/> value indicating the length, calculated as text.Length / key.Length.</returns>
    public int DetermineColumnDepth(string text, string key)
    {
      return text.Length / key.Length;
    }

    /// <summary>
    /// Determine the remainder depth the string would require. The remainder indicates which columns need
    /// additional length columns in the structure.
    /// </summary>
    /// <param name="text">The text to be encrypted.</param>
    /// <param name="key">The key for the encryption.</param>
    /// <returns>A <see cref="int"/> value indicating the remainder, calculated as text.Length % key.Length.</returns>
    public int DetermineColumnDepthRemainder(string text, string key)
    { 
      return text.Length % key.Length;
    }

    /// <summary>
    /// Build the return string from the lookup structure.
    /// </summary>
    /// <param name="key">The key for the decryption.</param>
    /// <param name="columns">The lookup structure.</param>
    /// <returns>The decrypted text.</returns>
    private string BuildDecryptedString(string key, Dictionary<int, char?[]> columns)
    {
      var plainTextBuilder = new StringBuilder();

      var table = BuildTextTable(columns);
      var keyColValues = GetKeyValues(key);

      // Start at the top row and move down to the remainder row
      for (var row = 0; row <= table.GetUpperBound(1); row++)
      {
        // Start at the left most column as ordered by the key character values
        foreach (var col in keyColValues)
        {
          var character = table[col - 1, row];
          if (character.HasValue) // If the character is not a null value
            plainTextBuilder.Append(character);
        }
      }

      return plainTextBuilder.ToString();
    }

    /// <summary>
    /// Get the column lookup structure, with the <see cref="Dictionary{int, char?[]}.Key"/> as the key character value
    /// and the <see cref="Dictionary{int, char?[]}.Value"/> as the string characters placed in their respective rows.
    /// </summary>
    /// <param name="text">The text to be decrypted.</param>
    /// <param name="key">The key to use for the decryption.</param>
    /// <param name="columnDepth">The depth of all columns.</param>
    /// <param name="remainder">The remainder of columns that require extra depth.</param>
    /// <returns>A lookup structure, with the <see cref="Dictionary{int, char?[]}.Key"/> as the key character value
    /// and the <see cref="Dictionary{int, char?[]}.Value"/> as the string characters placed in their respective rows.</returns>
    public Dictionary<int, char?[]> GetDecryptionColumns(string text, string key, int columnDepth, int remainder)
    {
      var keyColValues = GetKeyValues(key);
      var remainderIndexList = GetRemainderKeyValues(keyColValues, remainder);
      string[] sections = GetStringKeySections(text, columnDepth, keyColValues, remainderIndexList);

      var depth = columnDepth;
      if (remainder > 0)
        depth++;

      var columns = BuildColumnStructure(key, depth);
      FillDecryptionColumns(sections, depth, columns);

      return columns;
    }

    /// <summary>
    /// Add the decryption text characters to their respective columns and rows.
    /// </summary>
    /// <param name="sections">The sections corresponding to the key character values.</param>
    /// <param name="rowLength">How many rows are required per column.</param>
    /// <param name="columns">The column lookup structure to be filled.</param>
    private static void FillDecryptionColumns(string[] sections, int rowLength, Dictionary<int, char?[]> columns)
    {
      foreach (var column in columns)
      {
        var section = sections[column.Key - 1];

        for (var position = rowLength; position >= 0; position--)
        {
          if (section.Length >= position + 1)
            column.Value[position] = section[position];
        }
      }
    }

    /// <summary>
    /// Break the string into sections corresponding to each key character value.
    /// </summary>
    /// <param name="text">The text to be decrypted.</param>
    /// <param name="columnDepth">The number of rows in the lookup structure columns.</param>
    /// <param name="keyColValues">The key character values index.</param>
    /// <param name="remainderIndexList">The key characters that should contain additional characters to 
    /// the <paramref name="columnDepth"/>.</param>
    /// <returns></returns>
    private static string[] GetStringKeySections(string text, int columnDepth, int[] keyColValues, List<int> remainderIndexList)
    {
      string[] sections = new string[keyColValues.Length];
      for (var i = 0; i < sections.Length; i++)
      {
        var length = columnDepth;
        if (remainderIndexList.Contains(i + 1))
          length++;
        sections[i] = text.Substring(0, length);
        text = text.Substring(length);
      }

      return sections;
    }

    /// <summary>
    /// Build a simple <see cref="char?[,]"/> table with the string characters taking up each value position.
    /// Null values will fill the remainder row where no text should be.
    /// </summary>
    /// <param name="columns">The lookup structure.</param>
    /// <returns>A table with the text in order.</returns>
    public char?[,] BuildTextTable(Dictionary<int, char?[]> columns)
    {
      var table = new char?[columns.Count, columns.First().Value.Length];

      foreach (var column in columns)
      {
        for (var pos = 0; pos < column.Value.Length; pos++)
        {
          if (column.Value[pos].HasValue)
            table[column.Key - 1, pos] = column.Value[pos];
        }
      }

      return table;
    }

    /// <summary>
    /// Get the key values, require additional space for additional text characters.
    /// </summary>
    /// <param name="keyColValues">The key character values.</param>
    /// <param name="remainder">The remainder after depth computation, of key characters that require additional space.</param>
    /// <returns>A <seealso cref="List{int}"/> with the key character values that require additional character space.</returns>
    public List<int> GetRemainderKeyValues(int[] keyColValues, int remainder)
    {
      var remainderValueList = new List<int>();

      for (var i = 0; i < keyColValues.Length; i++)
      {
        if (i + 1 <= remainder)
          remainderValueList.Add(keyColValues[i]);
      }

      return remainderValueList;
    }
  }
}
