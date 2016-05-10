using System;
using System.Collections.Generic;

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

      for (var index= 0; index < key.Length; index++)
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
    /// <returns>A <see cref="Dictionary{int, char[]}"/> with the column order as the key and characters from the plain text
    /// as values in a <see cref="char[]"/>.</returns>
    public Dictionary<int, List<char>> GetColumns(string key, string plainText, char? padCharacter)
    {
      var columns = new Dictionary<int, List<char>>();
      var keyColValues = GetKeyValues(key);

      // build columns
      for (var index = 0; index < keyColValues.Length; index++)
        columns.Add(keyColValues[index], new List<char>());

      // Fill columns
      var colText = plainText;
      var randomiser = new Random();
      while (!string.IsNullOrEmpty(colText))
      {
        int index = 0;
        foreach (var col in columns)
        {
          if (colText.Length > index)
            col.Value.Add(colText[index++]);
          else if (padCharacter.HasValue)
            col.Value.Add(padCharacter.Value);
          else
            col.Value.Add(GetNullText(randomiser));
        }

        colText = colText.Substring(index);
      }

      return columns;
    }

    public string Encrypt(string key, string plainText, char? padCharacter = null)
    {
      var columns = GetColumns(key, plainText, padCharacter);
      var encryptedText = string.Empty;

      for (var i = 1; i <= columns.Count; i++)
      {
        var characters = columns[i];
        foreach (char character in characters)
          encryptedText += character.ToString();
      }

      return encryptedText;
    }

    /// <summary>
    /// Gets a randomised <see cref="char"/> value.
    /// </summary>
    /// <param name="randomiser">Supply a randomiser to ensure similar seeding does not happen.</param>
    /// <returns></returns>
    private char GetNullText(Random randomiser)
    {
      int randomInt = -1;
      var validChar = false;
      while (!validChar)
      {
        randomInt = randomiser.Next();
        var charMax = char.GetNumericValue(char.MaxValue);
        var charMin = char.GetNumericValue(char.MinValue);

        if (charMin <= randomInt && randomInt <= charMax)
          validChar = true;
      }
      return (char)randomInt;
    }
  }
}
