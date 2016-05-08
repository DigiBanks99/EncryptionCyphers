using EncryptionCyphers.Utilities;
using System;
using System.IO;
using System.Threading.Tasks;

namespace EncryptionCyphers.Cyphers
{
  public class VernamManager
  {
    private VernamCypher _cypher = null;
    private byte[] _plainText = null;

    public VernamManager()
    {
      _cypher = new VernamCypher();
    }

    public void SetPlainText(string text)
    {
      _plainText = BinaryOperations.ConvertToBytes(text);
    }

    public void SetPlainTextFromFile(string filePath)
    {
      _plainText = BinaryOperations.ConvertToBytes(new FileInfo(filePath));
    }

    public async Task<byte[]> GetKey(string keyPath = null)
    {
      if (!string.IsNullOrWhiteSpace(keyPath))
      {
        return await GetKeyFromFile(keyPath);
      }

      if (_plainText == null)
        throw new Exception("Please set the cypher's plain text first.");

      var keyBytes = _cypher.GenerateKey(_plainText);
      if (keyBytes == null)
        throw new Exception("We were unable to compile a key from the data provided");

      return keyBytes;
    }

    private async Task<byte[]> GetKeyFromFile(string path)
    {
      if (!File.Exists(path))
        return null;

      byte[] key = null;
      using (var stream = new FileStream(path, FileMode.Open))
      {
        key = new byte[stream.Length];
        await stream.ReadAsync(key, 0, key.Length);
      }

      return key;
    }

    public async Task<string> EncryptString(string text, byte[] key = null)
    {
      SetPlainText(text);
      if (key == null)
        key = await GetKey();
      
      var encryptedText = _cypher.Encrypt(_plainText, key);
      return BinaryOperations.ConvertToString(encryptedText);
    }

    public async Task EncryptFileAsync(string unencryptedFilePath, string encryptedFilePath, byte[] key = null)
    {
      SetPlainTextFromFile(unencryptedFilePath);
      if (key == null)
        key = await GetKey();
      
      var encryptedText = _cypher.Encrypt(_plainText, key);

      using (var stream = new FileStream(encryptedFilePath, FileMode.Create))
      {
        await stream.WriteAsync(encryptedText, 0, encryptedText.Length);
      }
    }

    public string DecryptString(string text, byte[] key)
    {
      if (key == null)
        throw new ArgumentNullException("key");
      
      var encryptedText = BinaryOperations.ConvertToBytes(text);
      var plainText = _cypher.Decrypt(encryptedText, key);
      return BinaryOperations.ConvertToString(plainText);
    }

    public async Task DecryptFileAsync(string encryptedFilePath, string decryptedFilePath, byte[] key)
    {
      if (key == null)
        throw new ArgumentNullException("key");

      var encryptedFileInfo = new FileInfo(encryptedFilePath);
      var encryptedText = BinaryOperations.ConvertToBytes(encryptedFileInfo);
      var plainText = _cypher.Decrypt(encryptedText, key);

      using (var stream = new FileStream(decryptedFilePath, FileMode.Create))
      {
        await stream.WriteAsync(plainText, 0, plainText.Length);
      }
    }
  }
}
