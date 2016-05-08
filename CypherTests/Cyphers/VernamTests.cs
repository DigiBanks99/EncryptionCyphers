using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EncryptionCyphers.Cyphers.Tests
{
  [TestClass()]
  public class VernamTests
  {
    [TestMethod()]
    public void VernamManagerTest()
    {
      var manager = new VernamManager();
      Assert.IsInstanceOfType(manager, typeof(VernamManager));
    }

    [TestMethod()]
    public async Task GetKeyTest()
    {
      var manager = new VernamManager();
      manager.SetPlainText("Test some text");
      byte[] key = null;
      try
      {
        key = await manager.GetKey();
      }
      catch (Exception e)
      {
        if (e.Message == "Please set the cypher's plain text first.")
          Assert.Fail();
      }
      Assert.IsNotNull(key);

      manager = new VernamManager();
      key = null;
      try
      {
        key = await manager.GetKey();
      }
      catch (Exception e)
      {
        Assert.AreEqual(e.Message, "Please set the cypher's plain text first.");
      }
    }

    [TestMethod()]
    public async Task EncryptStringTest()
    {
      var message = "Test string for encryption";
      var manager = new VernamManager();
      var encryptedText = await manager.EncryptString(message);
      Assert.AreNotEqual(message, encryptedText);
    }

    [TestMethod()]
    public async Task EncryptFileAsyncTest()
    {
      var obj = new ComplexObject() { ID = 5, Description = "Test Object", CreatedOn = DateTime.Now };
      var path = Path.Combine(Environment.CurrentDirectory, "Tests", "TestVernam.dat");
      var testFileInfo = new FileInfo(path);
      var encryptedPath = Path.Combine(Environment.CurrentDirectory, "Tests", "TestVernamEncrypted.dat");

      if (!Directory.Exists(testFileInfo.DirectoryName))
        Directory.CreateDirectory(testFileInfo.DirectoryName);

      try
      {
        byte[] plainText = null;
        using (var stream = new FileStream(path, FileMode.Create))
        {
          var serialiser = new BinaryFormatter();
          serialiser.Serialize(stream, obj);
          plainText = new byte[stream.Length];
          await stream.ReadAsync(plainText, 0, plainText.Length);
        }

        var manager = new VernamManager();
        await manager.EncryptFileAsync(path, encryptedPath);

        byte[] encryptedText = null;
        using (var stream = new FileStream(encryptedPath, FileMode.Open))
        {
          encryptedText = new byte[stream.Length];
          await stream.ReadAsync(encryptedText, 0, encryptedText.Length);
        }

        Assert.AreNotEqual(plainText, encryptedText);
      }
      finally
      {
        if (File.Exists(path))
          File.Delete(path);

        if (File.Exists(encryptedPath))
          File.Delete(encryptedPath);
      }
    }

    [TestMethod()]
    public async Task DecryptStringTest()
    {
      var message = "Test string for encryption";
      var manager = new VernamManager();
      manager.SetPlainText(message);
      var key = await manager.GetKey();
      var encryptedText = await manager.EncryptString(message, key);
      Assert.AreNotEqual(message, encryptedText);

      var decryptedText = manager.DecryptString(encryptedText, key);
      Assert.AreEqual(message, decryptedText);
    }

    [TestMethod()]
    public async Task DecryptFileAsyncTest()
    {
      var obj = new ComplexObject() { ID = 5, Description = "Test Object", CreatedOn = DateTime.Now };
      var path = Path.Combine(Environment.CurrentDirectory, "Tests", "TestVernam.dat");
      var testFileInfo = new FileInfo(path);
      var encryptedPath = Path.Combine(Environment.CurrentDirectory, "Tests", "TestVernamEncrypted.dat");
      var decryptedPath = Path.Combine(Environment.CurrentDirectory, "Tests", "TestVernamDecrypted.dat");

      if (!Directory.Exists(testFileInfo.DirectoryName))
        Directory.CreateDirectory(testFileInfo.DirectoryName);

      try
      {
        byte[] plainText = null;
        using (var stream = new FileStream(path, FileMode.Create))
        {
          var serialiser = new BinaryFormatter();
          serialiser.Serialize(stream, obj);
          plainText = new byte[stream.Length];
          await stream.ReadAsync(plainText, 0, plainText.Length);
        }

        var manager = new VernamManager();
        manager.SetPlainTextFromFile(path);
        var key = await manager.GetKey();
        await manager.EncryptFileAsync(path, encryptedPath, key);

        byte[] encryptedText = null;
        using (var stream = new FileStream(encryptedPath, FileMode.Open))
        {
          encryptedText = new byte[stream.Length];
          await stream.ReadAsync(encryptedText, 0, encryptedText.Length);
        }

        Assert.AreNotEqual(plainText, encryptedText);

        await manager.DecryptFileAsync(encryptedPath, decryptedPath, key);

        byte[] decryptedText = null;
        ComplexObject decryptedObject = null;
        using (var stream = new FileStream(decryptedPath, FileMode.Open))
        {
          decryptedText = new byte[stream.Length];
          await stream.ReadAsync(decryptedText, 0, decryptedText.Length);
        }

        using (var stream = new FileStream(decryptedPath, FileMode.Open))
        {
          var serializer = new BinaryFormatter();
          stream.Position = 0;
          decryptedObject = (ComplexObject)serializer.Deserialize(stream);
        }

        Assert.AreNotEqual(decryptedText, encryptedText);
        Assert.IsNotNull(decryptedObject);
        Assert.AreEqual(obj.ID, decryptedObject.ID);
        Assert.AreEqual(obj.Description, decryptedObject.Description);
        Assert.AreEqual(obj.CreatedOn, decryptedObject.CreatedOn);
      }
      finally
      {
        if (File.Exists(path))
          File.Delete(path);

        if (File.Exists(encryptedPath))
          File.Delete(encryptedPath);

        if (File.Exists(decryptedPath))
          File.Delete(decryptedPath);
      }
    }

    [Serializable]
    internal class ComplexObject
    {
      public int ID { get; set; }
      public string Description { get; set; }
      public DateTime CreatedOn { get; set; }
    }
  }
}