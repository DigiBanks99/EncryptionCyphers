using EncryptionCyphers.Cyphers;
using System;
using System.Drawing;
using System.IO;
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
    private const int CT_STEPS_CONTAINER_WIDTH = 181;

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
      SetControlState();
    }
    #endregion

    #region Private Methods
    private void SetupControls()
    {
      SetupTextBoxButtons(textBoxVernamOpenFile, buttonVernamOpenFile);
      SetupTextBoxButtons(textBoxVernamSaveTo, buttonVernamSaveTo);
      SetupTextBoxButtons(textBoxVernamKeyStore, buttonVernamKeyStoreOpen);
      SetupTextBoxButtons(textBoxVernamKeyStore, buttonVernamKeyStoreSave, -TEXTBOX_BUTTON_HEIGHT);
      SetupTextBoxButtons(textBoxCTAddKey, buttonCTAddKey);
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

    private void SetControlState()
    {
      SetVernamControlState();
      SetVernamButtonState();
      SetVigenereControlState();
      SetVigenereButtonState();
      SetColumnarTranspositionButtonState();
      SetColumnarTranspositionLayoutWidths();
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

    private void SetVernamButtonState()
    {
      var enabled = true;

      if (radioButtonFile.Checked)
      {
        if (string.IsNullOrEmpty(textBoxVernamKeyStore.Text) ||
            string.IsNullOrEmpty(textBoxVernamOpenFile.Text) ||
            string.IsNullOrEmpty(textBoxVernamSaveTo.Text))
          enabled = false;
      }
      else if (radioButtonText.Checked)
      {
        if (string.IsNullOrEmpty(textBoxVernamKeyStore.Text) ||
            string.IsNullOrEmpty(richTextBoxVernamInput.Text) ||
            string.IsNullOrEmpty(textBoxVernamSaveTo.Text))
          enabled = false;
      }

      buttonVernamEncrypt.Enabled = buttonVernamDecrypt.Enabled = enabled;
    }

    private void SetVigenereControlState()
    {
      richTextBoxVigenereCustomAlphabet.Text = VigenereCypher.FULLALPHABET;
      if (radioButtonVigenereNo.Checked)
      {
        labelVigenereCustomAlphabet.Visible = true;
        richTextBoxVigenereCustomAlphabet.Visible = true;
      }
      else if (radioButtonVigenereYes.Checked)
      {
        labelVigenereCustomAlphabet.Visible = false;
        richTextBoxVigenereCustomAlphabet.Visible = false;
      }
    }

    private void SetVigenereButtonState()
    {
      var enabled = true;

      if (string.IsNullOrEmpty(richTextBoxVigenereInput.Text) ||
          string.IsNullOrEmpty(richTextBoxVigenereKey.Text) ||
          string.IsNullOrEmpty(richTextBoxVigenereCustomAlphabet.Text))
        enabled = false;

      buttonVigenereEncrypt.Enabled = buttonVigenereDecrypt.Enabled = enabled;
    }

    private void SetColumnarTranspositionButtonState()
    {
      buttonCTAddKey.Enabled = !string.IsNullOrEmpty(textBoxCTAddKey.Text);
      buttonCTRemoveKey.Enabled = listBoxCTKeys.SelectedIndex > -1;

      var enabled = true;
      if (string.IsNullOrEmpty(richTextBoxCTInput.Text) || listBoxCTKeys.Items == null || listBoxCTKeys.Items.Count == 0)
        enabled = false;

      buttonCTEncrypt.Enabled = buttonCTDecrypt.Enabled = enabled;
    }

    private void SetColumnarTranspositionLayoutWidths()
    {
      if (radioButtonCTNo.Checked)
      {
        panelCTSteps.Visible = false;
        panelCTSteps.Size = new Size(0, panelCTSteps.Height);
        panelCTEncryption.Size = new Size(panelCTEncryption.Width + CT_STEPS_CONTAINER_WIDTH, panelCTEncryption.Height);
        panelCTText.Size = new Size(panelCTText.Width + CT_STEPS_CONTAINER_WIDTH, panelCTText.Height);
        richTextBoxCTInput.Size = new Size(richTextBoxCTInput.Width + 90, richTextBoxCTInput.Height);
        richTextBoxCTResult.Size = new Size(richTextBoxCTResult.Width + 90, richTextBoxCTResult.Height);
      }
      else if (radioButtonCTYes.Checked)
      {
        panelCTSteps.Visible = true;
        panelCTSteps.Size = new Size(CT_STEPS_CONTAINER_WIDTH, panelCTSteps.Height);
        panelCTEncryption.Size  = new Size(panelCTEncryption.Width - CT_STEPS_CONTAINER_WIDTH, panelCTEncryption.Height);
        panelCTText.Size = new Size(panelCTText.Width - CT_STEPS_CONTAINER_WIDTH, panelCTText.Height);
        richTextBoxCTInput.Size = new Size(richTextBoxCTInput.Width - 90, richTextBoxCTInput.Height);
        richTextBoxCTResult.Size = new Size(richTextBoxCTResult.Width - 90, richTextBoxCTResult.Height);
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
      var key = await vernam.GetKey(keyStore);
      await vernam.SaveKey(keyStore, key);
      await vernam.EncryptStringAsync(textBoxVernamSaveTo.Text, richTextBoxVernamInput.Text, key);

      MessageBox.Show("Encryption successful. Your encrypted File and Key can be found in the locations specified.", "Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async Task EncryptVernamFile(VernamManager vernam, string keyStore)
    {
      vernam.SetPlainTextFromFile(textBoxVernamSaveTo.Text);
      var key = await vernam.GetKey(keyStore);
      await vernam.SaveKey(keyStore, key);
      await vernam.EncryptFileAsync(textBoxVernamOpenFile.Text, textBoxVernamSaveTo.Text, key);

      MessageBox.Show("Encryption successful. Your encrypted File and Key can be found in the locations specified.", "Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    #region Vigenére
    public void EncryptVigenere()
    {
      richTextBoxVigenereResult.Text = string.Empty;
      var vigenere = new VigenereCypher();
      vigenere.Alphabet = richTextBoxVigenereCustomAlphabet.Text;
      richTextBoxVigenereResult.Text = vigenere.Encrypt(richTextBoxVigenereInput.Text, richTextBoxVigenereKey.Text, vigenere.Alphabet.Length);

      MessageBox.Show("Encryption successful. The text area for decryption has been filled with your result.", "Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void DecryptVigenere()
    {
      richTextBoxVigenereResult.Text = string.Empty;
      var vigenere = new VigenereCypher();
      vigenere.Alphabet = richTextBoxVigenereCustomAlphabet.Text;
      richTextBoxVigenereResult.Text = vigenere.Decrypt(richTextBoxVigenereResult.Text, richTextBoxVigenereKey.Text, vigenere.Alphabet.Length);

      MessageBox.Show("Decryption successful. The text area for encryption has been filled with your result.", "Decrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    #endregion Vigenére

    #region Columna Transposition

    private void EncryptColumnarTransposition()
    {
      if (listBoxCTSteps.Items != null && listBoxCTSteps.Items.Count > 0)
        listBoxCTSteps.Items.Clear();

      var encryptedText = richTextBoxCTInput.Text;
      var ct = new ColumnarTranspositionCypher();

      foreach (string key in listBoxCTKeys.Items)
      {
        encryptedText = ct.Encrypt(key, encryptedText);
        listBoxCTSteps.Items.Add(encryptedText);
      }

      richTextBoxCTResult.Text = encryptedText;

      MessageBox.Show("Encryption successful. The text area for decryption has been filled with your result.", "Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void DecryptColumnarTransposition()
    {
      if (listBoxCTSteps.Items != null && listBoxCTSteps.Items.Count > 0)
        listBoxCTSteps.Items.Clear();

      var decryptedText = richTextBoxCTInput.Text;
      var ct = new ColumnarTranspositionCypher();

      foreach (string key in listBoxCTKeys.Items)
      {
        decryptedText = ct.Decrypt(key, decryptedText);
        listBoxCTSteps.Items.Add(decryptedText);
      }

      richTextBoxCTResult.Text = decryptedText;
      MessageBox.Show("Decryption successful. The text area for encryption has been filled with your result.", "Decrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    #endregion Columna Transposition

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
        SetVernamButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonVigenereEncrypt_Click(object sender, EventArgs e)
    {
      try
      {
        EncryptVigenere();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonVigenereDecrypt_Click(object sender, EventArgs e)
    {
      try
      {
        DecryptVigenere();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void radioButtonVigenereYes_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        SetVigenereControlState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void vigenereEditChanged_TextChanged(object sender, EventArgs e)
    {
      try
      {
        SetVigenereButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonCTAddKey_Click(object sender, EventArgs e)
    {
      try
      {
        listBoxCTKeys.Items.Add(textBoxCTAddKey.Text);
        textBoxCTAddKey.Text = string.Empty;
        SetColumnarTranspositionButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void columnarTranspositionEditValueChanged(object sender, EventArgs e)
    {
      try
      {
        SetColumnarTranspositionButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonCTClearKeys_Click(object sender, EventArgs e)
    {
      try
      {
        listBoxCTKeys.Items.Clear();
        textBoxCTAddKey.Text = string.Empty;
        SetColumnarTranspositionButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonCTRemoveKey_Click(object sender, EventArgs e)
    {
      try
      {
        listBoxCTKeys.Items.RemoveAt(listBoxCTKeys.SelectedIndex);
        SetColumnarTranspositionButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void radioButtonCT_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        SetColumnarTranspositionLayoutWidths();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonCTEncrypt_Click(object sender, EventArgs e)
    {
      try
      {
        EncryptColumnarTransposition();
        SetColumnarTranspositionButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonCTDecrypt_Click(object sender, EventArgs e)
    {
      try
      {
        DecryptColumnarTransposition();
        SetColumnarTranspositionButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void listBoxCTSteps_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        richTextBoxCTResult.Text = listBoxCTSteps.SelectedItem as string;
        SetColumnarTranspositionButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void listBoxCTKeys_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        textBoxCTAddKey.Text = listBoxCTKeys.SelectedItem as string;
        SetColumnarTranspositionButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void vernameEditValueChanged(object sender, EventArgs e)
    {
      try
      {
        SetVernamButtonState();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    #endregion
  }
}
