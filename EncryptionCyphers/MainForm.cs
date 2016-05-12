using EncryptionCyphers.Cyphers;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionCyphers
{
  public partial class MainForm : Form
  {
    private DirectoryInfo _lastDir = null;
    private SynchronizationContext _synchronizationContext = null;
    private const int TEXTBOX_BUTTON_WIDTH = 30;
    private const int TEXTBOX_BUTTON_HEIGHT = 30;

    #region Constructor
    public MainForm()
    {
      InitializeComponent();
      LoadControl();
    } 
    #endregion

    #region Public Methods
    public void LoadControl()
    {
      InitialiseKeyStore();
      InitialiseVernamDataStore();
      SetInitialDirectory();
      SetupControls();
      SetVernamControlState();
    }
    #endregion

    #region Private Methods
    private void SetupControls()
    {
      SetupTextBoxButtons(textBoxVernamOpenFile, buttonVernamOpenFile);
      SetupTextBoxButtons(textBoxVernamSaveTo, buttonVernamSaveTo);
      SetupTextBoxButtons(textBoxVernamKeyStore, buttonVernamKeyStoreOpen);
      SetupTextBoxButtons(textBoxVernamKeyStore, buttonVernamKeyStoreSave, -TEXTBOX_BUTTON_HEIGHT);
    }

    private void SetupSynchronizationContext()
    {
      _synchronizationContext = WindowsFormsSynchronizationContext.Current;
    }

    private void SetupTextBoxButtons(TextBox textBox, Button button, int addedWidth = 0)
    {
      button.Size = new Size(TEXTBOX_BUTTON_WIDTH , textBox.ClientSize.Height + 2);
      button.Location = new Point(textBox.ClientSize.Width - button.Width + addedWidth, -1);
      button.Cursor = Cursors.Default;
      textBox.Controls.Add(button);
      // Send EM_SETMARGINS to prevent text from disappearing underneath the button
      SendMessage(textBox.Handle, 0xd3, (IntPtr)2, (IntPtr)(button.Width << 16));
    }

    private void SetInitialDirectory(string path = null)
    {
      if (string.IsNullOrWhiteSpace(path))
        path = Environment.CurrentDirectory;
      _lastDir = new DirectoryInfo(path);
    }

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

    private void Exit()
    {
      this.Close();
    }

    private void InitialiseKeyStore()
    {
      var dirInfo = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "KeyStore"));
      try
      {
        if (!dirInfo.Exists)
          Directory.CreateDirectory(dirInfo.FullName);
      }
      catch (IOException)
      {
        MessageBox.Show("Unable to initialise key store. Ensure your user has access to write to " + dirInfo.FullName + ".", "Initialisation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void InitialiseVernamDataStore()
    {
      var dirInfo = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Vernam"));
      try
      {
        if (!dirInfo.Exists)
          Directory.CreateDirectory(dirInfo.FullName);
      }
      catch (IOException)
      {
        MessageBox.Show("Unable to initialise key store. Ensure your user has access to write to " + dirInfo.FullName + ".", "Initialisation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void SetVernamControlState()
    {
      if (radioButtonFile.Checked)
      {
        richTextBoxVernamInput.Enabled = false;
        textBoxVernamOpenFile.Enabled = true;
      }
      else if (radioButtonText.Checked)
      {
        richTextBoxVernamInput.Enabled = true;
        textBoxVernamOpenFile.Enabled = false;
      }
    }
    #endregion

    #region Encryption Functions

    #region Vernam
    private async Task EncryptVernam()
    {
      var vernam = new VernamManager();
      var keyStore = textBoxVernamKeyStore.Text;
      if (string.IsNullOrWhiteSpace(keyStore))
        keyStore = Path.Combine(Environment.CurrentDirectory, "KeyStore", "Vernam" + DateTime.Now.ToString("yyyyMMddHHmmssttt") + ".key");

      if (radioButtonText.Checked)
        await EncryptVernamText(vernam, keyStore);
      else if (radioButtonFile.Checked)
        await EncryptVernamFile(vernam, keyStore);
    }

    private async Task EncryptVernamText(VernamManager vernam, string keyStore)
    {
      vernam.SetPlainText(richTextBoxVernamInput.Text);
      var keyBytes = await vernam.GetKey(keyStore);
      var keyDisplay = Encoding.Default.GetString(keyBytes);
      await vernam.SaveKey(keyStore, keyBytes);
      await vernam.EncryptStringAsync(textBoxVernamSaveTo.Text, richTextBoxVernamInput.Text, keyBytes);

      MessageBox.Show("Encryption successful. Your encrypted File and Key can be found in the locations specified.", "Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async Task EncryptVernamFile(VernamManager vernam, string keyStore)
    {
    }

    private async Task DecryptVernam()
    {
      var vernam = new VernamManager();
      var key = await vernam.GetKey(textBoxVernamKeyStore.Text);

      if (radioButtonText.Checked)
        await DecryptVernamText(vernam, key);
      else if (radioButtonFile.Checked)
        await DecryptVernamAsync(vernam, key);
    }

    private async Task DecryptVernamAsync(VernamManager vernam, byte[] key)
    {
      await vernam.DecryptFileAsync(textBoxVernamOpenFile.Text, textBoxVernamSaveTo.Text, key);

      MessageBox.Show("Decryption successful. Your decrypted File and can be found in the location specified.", "Decrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async Task DecryptVernamText(VernamManager vernam, byte[] key)
    {
      richTextBoxVernamInput.Text = await vernam.DecryptStringAsync(textBoxVernamSaveTo.Text, richTextBoxVernamInput.Text, key);

      MessageBox.Show("Decryption successful. Your decrypted File and can be found in the location specified.", "Decrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    #endregion Vernam

    #endregion Encryption Functions

    #region Events
    private void MainForm_Load(object sender, System.EventArgs e)
    {
      try
      {
        LoadControl();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonVernamOpenFile_Click(object sender, EventArgs e)
    {
      try
      {
        openFileDialog.FileName = textBoxVernamOpenFile.Text;
        openFileDialog.InitialDirectory = _lastDir.FullName;
        openFileDialog.ShowDialog();

        textBoxVernamOpenFile.Text = openFileDialog.FileName;
        if (string.IsNullOrWhiteSpace(openFileDialog.FileName))
          return;

        var fileInfo = new FileInfo(openFileDialog.FileName);
        SetInitialDirectory(fileInfo.DirectoryName);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonVernamSaveTo_Click(object sender, EventArgs e)
    {
      try
      {
        saveFileDialog.FileName = textBoxVernamSaveTo.Text;
        if (string.IsNullOrWhiteSpace(saveFileDialog.FileName))
          saveFileDialog.FileName = Path.Combine(Environment.CurrentDirectory, "Vernam", "VernamCypher" + DateTime.Now.ToString("yyyyMMddHHmmssttt") + ".dat");
        saveFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Vernam");
        saveFileDialog.ShowDialog();

        textBoxVernamSaveTo.Text = saveFileDialog.FileName;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonVernamKeyStoreSave_Click(object sender, EventArgs e)
    {
      try
      {
        saveFileDialog.FileName = textBoxVernamKeyStore.Text;
        if (string.IsNullOrWhiteSpace(saveFileDialog.FileName))
          saveFileDialog.FileName = Path.Combine(Environment.CurrentDirectory, "KeyStore", "Vernam" + DateTime.Now.ToString("yyyyMMddHHmmssttt") + ".key");
        saveFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "KeyStore");
        saveFileDialog.ShowDialog();

        textBoxVernamKeyStore.Text = saveFileDialog.FileName;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonVernamKeyStoreOpen_Click(object sender, EventArgs e)
    {
      try
      {
        openFileDialog.FileName = textBoxVernamKeyStore.Text;
        openFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "KeyStore");
        openFileDialog.ShowDialog();

        textBoxVernamKeyStore.Text = openFileDialog.FileName;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private async void buttonVernamEncrypt_Click(object sender, EventArgs e)
    {
      try
      {
        await EncryptVernam();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private async void buttonVernamDecrypt_Click(object sender, EventArgs e)
    {
      try
      {
        await DecryptVernam();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        SetVernamControlState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    #endregion
  }
}
