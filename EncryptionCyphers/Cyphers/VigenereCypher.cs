using System.Text;

namespace EncryptionCyphers.Cyphers
{
  public class VigenereCypher : ICypher
  {
    public eCypher Cypher
    {
      get { return eCypher.Vigenere; }
    }

    public const string FULLALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";

    public static char[] GetAlphabet(int baseNumber)
    {
      var alphabet = new char[baseNumber];

      for (var i = 0; i < baseNumber; i++)
      {
        alphabet[i] = FULLALPHABET[i];
      }

      return alphabet;
    }

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

    private void AddAlphabetToTable(char[,] table, char[] alphabet, int tableOffset)
    {
      for (var i = 0; i < alphabet.Length; i++)
      {
        table[tableOffset, i] = alphabet[i];
      }
    }

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

    public string Encrypt(string plainText, string key, int baseNumber)
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
  }
}
