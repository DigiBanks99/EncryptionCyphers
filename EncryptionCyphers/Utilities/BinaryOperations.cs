using System.IO;
using System.Text;

namespace EncryptionCyphers.Utilities
{
  public class BinaryOperations
  {
    /// <summary>
    /// Convert a string to a byte array
    /// </summary>
    /// <param name="text">The string being converted to the byte array <seealso cref="byte[]"/></param>
    /// <returns>A byte array representation of the string</returns>
    public static byte[] ConvertToBytes(string text)
    {
      return Encoding.Default.GetBytes(text);
    }

    /// <summary>
    /// Checks if a file exists and then converts its content into a byte array.
    /// </summary>
    /// <param name="fileInfo">The file info of the file being read.<seealso cref="FileInfo"/></param>
    /// <returns>Byte array representation of the data contained in the file <seealso cref="byte[]"/></returns>
    public static byte[] ConvertToBytes(FileInfo fileInfo)
    {
      byte[] outBytes;
      if (!File.Exists(fileInfo.FullName))
        throw new FileNotFoundException(fileInfo.FullName);

      using (var stream = new FileStream(fileInfo.FullName, FileMode.Open))
      {
        outBytes = new byte[stream.Length];
        stream.Read(outBytes, 0, outBytes.Length);
      }

      return outBytes;
    }

    /// <summary>
    /// Returns a Unicode encoded string of the byte array data.
    /// </summary>
    /// <param name="data">Byte array of the data.</param>
    /// <returns>UTF32 encoded string <seealso cref="Encoding.Unicode"/></returns>
    public static string ConvertToString(byte[] data)
    {
      return Encoding.Default.GetString(data);
    }
  }
}
