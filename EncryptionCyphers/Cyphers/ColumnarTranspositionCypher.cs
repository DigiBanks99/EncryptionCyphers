using System;
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
      FillColumns(plainText, columns);

      return columns;
    }

    private Dictionary<int, List<char?>> BuildColumnStructure(string key)
    {
      var columns = new Dictionary<int, List<char?>>();
      var keyColValues = GetKeyValues(key);

      for (var index = 0; index < keyColValues.Length; index++)
        columns.Add(keyColValues[index], new List<char?>());

      return columns;
    }

    private Dictionary<int, char?[]> BuildColumnStructure(string key, int columnDepth)
    {
      var columns = new Dictionary<int, char?[]>();
      var keyColValues = GetKeyValues(key);

      for (var index = 0; index < keyColValues.Length; index++)
        columns.Add(keyColValues[index], new char?[columnDepth]);

      return columns;
    }

    private void FillColumns(string plainText, Dictionary<int, List<char?>> columns)
    {
      var colText = plainText;
      var randomiser = new Random();
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
    /// Encrypt the plain text using the provided key. Optionally the remainder of the columns can be filled with a padded
    /// character.
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="plainText">The text to be encrypted</param>
    /// <param name="padCharacter">The optional character to pad the remainder of the columns</param>
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
    /// Determine the depth of each column 
    /// </summary>
    /// <param name="text"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public int DetermineColumnDepth(string text, string key)
    {
      return text.Length / key.Length;
    }

    public int DetermineColumnDepthRemainder(string text, string key)
    { 
      return text.Length % key.Length;
    }

    public string Decrypt(string key, string encryptedText)
    {
      var columnDepth = DetermineColumnDepth(encryptedText, key);
      var remainder = DetermineColumnDepthRemainder(encryptedText, key);
      var text = encryptedText;

      var columns = GetDecryptionColumns(text, key, columnDepth, remainder);

      var plainTextBuilder = new StringBuilder();

      var table = BuildTextTable(columns);
      var keyColValues = GetKeyValues(key);

      for (var row = 0; row <= table.GetUpperBound(1); row++)
      {
        foreach (var col in keyColValues)
        {
          var character = table[col - 1, row];
          if (character.HasValue)
            plainTextBuilder.Append(character);
        }
      }

      return plainTextBuilder.ToString();
    }

    public Dictionary<int, char?[]> GetDecryptionColumns(string text, string key, int columnDepth, int remainder)
    {
      var keyColValues = GetKeyValues(key);

      string[] sections = new string[keyColValues.Length];
      for (var i = 0; i < sections.Length; i++)
      {
        var length = columnDepth;
        if (remainder > 0 && i + 1 > keyColValues.Length - remainder)
          length++;
        sections[i] = text.Substring(0, length);
        text = text.Substring(length);
      }

      var depth = columnDepth;
      if (remainder > 0)
        depth++;

      var columns = BuildColumnStructure(key, depth);

      foreach (var column in columns)
      {
        var section = sections[column.Key - 1];

        for (var position = depth; position >= 0; position--)
        {
          if (section.Length >= position + 1)
            column.Value[position] = section[position];
        }
      }

      return columns;
    }

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
  }
}
