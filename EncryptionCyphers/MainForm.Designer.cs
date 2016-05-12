namespace EncryptionCyphers
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.tabPageVernam = new System.Windows.Forms.TabPage();
      this.lcVernam = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.labelVernamTextOrFile = new System.Windows.Forms.Label();
      this.radioButtonText = new System.Windows.Forms.RadioButton();
      this.radioButtonFile = new System.Windows.Forms.RadioButton();
      this.buttonVernamKeyStoreOpen = new System.Windows.Forms.Button();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.buttonVernamOpenFile = new System.Windows.Forms.Button();
      this.buttonVernamKeyStoreSave = new System.Windows.Forms.Button();
      this.buttonVernamSaveTo = new System.Windows.Forms.Button();
      this.textBoxVernamOpenFile = new System.Windows.Forms.TextBox();
      this.textBoxVernamSaveTo = new System.Windows.Forms.TextBox();
      this.textBoxVernamKeyStore = new System.Windows.Forms.TextBox();
      this.labelVernamKeyStore = new System.Windows.Forms.Label();
      this.labelVernamOpenFile = new System.Windows.Forms.Label();
      this.labelVernamSaveTo = new System.Windows.Forms.Label();
      this.labelVernamInput = new System.Windows.Forms.Label();
      this.richTextBoxVernamInput = new System.Windows.Forms.RichTextBox();
      this.panelBernamButtons = new System.Windows.Forms.Panel();
      this.buttonVernamClose = new System.Windows.Forms.Button();
      this.buttonVernamEncrypt = new System.Windows.Forms.Button();
      this.buttonVernamDecrypt = new System.Windows.Forms.Button();
      this.tabPageVigenere = new System.Windows.Forms.TabPage();
      this.lcVigenere = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.richTextBoxVigenereCustomAlphabet = new System.Windows.Forms.RichTextBox();
      this.labelVigenereCustomAlphabet = new System.Windows.Forms.Label();
      this.radioButtonVigenereNo = new System.Windows.Forms.RadioButton();
      this.radioButtonVigenereYes = new System.Windows.Forms.RadioButton();
      this.labelAlphabet = new System.Windows.Forms.Label();
      this.labelVigenereKey = new System.Windows.Forms.Label();
      this.richTextBoxVigenereResult = new System.Windows.Forms.RichTextBox();
      this.labelVigenereResult = new System.Windows.Forms.Label();
      this.richTextBoxVigenereKey = new System.Windows.Forms.RichTextBox();
      this.richTextBoxVigenereInput = new System.Windows.Forms.RichTextBox();
      this.labelVigenerePlainText = new System.Windows.Forms.Label();
      this.panelVigenereButtons = new System.Windows.Forms.Panel();
      this.buttonVigenereClose = new System.Windows.Forms.Button();
      this.buttonVigenereEncrypt = new System.Windows.Forms.Button();
      this.buttonVigenereDecrypt = new System.Windows.Forms.Button();
      this.tabPageColumnarTransposition = new System.Windows.Forms.TabPage();
      this.lcCT = new System.Windows.Forms.Panel();
      this.panelCTContent = new System.Windows.Forms.Panel();
      this.panelCTEncryption = new System.Windows.Forms.Panel();
      this.panelCTText = new System.Windows.Forms.Panel();
      this.labelResult = new System.Windows.Forms.Label();
      this.labelCTInput = new System.Windows.Forms.Label();
      this.richTextBoxCTResult = new System.Windows.Forms.RichTextBox();
      this.richTextBoxCTInput = new System.Windows.Forms.RichTextBox();
      this.groupBoxCTKeys = new System.Windows.Forms.GroupBox();
      this.listBoxCTKeys = new System.Windows.Forms.ListBox();
      this.buttonCTAddKey = new System.Windows.Forms.Button();
      this.textBoxCTAddKey = new System.Windows.Forms.TextBox();
      this.panelCTSteps = new System.Windows.Forms.Panel();
      this.groupBoxSteps = new System.Windows.Forms.GroupBox();
      this.listBoxCTSteps = new System.Windows.Forms.ListBox();
      this.panelCTOptions = new System.Windows.Forms.Panel();
      this.labelCTSeeSteps = new System.Windows.Forms.Label();
      this.radioButtonCTNo = new System.Windows.Forms.RadioButton();
      this.radioButtonCTYes = new System.Windows.Forms.RadioButton();
      this.panelCTButtons = new System.Windows.Forms.Panel();
      this.buttonCTRemoveKey = new System.Windows.Forms.Button();
      this.buttonCTClearKeys = new System.Windows.Forms.Button();
      this.buttonCTClose = new System.Windows.Forms.Button();
      this.buttonCTEncrypt = new System.Windows.Forms.Button();
      this.buttonCTDecrypt = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.tabControlMain.SuspendLayout();
      this.tabPageVernam.SuspendLayout();
      this.lcVernam.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panelBernamButtons.SuspendLayout();
      this.tabPageVigenere.SuspendLayout();
      this.lcVigenere.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panelVigenereButtons.SuspendLayout();
      this.tabPageColumnarTransposition.SuspendLayout();
      this.lcCT.SuspendLayout();
      this.panelCTContent.SuspendLayout();
      this.panelCTEncryption.SuspendLayout();
      this.panelCTText.SuspendLayout();
      this.groupBoxCTKeys.SuspendLayout();
      this.panelCTSteps.SuspendLayout();
      this.groupBoxSteps.SuspendLayout();
      this.panelCTOptions.SuspendLayout();
      this.panelCTButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControlMain
      // 
      this.tabControlMain.Controls.Add(this.tabPageVernam);
      this.tabControlMain.Controls.Add(this.tabPageVigenere);
      this.tabControlMain.Controls.Add(this.tabPageColumnarTransposition);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.ImageList = this.imageList;
      this.tabControlMain.Location = new System.Drawing.Point(0, 0);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(892, 507);
      this.tabControlMain.TabIndex = 0;
      // 
      // tabPageVernam
      // 
      this.tabPageVernam.Controls.Add(this.lcVernam);
      this.tabPageVernam.Location = new System.Drawing.Point(4, 23);
      this.tabPageVernam.Margin = new System.Windows.Forms.Padding(0);
      this.tabPageVernam.Name = "tabPageVernam";
      this.tabPageVernam.Size = new System.Drawing.Size(884, 480);
      this.tabPageVernam.TabIndex = 0;
      this.tabPageVernam.Text = "Vernam";
      this.tabPageVernam.UseVisualStyleBackColor = true;
      // 
      // lcVernam
      // 
      this.lcVernam.Controls.Add(this.panel1);
      this.lcVernam.Controls.Add(this.buttonVernamKeyStoreOpen);
      this.lcVernam.Controls.Add(this.buttonVernamOpenFile);
      this.lcVernam.Controls.Add(this.buttonVernamKeyStoreSave);
      this.lcVernam.Controls.Add(this.buttonVernamSaveTo);
      this.lcVernam.Controls.Add(this.textBoxVernamOpenFile);
      this.lcVernam.Controls.Add(this.textBoxVernamSaveTo);
      this.lcVernam.Controls.Add(this.textBoxVernamKeyStore);
      this.lcVernam.Controls.Add(this.labelVernamKeyStore);
      this.lcVernam.Controls.Add(this.labelVernamOpenFile);
      this.lcVernam.Controls.Add(this.labelVernamSaveTo);
      this.lcVernam.Controls.Add(this.labelVernamInput);
      this.lcVernam.Controls.Add(this.richTextBoxVernamInput);
      this.lcVernam.Controls.Add(this.panelBernamButtons);
      this.lcVernam.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lcVernam.Location = new System.Drawing.Point(0, 0);
      this.lcVernam.Margin = new System.Windows.Forms.Padding(0);
      this.lcVernam.Name = "lcVernam";
      this.lcVernam.Size = new System.Drawing.Size(884, 480);
      this.lcVernam.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.labelVernamTextOrFile);
      this.panel1.Controls.Add(this.radioButtonText);
      this.panel1.Controls.Add(this.radioButtonFile);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(884, 70);
      this.panel1.TabIndex = 4;
      // 
      // labelVernamTextOrFile
      // 
      this.labelVernamTextOrFile.AutoSize = true;
      this.labelVernamTextOrFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelVernamTextOrFile.Location = new System.Drawing.Point(8, 27);
      this.labelVernamTextOrFile.Name = "labelVernamTextOrFile";
      this.labelVernamTextOrFile.Size = new System.Drawing.Size(176, 16);
      this.labelVernamTextOrFile.TabIndex = 3;
      this.labelVernamTextOrFile.Text = "What do you want to do?";
      // 
      // radioButtonText
      // 
      this.radioButtonText.AutoSize = true;
      this.radioButtonText.Location = new System.Drawing.Point(462, 27);
      this.radioButtonText.Name = "radioButtonText";
      this.radioButtonText.Size = new System.Drawing.Size(146, 17);
      this.radioButtonText.TabIndex = 2;
      this.radioButtonText.TabStop = true;
      this.radioButtonText.Text = "Encrypt/Decrypt from text";
      this.radioButtonText.UseVisualStyleBackColor = true;
      this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
      // 
      // radioButtonFile
      // 
      this.radioButtonFile.AutoSize = true;
      this.radioButtonFile.Checked = true;
      this.radioButtonFile.Location = new System.Drawing.Point(276, 27);
      this.radioButtonFile.Name = "radioButtonFile";
      this.radioButtonFile.Size = new System.Drawing.Size(142, 17);
      this.radioButtonFile.TabIndex = 1;
      this.radioButtonFile.TabStop = true;
      this.radioButtonFile.Text = "Encrypt/Decrypt from file";
      this.radioButtonFile.UseVisualStyleBackColor = true;
      this.radioButtonFile.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
      // 
      // buttonVernamKeyStoreOpen
      // 
      this.buttonVernamKeyStoreOpen.ImageIndex = 31;
      this.buttonVernamKeyStoreOpen.ImageList = this.imageList;
      this.buttonVernamKeyStoreOpen.Location = new System.Drawing.Point(784, 161);
      this.buttonVernamKeyStoreOpen.Name = "buttonVernamKeyStoreOpen";
      this.buttonVernamKeyStoreOpen.Size = new System.Drawing.Size(75, 20);
      this.buttonVernamKeyStoreOpen.TabIndex = 3;
      this.buttonVernamKeyStoreOpen.UseVisualStyleBackColor = true;
      this.buttonVernamKeyStoreOpen.Click += new System.EventHandler(this.buttonVernamKeyStoreOpen_Click);
      // 
      // imageList
      // 
      this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList.Images.SetKeyName(0, "alarm.png");
      this.imageList.Images.SetKeyName(1, "closed-lock.png");
      this.imageList.Images.SetKeyName(2, "eye.png");
      this.imageList.Images.SetKeyName(3, "firewall.png");
      this.imageList.Images.SetKeyName(4, "key.png");
      this.imageList.Images.SetKeyName(5, "key-1.png");
      this.imageList.Images.SetKeyName(6, "keyhole.png");
      this.imageList.Images.SetKeyName(7, "keyhole-1.png");
      this.imageList.Images.SetKeyName(8, "laptop-spy.png");
      this.imageList.Images.SetKeyName(9, "locked-cloud.png");
      this.imageList.Images.SetKeyName(10, "locked-file.png");
      this.imageList.Images.SetKeyName(11, "magnifying-glass.png");
      this.imageList.Images.SetKeyName(12, "monitor-spy.png");
      this.imageList.Images.SetKeyName(13, "open-lock.png");
      this.imageList.Images.SetKeyName(14, "open-lock-1.png");
      this.imageList.Images.SetKeyName(15, "padlock.png");
      this.imageList.Images.SetKeyName(16, "password.png");
      this.imageList.Images.SetKeyName(17, "pin-code.png");
      this.imageList.Images.SetKeyName(18, "protected-cloud.png");
      this.imageList.Images.SetKeyName(19, "safebox.png");
      this.imageList.Images.SetKeyName(20, "security-camera.png");
      this.imageList.Images.SetKeyName(21, "shield.png");
      this.imageList.Images.SetKeyName(22, "shield-1.png");
      this.imageList.Images.SetKeyName(23, "shield-2.png");
      this.imageList.Images.SetKeyName(24, "shield-3.png");
      this.imageList.Images.SetKeyName(25, "shield-with-thumb-up.png");
      this.imageList.Images.SetKeyName(26, "spy.png");
      this.imageList.Images.SetKeyName(27, "virus.png");
      this.imageList.Images.SetKeyName(28, "wall.png");
      this.imageList.Images.SetKeyName(29, "webcam.png");
      this.imageList.Images.SetKeyName(30, "cancel.png");
      this.imageList.Images.SetKeyName(31, "folder.png");
      this.imageList.Images.SetKeyName(32, "floppy-disk-save-button.png");
      this.imageList.Images.SetKeyName(33, "add-tool.png");
      this.imageList.Images.SetKeyName(34, "update-arrows.png");
      this.imageList.Images.SetKeyName(35, "subtracting-button.png");
      // 
      // buttonVernamOpenFile
      // 
      this.buttonVernamOpenFile.ImageIndex = 31;
      this.buttonVernamOpenFile.ImageList = this.imageList;
      this.buttonVernamOpenFile.Location = new System.Drawing.Point(784, 87);
      this.buttonVernamOpenFile.Name = "buttonVernamOpenFile";
      this.buttonVernamOpenFile.Size = new System.Drawing.Size(75, 20);
      this.buttonVernamOpenFile.TabIndex = 1;
      this.buttonVernamOpenFile.UseVisualStyleBackColor = true;
      this.buttonVernamOpenFile.Click += new System.EventHandler(this.buttonVernamOpenFile_Click);
      // 
      // buttonVernamKeyStoreSave
      // 
      this.buttonVernamKeyStoreSave.ImageIndex = 32;
      this.buttonVernamKeyStoreSave.ImageList = this.imageList;
      this.buttonVernamKeyStoreSave.Location = new System.Drawing.Point(703, 161);
      this.buttonVernamKeyStoreSave.Name = "buttonVernamKeyStoreSave";
      this.buttonVernamKeyStoreSave.Size = new System.Drawing.Size(75, 20);
      this.buttonVernamKeyStoreSave.TabIndex = 3;
      this.buttonVernamKeyStoreSave.UseVisualStyleBackColor = true;
      this.buttonVernamKeyStoreSave.Click += new System.EventHandler(this.buttonVernamKeyStoreSave_Click);
      // 
      // buttonVernamSaveTo
      // 
      this.buttonVernamSaveTo.ImageIndex = 32;
      this.buttonVernamSaveTo.ImageList = this.imageList;
      this.buttonVernamSaveTo.Location = new System.Drawing.Point(784, 123);
      this.buttonVernamSaveTo.Name = "buttonVernamSaveTo";
      this.buttonVernamSaveTo.Size = new System.Drawing.Size(75, 20);
      this.buttonVernamSaveTo.TabIndex = 1;
      this.buttonVernamSaveTo.UseVisualStyleBackColor = true;
      this.buttonVernamSaveTo.Click += new System.EventHandler(this.buttonVernamSaveTo_Click);
      // 
      // textBoxVernamOpenFile
      // 
      this.textBoxVernamOpenFile.Location = new System.Drawing.Point(112, 84);
      this.textBoxVernamOpenFile.Multiline = true;
      this.textBoxVernamOpenFile.Name = "textBoxVernamOpenFile";
      this.textBoxVernamOpenFile.Size = new System.Drawing.Size(761, 30);
      this.textBoxVernamOpenFile.TabIndex = 0;
      this.textBoxVernamOpenFile.WordWrap = false;
      this.textBoxVernamOpenFile.TextChanged += new System.EventHandler(this.vernameEditValueChanged);
      // 
      // textBoxVernamSaveTo
      // 
      this.textBoxVernamSaveTo.Location = new System.Drawing.Point(112, 120);
      this.textBoxVernamSaveTo.Multiline = true;
      this.textBoxVernamSaveTo.Name = "textBoxVernamSaveTo";
      this.textBoxVernamSaveTo.Size = new System.Drawing.Size(761, 30);
      this.textBoxVernamSaveTo.TabIndex = 0;
      this.textBoxVernamSaveTo.WordWrap = false;
      this.textBoxVernamSaveTo.TextChanged += new System.EventHandler(this.vernameEditValueChanged);
      // 
      // textBoxVernamKeyStore
      // 
      this.textBoxVernamKeyStore.Location = new System.Drawing.Point(112, 156);
      this.textBoxVernamKeyStore.Multiline = true;
      this.textBoxVernamKeyStore.Name = "textBoxVernamKeyStore";
      this.textBoxVernamKeyStore.Size = new System.Drawing.Size(761, 30);
      this.textBoxVernamKeyStore.TabIndex = 2;
      this.textBoxVernamKeyStore.WordWrap = false;
      this.textBoxVernamKeyStore.TextChanged += new System.EventHandler(this.vernameEditValueChanged);
      // 
      // labelVernamKeyStore
      // 
      this.labelVernamKeyStore.AutoSize = true;
      this.labelVernamKeyStore.Location = new System.Drawing.Point(8, 165);
      this.labelVernamKeyStore.Name = "labelVernamKeyStore";
      this.labelVernamKeyStore.Size = new System.Drawing.Size(101, 13);
      this.labelVernamKeyStore.TabIndex = 2;
      this.labelVernamKeyStore.Text = "Set the key location";
      // 
      // labelVernamOpenFile
      // 
      this.labelVernamOpenFile.AutoSize = true;
      this.labelVernamOpenFile.Location = new System.Drawing.Point(8, 91);
      this.labelVernamOpenFile.Name = "labelVernamOpenFile";
      this.labelVernamOpenFile.Size = new System.Drawing.Size(101, 13);
      this.labelVernamOpenFile.TabIndex = 2;
      this.labelVernamOpenFile.Text = "Select or enter a file";
      // 
      // labelVernamSaveTo
      // 
      this.labelVernamSaveTo.AutoSize = true;
      this.labelVernamSaveTo.Location = new System.Drawing.Point(8, 127);
      this.labelVernamSaveTo.Name = "labelVernamSaveTo";
      this.labelVernamSaveTo.Size = new System.Drawing.Size(89, 13);
      this.labelVernamSaveTo.TabIndex = 2;
      this.labelVernamSaveTo.Text = "Set save location";
      // 
      // labelVernamInput
      // 
      this.labelVernamInput.AutoSize = true;
      this.labelVernamInput.Location = new System.Drawing.Point(8, 189);
      this.labelVernamInput.Name = "labelVernamInput";
      this.labelVernamInput.Size = new System.Drawing.Size(142, 13);
      this.labelVernamInput.TabIndex = 0;
      this.labelVernamInput.Text = "Enter text to encrypt/decrypt";
      // 
      // richTextBoxVernamInput
      // 
      this.richTextBoxVernamInput.Location = new System.Drawing.Point(11, 205);
      this.richTextBoxVernamInput.Name = "richTextBoxVernamInput";
      this.richTextBoxVernamInput.Size = new System.Drawing.Size(862, 222);
      this.richTextBoxVernamInput.TabIndex = 1;
      this.richTextBoxVernamInput.Text = "";
      this.richTextBoxVernamInput.TextChanged += new System.EventHandler(this.vernameEditValueChanged);
      // 
      // panelBernamButtons
      // 
      this.panelBernamButtons.Controls.Add(this.buttonVernamClose);
      this.panelBernamButtons.Controls.Add(this.buttonVernamEncrypt);
      this.panelBernamButtons.Controls.Add(this.buttonVernamDecrypt);
      this.panelBernamButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelBernamButtons.Location = new System.Drawing.Point(0, 433);
      this.panelBernamButtons.Margin = new System.Windows.Forms.Padding(0);
      this.panelBernamButtons.Name = "panelBernamButtons";
      this.panelBernamButtons.Size = new System.Drawing.Size(884, 47);
      this.panelBernamButtons.TabIndex = 0;
      // 
      // buttonVernamClose
      // 
      this.buttonVernamClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonVernamClose.ImageIndex = 29;
      this.buttonVernamClose.ImageList = this.imageList;
      this.buttonVernamClose.Location = new System.Drawing.Point(11, 3);
      this.buttonVernamClose.Name = "buttonVernamClose";
      this.buttonVernamClose.Size = new System.Drawing.Size(85, 39);
      this.buttonVernamClose.TabIndex = 1;
      this.buttonVernamClose.Text = "Close";
      this.buttonVernamClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonVernamClose.UseVisualStyleBackColor = true;
      this.buttonVernamClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // buttonVernamEncrypt
      // 
      this.buttonVernamEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonVernamEncrypt.ImageIndex = 15;
      this.buttonVernamEncrypt.ImageList = this.imageList;
      this.buttonVernamEncrypt.Location = new System.Drawing.Point(703, 3);
      this.buttonVernamEncrypt.Name = "buttonVernamEncrypt";
      this.buttonVernamEncrypt.Size = new System.Drawing.Size(85, 39);
      this.buttonVernamEncrypt.TabIndex = 1;
      this.buttonVernamEncrypt.Text = "Encrypt";
      this.buttonVernamEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonVernamEncrypt.UseVisualStyleBackColor = true;
      this.buttonVernamEncrypt.Click += new System.EventHandler(this.buttonVernamEncrypt_Click);
      // 
      // buttonVernamDecrypt
      // 
      this.buttonVernamDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonVernamDecrypt.ImageIndex = 14;
      this.buttonVernamDecrypt.ImageList = this.imageList;
      this.buttonVernamDecrypt.Location = new System.Drawing.Point(794, 3);
      this.buttonVernamDecrypt.Name = "buttonVernamDecrypt";
      this.buttonVernamDecrypt.Size = new System.Drawing.Size(79, 39);
      this.buttonVernamDecrypt.TabIndex = 0;
      this.buttonVernamDecrypt.Text = "Decrypt";
      this.buttonVernamDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonVernamDecrypt.UseVisualStyleBackColor = true;
      this.buttonVernamDecrypt.Click += new System.EventHandler(this.buttonVernamDecrypt_Click);
      // 
      // tabPageVigenere
      // 
      this.tabPageVigenere.Controls.Add(this.lcVigenere);
      this.tabPageVigenere.Location = new System.Drawing.Point(4, 23);
      this.tabPageVigenere.Margin = new System.Windows.Forms.Padding(0);
      this.tabPageVigenere.Name = "tabPageVigenere";
      this.tabPageVigenere.Size = new System.Drawing.Size(884, 480);
      this.tabPageVigenere.TabIndex = 1;
      this.tabPageVigenere.Text = "Vigenére";
      this.tabPageVigenere.UseVisualStyleBackColor = true;
      // 
      // lcVigenere
      // 
      this.lcVigenere.Controls.Add(this.panel2);
      this.lcVigenere.Controls.Add(this.labelVigenereKey);
      this.lcVigenere.Controls.Add(this.richTextBoxVigenereResult);
      this.lcVigenere.Controls.Add(this.labelVigenereResult);
      this.lcVigenere.Controls.Add(this.richTextBoxVigenereKey);
      this.lcVigenere.Controls.Add(this.richTextBoxVigenereInput);
      this.lcVigenere.Controls.Add(this.labelVigenerePlainText);
      this.lcVigenere.Controls.Add(this.panelVigenereButtons);
      this.lcVigenere.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lcVigenere.Location = new System.Drawing.Point(0, 0);
      this.lcVigenere.Margin = new System.Windows.Forms.Padding(0);
      this.lcVigenere.Name = "lcVigenere";
      this.lcVigenere.Size = new System.Drawing.Size(884, 480);
      this.lcVigenere.TabIndex = 1;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.richTextBoxVigenereCustomAlphabet);
      this.panel2.Controls.Add(this.labelVigenereCustomAlphabet);
      this.panel2.Controls.Add(this.radioButtonVigenereNo);
      this.panel2.Controls.Add(this.radioButtonVigenereYes);
      this.panel2.Controls.Add(this.labelAlphabet);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(884, 70);
      this.panel2.TabIndex = 4;
      // 
      // richTextBoxVigenereCustomAlphabet
      // 
      this.richTextBoxVigenereCustomAlphabet.Location = new System.Drawing.Point(655, 13);
      this.richTextBoxVigenereCustomAlphabet.Name = "richTextBoxVigenereCustomAlphabet";
      this.richTextBoxVigenereCustomAlphabet.Size = new System.Drawing.Size(218, 45);
      this.richTextBoxVigenereCustomAlphabet.TabIndex = 9;
      this.richTextBoxVigenereCustomAlphabet.Text = "";
      this.richTextBoxVigenereCustomAlphabet.Visible = false;
      this.richTextBoxVigenereCustomAlphabet.TextChanged += new System.EventHandler(this.vigenereEditChanged_TextChanged);
      // 
      // labelVigenereCustomAlphabet
      // 
      this.labelVigenereCustomAlphabet.AutoSize = true;
      this.labelVigenereCustomAlphabet.Location = new System.Drawing.Point(473, 30);
      this.labelVigenereCustomAlphabet.Name = "labelVigenereCustomAlphabet";
      this.labelVigenereCustomAlphabet.Size = new System.Drawing.Size(176, 13);
      this.labelVigenereCustomAlphabet.TabIndex = 8;
      this.labelVigenereCustomAlphabet.Text = "Enter your alphabet characters here";
      this.labelVigenereCustomAlphabet.Visible = false;
      // 
      // radioButtonVigenereNo
      // 
      this.radioButtonVigenereNo.AutoSize = true;
      this.radioButtonVigenereNo.Location = new System.Drawing.Point(417, 28);
      this.radioButtonVigenereNo.Name = "radioButtonVigenereNo";
      this.radioButtonVigenereNo.Size = new System.Drawing.Size(39, 17);
      this.radioButtonVigenereNo.TabIndex = 6;
      this.radioButtonVigenereNo.TabStop = true;
      this.radioButtonVigenereNo.Text = "No";
      this.radioButtonVigenereNo.UseVisualStyleBackColor = true;
      // 
      // radioButtonVigenereYes
      // 
      this.radioButtonVigenereYes.AutoSize = true;
      this.radioButtonVigenereYes.Checked = true;
      this.radioButtonVigenereYes.Location = new System.Drawing.Point(353, 28);
      this.radioButtonVigenereYes.Name = "radioButtonVigenereYes";
      this.radioButtonVigenereYes.Size = new System.Drawing.Size(43, 17);
      this.radioButtonVigenereYes.TabIndex = 5;
      this.radioButtonVigenereYes.TabStop = true;
      this.radioButtonVigenereYes.Text = "Yes";
      this.radioButtonVigenereYes.UseVisualStyleBackColor = true;
      this.radioButtonVigenereYes.CheckedChanged += new System.EventHandler(this.radioButtonVigenereYes_CheckedChanged);
      // 
      // labelAlphabet
      // 
      this.labelAlphabet.AutoSize = true;
      this.labelAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelAlphabet.Location = new System.Drawing.Point(8, 28);
      this.labelAlphabet.Name = "labelAlphabet";
      this.labelAlphabet.Size = new System.Drawing.Size(301, 16);
      this.labelAlphabet.TabIndex = 4;
      this.labelAlphabet.Text = "Do you want to use the standard alphabet?";
      // 
      // labelVigenereKey
      // 
      this.labelVigenereKey.AutoSize = true;
      this.labelVigenereKey.Location = new System.Drawing.Point(8, 73);
      this.labelVigenereKey.Name = "labelVigenereKey";
      this.labelVigenereKey.Size = new System.Drawing.Size(99, 13);
      this.labelVigenereKey.TabIndex = 3;
      this.labelVigenereKey.Text = "Enter your key here";
      // 
      // richTextBoxVigenereResult
      // 
      this.richTextBoxVigenereResult.Location = new System.Drawing.Point(11, 326);
      this.richTextBoxVigenereResult.Name = "richTextBoxVigenereResult";
      this.richTextBoxVigenereResult.Size = new System.Drawing.Size(862, 95);
      this.richTextBoxVigenereResult.TabIndex = 2;
      this.richTextBoxVigenereResult.Text = "";
      // 
      // labelVigenereResult
      // 
      this.labelVigenereResult.AutoSize = true;
      this.labelVigenereResult.Location = new System.Drawing.Point(8, 310);
      this.labelVigenereResult.Name = "labelVigenereResult";
      this.labelVigenereResult.Size = new System.Drawing.Size(134, 13);
      this.labelVigenereResult.TabIndex = 1;
      this.labelVigenereResult.Text = "Your result will appear here";
      // 
      // richTextBoxVigenereKey
      // 
      this.richTextBoxVigenereKey.Location = new System.Drawing.Point(11, 89);
      this.richTextBoxVigenereKey.Name = "richTextBoxVigenereKey";
      this.richTextBoxVigenereKey.Size = new System.Drawing.Size(862, 69);
      this.richTextBoxVigenereKey.TabIndex = 2;
      this.richTextBoxVigenereKey.Text = "";
      this.richTextBoxVigenereKey.TextChanged += new System.EventHandler(this.vigenereEditChanged_TextChanged);
      // 
      // richTextBoxVigenereInput
      // 
      this.richTextBoxVigenereInput.Location = new System.Drawing.Point(11, 191);
      this.richTextBoxVigenereInput.Name = "richTextBoxVigenereInput";
      this.richTextBoxVigenereInput.Size = new System.Drawing.Size(862, 95);
      this.richTextBoxVigenereInput.TabIndex = 2;
      this.richTextBoxVigenereInput.Text = "";
      this.richTextBoxVigenereInput.TextChanged += new System.EventHandler(this.vigenereEditChanged_TextChanged);
      // 
      // labelVigenerePlainText
      // 
      this.labelVigenerePlainText.AutoSize = true;
      this.labelVigenerePlainText.Location = new System.Drawing.Point(8, 175);
      this.labelVigenerePlainText.Name = "labelVigenerePlainText";
      this.labelVigenerePlainText.Size = new System.Drawing.Size(99, 13);
      this.labelVigenerePlainText.TabIndex = 1;
      this.labelVigenerePlainText.Text = "Enter your text here";
      // 
      // panelVigenereButtons
      // 
      this.panelVigenereButtons.Controls.Add(this.buttonVigenereClose);
      this.panelVigenereButtons.Controls.Add(this.buttonVigenereEncrypt);
      this.panelVigenereButtons.Controls.Add(this.buttonVigenereDecrypt);
      this.panelVigenereButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelVigenereButtons.Location = new System.Drawing.Point(0, 433);
      this.panelVigenereButtons.Margin = new System.Windows.Forms.Padding(0);
      this.panelVigenereButtons.Name = "panelVigenereButtons";
      this.panelVigenereButtons.Size = new System.Drawing.Size(884, 47);
      this.panelVigenereButtons.TabIndex = 0;
      // 
      // buttonVigenereClose
      // 
      this.buttonVigenereClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonVigenereClose.ImageIndex = 29;
      this.buttonVigenereClose.ImageList = this.imageList;
      this.buttonVigenereClose.Location = new System.Drawing.Point(11, 3);
      this.buttonVigenereClose.Name = "buttonVigenereClose";
      this.buttonVigenereClose.Size = new System.Drawing.Size(85, 39);
      this.buttonVigenereClose.TabIndex = 1;
      this.buttonVigenereClose.Text = "Close";
      this.buttonVigenereClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonVigenereClose.UseVisualStyleBackColor = true;
      this.buttonVigenereClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // buttonVigenereEncrypt
      // 
      this.buttonVigenereEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonVigenereEncrypt.ImageIndex = 15;
      this.buttonVigenereEncrypt.ImageList = this.imageList;
      this.buttonVigenereEncrypt.Location = new System.Drawing.Point(703, 3);
      this.buttonVigenereEncrypt.Name = "buttonVigenereEncrypt";
      this.buttonVigenereEncrypt.Size = new System.Drawing.Size(85, 39);
      this.buttonVigenereEncrypt.TabIndex = 1;
      this.buttonVigenereEncrypt.Text = "Encrypt";
      this.buttonVigenereEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonVigenereEncrypt.UseVisualStyleBackColor = true;
      this.buttonVigenereEncrypt.Click += new System.EventHandler(this.buttonVigenereEncrypt_Click);
      // 
      // buttonVigenereDecrypt
      // 
      this.buttonVigenereDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonVigenereDecrypt.ImageIndex = 14;
      this.buttonVigenereDecrypt.ImageList = this.imageList;
      this.buttonVigenereDecrypt.Location = new System.Drawing.Point(794, 3);
      this.buttonVigenereDecrypt.Name = "buttonVigenereDecrypt";
      this.buttonVigenereDecrypt.Size = new System.Drawing.Size(79, 39);
      this.buttonVigenereDecrypt.TabIndex = 0;
      this.buttonVigenereDecrypt.Text = "Decrypt";
      this.buttonVigenereDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonVigenereDecrypt.UseVisualStyleBackColor = true;
      this.buttonVigenereDecrypt.Click += new System.EventHandler(this.buttonVigenereDecrypt_Click);
      // 
      // tabPageColumnarTransposition
      // 
      this.tabPageColumnarTransposition.Controls.Add(this.lcCT);
      this.tabPageColumnarTransposition.Location = new System.Drawing.Point(4, 23);
      this.tabPageColumnarTransposition.Margin = new System.Windows.Forms.Padding(0);
      this.tabPageColumnarTransposition.Name = "tabPageColumnarTransposition";
      this.tabPageColumnarTransposition.Size = new System.Drawing.Size(884, 480);
      this.tabPageColumnarTransposition.TabIndex = 2;
      this.tabPageColumnarTransposition.Text = "Columnar Transposition";
      this.tabPageColumnarTransposition.UseVisualStyleBackColor = true;
      // 
      // lcCT
      // 
      this.lcCT.Controls.Add(this.panelCTContent);
      this.lcCT.Controls.Add(this.panelCTOptions);
      this.lcCT.Controls.Add(this.panelCTButtons);
      this.lcCT.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lcCT.Location = new System.Drawing.Point(0, 0);
      this.lcCT.Margin = new System.Windows.Forms.Padding(0);
      this.lcCT.Name = "lcCT";
      this.lcCT.Size = new System.Drawing.Size(884, 480);
      this.lcCT.TabIndex = 1;
      // 
      // panelCTContent
      // 
      this.panelCTContent.Controls.Add(this.panelCTEncryption);
      this.panelCTContent.Controls.Add(this.panelCTSteps);
      this.panelCTContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelCTContent.Location = new System.Drawing.Point(0, 70);
      this.panelCTContent.Name = "panelCTContent";
      this.panelCTContent.Size = new System.Drawing.Size(884, 363);
      this.panelCTContent.TabIndex = 6;
      // 
      // panelCTEncryption
      // 
      this.panelCTEncryption.Controls.Add(this.panelCTText);
      this.panelCTEncryption.Controls.Add(this.groupBoxCTKeys);
      this.panelCTEncryption.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelCTEncryption.Location = new System.Drawing.Point(0, 0);
      this.panelCTEncryption.Margin = new System.Windows.Forms.Padding(0);
      this.panelCTEncryption.Name = "panelCTEncryption";
      this.panelCTEncryption.Padding = new System.Windows.Forms.Padding(3);
      this.panelCTEncryption.Size = new System.Drawing.Size(703, 363);
      this.panelCTEncryption.TabIndex = 1;
      // 
      // panelCTText
      // 
      this.panelCTText.Controls.Add(this.labelResult);
      this.panelCTText.Controls.Add(this.labelCTInput);
      this.panelCTText.Controls.Add(this.richTextBoxCTResult);
      this.panelCTText.Controls.Add(this.richTextBoxCTInput);
      this.panelCTText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelCTText.Location = new System.Drawing.Point(225, 3);
      this.panelCTText.Name = "panelCTText";
      this.panelCTText.Size = new System.Drawing.Size(475, 357);
      this.panelCTText.TabIndex = 1;
      // 
      // labelResult
      // 
      this.labelResult.AutoSize = true;
      this.labelResult.Location = new System.Drawing.Point(7, 185);
      this.labelResult.Name = "labelResult";
      this.labelResult.Size = new System.Drawing.Size(134, 13);
      this.labelResult.TabIndex = 1;
      this.labelResult.Text = "Your result will appear here";
      // 
      // labelCTInput
      // 
      this.labelCTInput.AutoSize = true;
      this.labelCTInput.Location = new System.Drawing.Point(7, 4);
      this.labelCTInput.Name = "labelCTInput";
      this.labelCTInput.Size = new System.Drawing.Size(99, 13);
      this.labelCTInput.TabIndex = 1;
      this.labelCTInput.Text = "Enter your text here";
      // 
      // richTextBoxCTResult
      // 
      this.richTextBoxCTResult.Location = new System.Drawing.Point(6, 203);
      this.richTextBoxCTResult.Name = "richTextBoxCTResult";
      this.richTextBoxCTResult.Size = new System.Drawing.Size(466, 147);
      this.richTextBoxCTResult.TabIndex = 0;
      this.richTextBoxCTResult.Text = "";
      this.richTextBoxCTResult.TextChanged += new System.EventHandler(this.columnarTranspositionEditValueChanged);
      // 
      // richTextBoxCTInput
      // 
      this.richTextBoxCTInput.Location = new System.Drawing.Point(6, 22);
      this.richTextBoxCTInput.Name = "richTextBoxCTInput";
      this.richTextBoxCTInput.Size = new System.Drawing.Size(466, 147);
      this.richTextBoxCTInput.TabIndex = 0;
      this.richTextBoxCTInput.Text = "";
      this.richTextBoxCTInput.TextChanged += new System.EventHandler(this.columnarTranspositionEditValueChanged);
      // 
      // groupBoxCTKeys
      // 
      this.groupBoxCTKeys.Controls.Add(this.listBoxCTKeys);
      this.groupBoxCTKeys.Controls.Add(this.buttonCTAddKey);
      this.groupBoxCTKeys.Controls.Add(this.textBoxCTAddKey);
      this.groupBoxCTKeys.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBoxCTKeys.Location = new System.Drawing.Point(3, 3);
      this.groupBoxCTKeys.Name = "groupBoxCTKeys";
      this.groupBoxCTKeys.Size = new System.Drawing.Size(222, 357);
      this.groupBoxCTKeys.TabIndex = 0;
      this.groupBoxCTKeys.TabStop = false;
      this.groupBoxCTKeys.Text = "Keys";
      // 
      // listBoxCTKeys
      // 
      this.listBoxCTKeys.FormattingEnabled = true;
      this.listBoxCTKeys.Location = new System.Drawing.Point(5, 60);
      this.listBoxCTKeys.Name = "listBoxCTKeys";
      this.listBoxCTKeys.Size = new System.Drawing.Size(211, 290);
      this.listBoxCTKeys.TabIndex = 2;
      this.listBoxCTKeys.SelectedIndexChanged += new System.EventHandler(this.listBoxCTKeys_SelectedIndexChanged);
      // 
      // buttonCTAddKey
      // 
      this.buttonCTAddKey.ImageIndex = 33;
      this.buttonCTAddKey.ImageList = this.imageList;
      this.buttonCTAddKey.Location = new System.Drawing.Point(132, 20);
      this.buttonCTAddKey.Name = "buttonCTAddKey";
      this.buttonCTAddKey.Size = new System.Drawing.Size(75, 23);
      this.buttonCTAddKey.TabIndex = 1;
      this.buttonCTAddKey.UseVisualStyleBackColor = true;
      this.buttonCTAddKey.Click += new System.EventHandler(this.buttonCTAddKey_Click);
      // 
      // textBoxCTAddKey
      // 
      this.textBoxCTAddKey.Location = new System.Drawing.Point(5, 20);
      this.textBoxCTAddKey.Multiline = true;
      this.textBoxCTAddKey.Name = "textBoxCTAddKey";
      this.textBoxCTAddKey.Size = new System.Drawing.Size(211, 34);
      this.textBoxCTAddKey.TabIndex = 0;
      this.textBoxCTAddKey.TextChanged += new System.EventHandler(this.columnarTranspositionEditValueChanged);
      // 
      // panelCTSteps
      // 
      this.panelCTSteps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panelCTSteps.Controls.Add(this.groupBoxSteps);
      this.panelCTSteps.Dock = System.Windows.Forms.DockStyle.Right;
      this.panelCTSteps.Location = new System.Drawing.Point(703, 0);
      this.panelCTSteps.Margin = new System.Windows.Forms.Padding(0);
      this.panelCTSteps.Name = "panelCTSteps";
      this.panelCTSteps.Size = new System.Drawing.Size(181, 363);
      this.panelCTSteps.TabIndex = 0;
      // 
      // groupBoxSteps
      // 
      this.groupBoxSteps.Controls.Add(this.listBoxCTSteps);
      this.groupBoxSteps.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBoxSteps.Location = new System.Drawing.Point(0, 0);
      this.groupBoxSteps.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxSteps.Name = "groupBoxSteps";
      this.groupBoxSteps.Size = new System.Drawing.Size(181, 363);
      this.groupBoxSteps.TabIndex = 1;
      this.groupBoxSteps.TabStop = false;
      this.groupBoxSteps.Text = "Steps";
      // 
      // listBoxCTSteps
      // 
      this.listBoxCTSteps.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBoxCTSteps.FormattingEnabled = true;
      this.listBoxCTSteps.Location = new System.Drawing.Point(3, 16);
      this.listBoxCTSteps.Margin = new System.Windows.Forms.Padding(0);
      this.listBoxCTSteps.Name = "listBoxCTSteps";
      this.listBoxCTSteps.Size = new System.Drawing.Size(175, 344);
      this.listBoxCTSteps.TabIndex = 0;
      this.listBoxCTSteps.SelectedIndexChanged += new System.EventHandler(this.listBoxCTSteps_SelectedIndexChanged);
      // 
      // panelCTOptions
      // 
      this.panelCTOptions.Controls.Add(this.labelCTSeeSteps);
      this.panelCTOptions.Controls.Add(this.radioButtonCTNo);
      this.panelCTOptions.Controls.Add(this.radioButtonCTYes);
      this.panelCTOptions.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelCTOptions.Location = new System.Drawing.Point(0, 0);
      this.panelCTOptions.Name = "panelCTOptions";
      this.panelCTOptions.Size = new System.Drawing.Size(884, 70);
      this.panelCTOptions.TabIndex = 5;
      // 
      // labelCTSeeSteps
      // 
      this.labelCTSeeSteps.AutoSize = true;
      this.labelCTSeeSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelCTSeeSteps.Location = new System.Drawing.Point(8, 27);
      this.labelCTSeeSteps.Name = "labelCTSeeSteps";
      this.labelCTSeeSteps.Size = new System.Drawing.Size(214, 16);
      this.labelCTSeeSteps.TabIndex = 3;
      this.labelCTSeeSteps.Text = "Do you want to see the steps?";
      // 
      // radioButtonCTNo
      // 
      this.radioButtonCTNo.AutoSize = true;
      this.radioButtonCTNo.Checked = true;
      this.radioButtonCTNo.Location = new System.Drawing.Point(347, 27);
      this.radioButtonCTNo.Name = "radioButtonCTNo";
      this.radioButtonCTNo.Size = new System.Drawing.Size(39, 17);
      this.radioButtonCTNo.TabIndex = 2;
      this.radioButtonCTNo.TabStop = true;
      this.radioButtonCTNo.Text = "No";
      this.radioButtonCTNo.UseVisualStyleBackColor = true;
      this.radioButtonCTNo.CheckedChanged += new System.EventHandler(this.radioButtonCT_CheckedChanged);
      // 
      // radioButtonCTYes
      // 
      this.radioButtonCTYes.AutoSize = true;
      this.radioButtonCTYes.Location = new System.Drawing.Point(276, 27);
      this.radioButtonCTYes.Name = "radioButtonCTYes";
      this.radioButtonCTYes.Size = new System.Drawing.Size(43, 17);
      this.radioButtonCTYes.TabIndex = 1;
      this.radioButtonCTYes.Text = "Yes";
      this.radioButtonCTYes.UseVisualStyleBackColor = true;
      this.radioButtonCTYes.CheckedChanged += new System.EventHandler(this.radioButtonCT_CheckedChanged);
      // 
      // panelCTButtons
      // 
      this.panelCTButtons.Controls.Add(this.buttonCTRemoveKey);
      this.panelCTButtons.Controls.Add(this.buttonCTClearKeys);
      this.panelCTButtons.Controls.Add(this.buttonCTClose);
      this.panelCTButtons.Controls.Add(this.buttonCTEncrypt);
      this.panelCTButtons.Controls.Add(this.buttonCTDecrypt);
      this.panelCTButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelCTButtons.Location = new System.Drawing.Point(0, 433);
      this.panelCTButtons.Margin = new System.Windows.Forms.Padding(0);
      this.panelCTButtons.Name = "panelCTButtons";
      this.panelCTButtons.Size = new System.Drawing.Size(884, 47);
      this.panelCTButtons.TabIndex = 0;
      // 
      // buttonCTRemoveKey
      // 
      this.buttonCTRemoveKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonCTRemoveKey.ImageIndex = 35;
      this.buttonCTRemoveKey.ImageList = this.imageList;
      this.buttonCTRemoveKey.Location = new System.Drawing.Point(216, 3);
      this.buttonCTRemoveKey.Name = "buttonCTRemoveKey";
      this.buttonCTRemoveKey.Size = new System.Drawing.Size(108, 39);
      this.buttonCTRemoveKey.TabIndex = 1;
      this.buttonCTRemoveKey.Text = "Remove Key";
      this.buttonCTRemoveKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonCTRemoveKey.UseVisualStyleBackColor = true;
      this.buttonCTRemoveKey.Click += new System.EventHandler(this.buttonCTRemoveKey_Click);
      // 
      // buttonCTClearKeys
      // 
      this.buttonCTClearKeys.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonCTClearKeys.ImageIndex = 34;
      this.buttonCTClearKeys.ImageList = this.imageList;
      this.buttonCTClearKeys.Location = new System.Drawing.Point(102, 3);
      this.buttonCTClearKeys.Name = "buttonCTClearKeys";
      this.buttonCTClearKeys.Size = new System.Drawing.Size(108, 39);
      this.buttonCTClearKeys.TabIndex = 1;
      this.buttonCTClearKeys.Text = "Clear Keys";
      this.buttonCTClearKeys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonCTClearKeys.UseVisualStyleBackColor = true;
      this.buttonCTClearKeys.Click += new System.EventHandler(this.buttonCTClearKeys_Click);
      // 
      // buttonCTClose
      // 
      this.buttonCTClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonCTClose.ImageIndex = 29;
      this.buttonCTClose.ImageList = this.imageList;
      this.buttonCTClose.Location = new System.Drawing.Point(11, 3);
      this.buttonCTClose.Name = "buttonCTClose";
      this.buttonCTClose.Size = new System.Drawing.Size(85, 39);
      this.buttonCTClose.TabIndex = 1;
      this.buttonCTClose.Text = "Close";
      this.buttonCTClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonCTClose.UseVisualStyleBackColor = true;
      this.buttonCTClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // buttonCTEncrypt
      // 
      this.buttonCTEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonCTEncrypt.ImageIndex = 15;
      this.buttonCTEncrypt.ImageList = this.imageList;
      this.buttonCTEncrypt.Location = new System.Drawing.Point(703, 3);
      this.buttonCTEncrypt.Name = "buttonCTEncrypt";
      this.buttonCTEncrypt.Size = new System.Drawing.Size(85, 39);
      this.buttonCTEncrypt.TabIndex = 1;
      this.buttonCTEncrypt.Text = "Encrypt";
      this.buttonCTEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonCTEncrypt.UseVisualStyleBackColor = true;
      this.buttonCTEncrypt.Click += new System.EventHandler(this.buttonCTEncrypt_Click);
      // 
      // buttonCTDecrypt
      // 
      this.buttonCTDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonCTDecrypt.ImageIndex = 14;
      this.buttonCTDecrypt.ImageList = this.imageList;
      this.buttonCTDecrypt.Location = new System.Drawing.Point(794, 3);
      this.buttonCTDecrypt.Name = "buttonCTDecrypt";
      this.buttonCTDecrypt.Size = new System.Drawing.Size(79, 39);
      this.buttonCTDecrypt.TabIndex = 0;
      this.buttonCTDecrypt.Text = "Decrypt";
      this.buttonCTDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonCTDecrypt.UseVisualStyleBackColor = true;
      this.buttonCTDecrypt.Click += new System.EventHandler(this.buttonCTDecrypt_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(892, 507);
      this.Controls.Add(this.tabControlMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(908, 546);
      this.MinimumSize = new System.Drawing.Size(908, 546);
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Encryption";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.tabControlMain.ResumeLayout(false);
      this.tabPageVernam.ResumeLayout(false);
      this.lcVernam.ResumeLayout(false);
      this.lcVernam.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panelBernamButtons.ResumeLayout(false);
      this.tabPageVigenere.ResumeLayout(false);
      this.lcVigenere.ResumeLayout(false);
      this.lcVigenere.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panelVigenereButtons.ResumeLayout(false);
      this.tabPageColumnarTransposition.ResumeLayout(false);
      this.lcCT.ResumeLayout(false);
      this.panelCTContent.ResumeLayout(false);
      this.panelCTEncryption.ResumeLayout(false);
      this.panelCTText.ResumeLayout(false);
      this.panelCTText.PerformLayout();
      this.groupBoxCTKeys.ResumeLayout(false);
      this.groupBoxCTKeys.PerformLayout();
      this.panelCTSteps.ResumeLayout(false);
      this.groupBoxSteps.ResumeLayout(false);
      this.panelCTOptions.ResumeLayout(false);
      this.panelCTOptions.PerformLayout();
      this.panelCTButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageVernam;
    private System.Windows.Forms.Panel lcVernam;
    private System.Windows.Forms.Panel panelBernamButtons;
    private System.Windows.Forms.Button buttonVernamEncrypt;
    private System.Windows.Forms.ImageList imageList;
    private System.Windows.Forms.Button buttonVernamDecrypt;
    private System.Windows.Forms.TabPage tabPageVigenere;
    private System.Windows.Forms.TabPage tabPageColumnarTransposition;
    private System.Windows.Forms.Button buttonVernamClose;
    private System.Windows.Forms.Panel lcVigenere;
    private System.Windows.Forms.Panel panelVigenereButtons;
    private System.Windows.Forms.Button buttonVigenereClose;
    private System.Windows.Forms.Button buttonVigenereEncrypt;
    private System.Windows.Forms.Button buttonVigenereDecrypt;
    private System.Windows.Forms.Panel lcCT;
    private System.Windows.Forms.Panel panelCTButtons;
    private System.Windows.Forms.Button buttonCTClose;
    private System.Windows.Forms.Button buttonCTEncrypt;
    private System.Windows.Forms.Button buttonCTDecrypt;
    private System.Windows.Forms.RichTextBox richTextBoxVernamInput;
    private System.Windows.Forms.Label labelVernamInput;
    private System.Windows.Forms.Label labelVernamOpenFile;
    private System.Windows.Forms.Button buttonVernamOpenFile;
    private System.Windows.Forms.TextBox textBoxVernamOpenFile;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.Label labelVernamSaveTo;
    private System.Windows.Forms.Button buttonVernamSaveTo;
    private System.Windows.Forms.TextBox textBoxVernamSaveTo;
    private System.Windows.Forms.Button buttonVernamKeyStoreOpen;
    private System.Windows.Forms.Label labelVernamKeyStore;
    private System.Windows.Forms.TextBox textBoxVernamKeyStore;
    private System.Windows.Forms.Button buttonVernamKeyStoreSave;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label labelVernamTextOrFile;
    private System.Windows.Forms.RadioButton radioButtonText;
    private System.Windows.Forms.RadioButton radioButtonFile;
    private System.Windows.Forms.RichTextBox richTextBoxVigenereResult;
    private System.Windows.Forms.Label labelVigenereResult;
    private System.Windows.Forms.RichTextBox richTextBoxVigenereInput;
    private System.Windows.Forms.Label labelVigenerePlainText;
    private System.Windows.Forms.Label labelVigenereKey;
    private System.Windows.Forms.RichTextBox richTextBoxVigenereKey;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.RadioButton radioButtonVigenereYes;
    private System.Windows.Forms.Label labelAlphabet;
    private System.Windows.Forms.RichTextBox richTextBoxVigenereCustomAlphabet;
    private System.Windows.Forms.Label labelVigenereCustomAlphabet;
    private System.Windows.Forms.RadioButton radioButtonVigenereNo;
    private System.Windows.Forms.Panel panelCTOptions;
    private System.Windows.Forms.Label labelCTSeeSteps;
    private System.Windows.Forms.RadioButton radioButtonCTNo;
    private System.Windows.Forms.RadioButton radioButtonCTYes;
    private System.Windows.Forms.Panel panelCTContent;
    private System.Windows.Forms.Panel panelCTEncryption;
    private System.Windows.Forms.Panel panelCTSteps;
    private System.Windows.Forms.ListBox listBoxCTSteps;
    private System.Windows.Forms.GroupBox groupBoxCTKeys;
    private System.Windows.Forms.Button buttonCTAddKey;
    private System.Windows.Forms.TextBox textBoxCTAddKey;
    private System.Windows.Forms.Panel panelCTText;
    private System.Windows.Forms.Label labelResult;
    private System.Windows.Forms.Label labelCTInput;
    private System.Windows.Forms.RichTextBox richTextBoxCTResult;
    private System.Windows.Forms.RichTextBox richTextBoxCTInput;
    private System.Windows.Forms.ListBox listBoxCTKeys;
    private System.Windows.Forms.Button buttonCTClearKeys;
    private System.Windows.Forms.Button buttonCTRemoveKey;
    private System.Windows.Forms.GroupBox groupBoxSteps;
  }
}

