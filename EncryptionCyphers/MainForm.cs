using EncryptionCyphers.Cyphers;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionCyphers
{
  public partial class MainForm : Form
  {
    private DirectoryInfo _lastDir = null;

    public MainForm()
    {
      InitializeComponent();
      LoadControl();
    }

    #region Public Methods
    public void LoadControl()
    {
      SetInitialDirectory();
      SetupControls();
    }
    #endregion

    #region Private Methods
    private void SetupControls()
    {
      SetupTextBoxButtons(textBoxVernamOpenFile, buttonVernamOpenFile);
      SetupTextBoxButtons(textBoxVernamSaveTo, buttonVernamSaveTo);
      SetupTextBoxButtons(textBoxVernamKeyStore, buttonVernamKeyStore);
    }

    private void SetupTextBoxButtons(TextBox textBox, Button button)
    {
      button.Size = new Size(25, textBox.ClientSize.Height + 2);
      button.Location = new Point(textBox.ClientSize.Width - button.Width, -1);
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

    private async Task EncryptVernam()
    {
      var vernam = new VernamManager();
      var keyStore = textBoxVernamKeyStore.Text;
      if (string.IsNullOrWhiteSpace(keyStore))
        keyStore = Path.Combine(Environment.CurrentDirectory, "KeyStore", "Vernam" + DateTime.Now.ToString("YYYYMMDDHHmmssttt") + ".key");

      if (radioButtonFromText.Checked)
        await EncryptVernamText(vernam, keyStore);
      else if (radioButtonFromFile.Checked)
        await EncryptVernamFile(vernam, keyStore);
    }

    private async Task EncryptVernamText(VernamManager vernam, string keyStore)
    {
      vernam.SetPlainText(richTextBoxVernamInput.Text);
      var keyBytes = await vernam.GetKey();
      var keyDisplay = Encoding.Default.GetString(keyBytes);
      await vernam.SaveKey(keyStore, keyBytes);
      MessageBox.Show("Your key is displayed below. Please store it in a safe place and destroy it as soon as decryption is done.\n\n" + keyDisplay);

      richTextBoxVernamResult.Text = await vernam.EncryptString(richTextBoxVernamInput.Text, keyBytes);
    }

    private async Task EncryptVernamFile(VernamManager vernam, string keyStore)
    {

    }
    #endregion

    #region Events
    private void MainForm_Load(object sender, System.EventArgs e)
    {
      try
      {
        LoadControl();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.HResult.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        var fileInfo = new FileInfo(openFileDialog.FileName);
        SetInitialDirectory(fileInfo.DirectoryName);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.HResult.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonVernamKeyStore_Click(object sender, EventArgs e)
    {
      try
      {
        openFileDialog.FileName = textBoxVernamKeyStore.Text;
        openFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "KeyStore");
        openFileDialog.ShowDialog();

        textBoxVernamKeyStore.Text = openFileDialog.FileName;
        var fileInfo = new FileInfo(openFileDialog.FileName);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.HResult.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        MessageBox.Show(ex.Message, ex.HResult.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    #endregion
  }
}
