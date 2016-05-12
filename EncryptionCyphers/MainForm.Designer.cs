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
      this.panelBernamButtons = new System.Windows.Forms.Panel();
      this.buttonVernamClose = new System.Windows.Forms.Button();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.buttonVernamEncrypt = new System.Windows.Forms.Button();
      this.buttonVernamDecrypt = new System.Windows.Forms.Button();
      this.tabPageVigenere = new System.Windows.Forms.TabPage();
      this.lcVigenere = new System.Windows.Forms.Panel();
      this.panelVigenereButtons = new System.Windows.Forms.Panel();
      this.buttonVigenereClose = new System.Windows.Forms.Button();
      this.buttonVigenereEncrypt = new System.Windows.Forms.Button();
      this.buttonVigenereDecrypt = new System.Windows.Forms.Button();
      this.tabPageColumnarTransposition = new System.Windows.Forms.TabPage();
      this.lcCT = new System.Windows.Forms.Panel();
      this.panelCTButtons = new System.Windows.Forms.Panel();
      this.buttonCTClose = new System.Windows.Forms.Button();
      this.buttonCTEncrypt = new System.Windows.Forms.Button();
      this.buttonCTDecrypt = new System.Windows.Forms.Button();
      this.splitContainerVernam = new System.Windows.Forms.SplitContainer();
      this.labelVernamInput = new System.Windows.Forms.Label();
      this.richTextBoxVernamInput = new System.Windows.Forms.RichTextBox();
      this.labelVernamResult = new System.Windows.Forms.Label();
      this.richTextBoxVernamResult = new System.Windows.Forms.RichTextBox();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.textBoxVernamOpenFile = new System.Windows.Forms.TextBox();
      this.buttonVernamOpenFile = new System.Windows.Forms.Button();
      this.labelVernamOpenFile = new System.Windows.Forms.Label();
      this.labelVernamSaveTo = new System.Windows.Forms.Label();
      this.textBoxVernamSaveTo = new System.Windows.Forms.TextBox();
      this.buttonVernamSaveTo = new System.Windows.Forms.Button();
      this.panelVernamHeader = new System.Windows.Forms.Panel();
      this.buttonVernamKeyStore = new System.Windows.Forms.Button();
      this.textBoxVernamKeyStore = new System.Windows.Forms.TextBox();
      this.labelVernamKeyStore = new System.Windows.Forms.Label();
      this.groupBoxStringOrFile = new System.Windows.Forms.GroupBox();
      this.radioButtonFromText = new System.Windows.Forms.RadioButton();
      this.radioButtonFromFile = new System.Windows.Forms.RadioButton();
      this.tabControlMain.SuspendLayout();
      this.tabPageVernam.SuspendLayout();
      this.lcVernam.SuspendLayout();
      this.panelBernamButtons.SuspendLayout();
      this.tabPageVigenere.SuspendLayout();
      this.lcVigenere.SuspendLayout();
      this.panelVigenereButtons.SuspendLayout();
      this.tabPageColumnarTransposition.SuspendLayout();
      this.lcCT.SuspendLayout();
      this.panelCTButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerVernam)).BeginInit();
      this.splitContainerVernam.Panel1.SuspendLayout();
      this.splitContainerVernam.Panel2.SuspendLayout();
      this.splitContainerVernam.SuspendLayout();
      this.panelVernamHeader.SuspendLayout();
      this.groupBoxStringOrFile.SuspendLayout();
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
      this.tabControlMain.Size = new System.Drawing.Size(892, 563);
      this.tabControlMain.TabIndex = 0;
      // 
      // tabPageVernam
      // 
      this.tabPageVernam.Controls.Add(this.lcVernam);
      this.tabPageVernam.Location = new System.Drawing.Point(4, 23);
      this.tabPageVernam.Name = "tabPageVernam";
      this.tabPageVernam.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageVernam.Size = new System.Drawing.Size(884, 536);
      this.tabPageVernam.TabIndex = 0;
      this.tabPageVernam.Text = "Vernam";
      this.tabPageVernam.UseVisualStyleBackColor = true;
      // 
      // lcVernam
      // 
      this.lcVernam.Controls.Add(this.splitContainerVernam);
      this.lcVernam.Controls.Add(this.panelVernamHeader);
      this.lcVernam.Controls.Add(this.panelBernamButtons);
      this.lcVernam.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lcVernam.Location = new System.Drawing.Point(3, 3);
      this.lcVernam.Margin = new System.Windows.Forms.Padding(0);
      this.lcVernam.Name = "lcVernam";
      this.lcVernam.Size = new System.Drawing.Size(878, 530);
      this.lcVernam.TabIndex = 0;
      // 
      // panelBernamButtons
      // 
      this.panelBernamButtons.Controls.Add(this.buttonVernamClose);
      this.panelBernamButtons.Controls.Add(this.buttonVernamEncrypt);
      this.panelBernamButtons.Controls.Add(this.buttonVernamDecrypt);
      this.panelBernamButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelBernamButtons.Location = new System.Drawing.Point(0, 483);
      this.panelBernamButtons.Margin = new System.Windows.Forms.Padding(0);
      this.panelBernamButtons.Name = "panelBernamButtons";
      this.panelBernamButtons.Size = new System.Drawing.Size(878, 47);
      this.panelBernamButtons.TabIndex = 0;
      // 
      // buttonVernamClose
      // 
      this.buttonVernamClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonVernamClose.ImageIndex = 29;
      this.buttonVernamClose.ImageList = this.imageList;
      this.buttonVernamClose.Location = new System.Drawing.Point(5, 3);
      this.buttonVernamClose.Name = "buttonVernamClose";
      this.buttonVernamClose.Size = new System.Drawing.Size(85, 39);
      this.buttonVernamClose.TabIndex = 1;
      this.buttonVernamClose.Text = "Close";
      this.buttonVernamClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonVernamClose.UseVisualStyleBackColor = true;
      this.buttonVernamClose.Click += new System.EventHandler(this.buttonClose_Click);
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
      // 
      // tabPageVigenere
      // 
      this.tabPageVigenere.Controls.Add(this.lcVigenere);
      this.tabPageVigenere.Location = new System.Drawing.Point(4, 23);
      this.tabPageVigenere.Name = "tabPageVigenere";
      this.tabPageVigenere.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageVigenere.Size = new System.Drawing.Size(884, 536);
      this.tabPageVigenere.TabIndex = 1;
      this.tabPageVigenere.Text = "Vigenére";
      this.tabPageVigenere.UseVisualStyleBackColor = true;
      // 
      // lcVigenere
      // 
      this.lcVigenere.Controls.Add(this.panelVigenereButtons);
      this.lcVigenere.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lcVigenere.Location = new System.Drawing.Point(3, 3);
      this.lcVigenere.Margin = new System.Windows.Forms.Padding(0);
      this.lcVigenere.Name = "lcVigenere";
      this.lcVigenere.Size = new System.Drawing.Size(878, 530);
      this.lcVigenere.TabIndex = 1;
      // 
      // panelVigenereButtons
      // 
      this.panelVigenereButtons.Controls.Add(this.buttonVigenereClose);
      this.panelVigenereButtons.Controls.Add(this.buttonVigenereEncrypt);
      this.panelVigenereButtons.Controls.Add(this.buttonVigenereDecrypt);
      this.panelVigenereButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelVigenereButtons.Location = new System.Drawing.Point(0, 483);
      this.panelVigenereButtons.Margin = new System.Windows.Forms.Padding(0);
      this.panelVigenereButtons.Name = "panelVigenereButtons";
      this.panelVigenereButtons.Size = new System.Drawing.Size(878, 47);
      this.panelVigenereButtons.TabIndex = 0;
      // 
      // buttonVigenereClose
      // 
      this.buttonVigenereClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonVigenereClose.ImageIndex = 29;
      this.buttonVigenereClose.ImageList = this.imageList;
      this.buttonVigenereClose.Location = new System.Drawing.Point(5, 3);
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
      // 
      // tabPageColumnarTransposition
      // 
      this.tabPageColumnarTransposition.Controls.Add(this.lcCT);
      this.tabPageColumnarTransposition.Location = new System.Drawing.Point(4, 23);
      this.tabPageColumnarTransposition.Name = "tabPageColumnarTransposition";
      this.tabPageColumnarTransposition.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageColumnarTransposition.Size = new System.Drawing.Size(884, 536);
      this.tabPageColumnarTransposition.TabIndex = 2;
      this.tabPageColumnarTransposition.Text = "Columnar Transposition";
      this.tabPageColumnarTransposition.UseVisualStyleBackColor = true;
      // 
      // lcCT
      // 
      this.lcCT.Controls.Add(this.panelCTButtons);
      this.lcCT.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lcCT.Location = new System.Drawing.Point(3, 3);
      this.lcCT.Margin = new System.Windows.Forms.Padding(0);
      this.lcCT.Name = "lcCT";
      this.lcCT.Size = new System.Drawing.Size(878, 530);
      this.lcCT.TabIndex = 1;
      // 
      // panelCTButtons
      // 
      this.panelCTButtons.Controls.Add(this.buttonCTClose);
      this.panelCTButtons.Controls.Add(this.buttonCTEncrypt);
      this.panelCTButtons.Controls.Add(this.buttonCTDecrypt);
      this.panelCTButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelCTButtons.Location = new System.Drawing.Point(0, 483);
      this.panelCTButtons.Margin = new System.Windows.Forms.Padding(0);
      this.panelCTButtons.Name = "panelCTButtons";
      this.panelCTButtons.Size = new System.Drawing.Size(878, 47);
      this.panelCTButtons.TabIndex = 0;
      // 
      // buttonCTClose
      // 
      this.buttonCTClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonCTClose.ImageIndex = 29;
      this.buttonCTClose.ImageList = this.imageList;
      this.buttonCTClose.Location = new System.Drawing.Point(5, 3);
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
      // 
      // splitContainerVernam
      // 
      this.splitContainerVernam.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerVernam.Location = new System.Drawing.Point(0, 57);
      this.splitContainerVernam.Margin = new System.Windows.Forms.Padding(0);
      this.splitContainerVernam.Name = "splitContainerVernam";
      // 
      // splitContainerVernam.Panel1
      // 
      this.splitContainerVernam.Panel1.Controls.Add(this.richTextBoxVernamResult);
      this.splitContainerVernam.Panel1.Controls.Add(this.labelVernamResult);
      this.splitContainerVernam.Panel1.Controls.Add(this.richTextBoxVernamInput);
      this.splitContainerVernam.Panel1.Controls.Add(this.labelVernamInput);
      // 
      // splitContainerVernam.Panel2
      // 
      this.splitContainerVernam.Panel2.Controls.Add(this.labelVernamSaveTo);
      this.splitContainerVernam.Panel2.Controls.Add(this.labelVernamOpenFile);
      this.splitContainerVernam.Panel2.Controls.Add(this.buttonVernamSaveTo);
      this.splitContainerVernam.Panel2.Controls.Add(this.buttonVernamOpenFile);
      this.splitContainerVernam.Panel2.Controls.Add(this.textBoxVernamSaveTo);
      this.splitContainerVernam.Panel2.Controls.Add(this.textBoxVernamOpenFile);
      this.splitContainerVernam.Size = new System.Drawing.Size(878, 426);
      this.splitContainerVernam.SplitterDistance = 428;
      this.splitContainerVernam.TabIndex = 1;
      // 
      // labelVernamInput
      // 
      this.labelVernamInput.AutoSize = true;
      this.labelVernamInput.Location = new System.Drawing.Point(4, 4);
      this.labelVernamInput.Name = "labelVernamInput";
      this.labelVernamInput.Size = new System.Drawing.Size(142, 13);
      this.labelVernamInput.TabIndex = 0;
      this.labelVernamInput.Text = "Enter text to encrypt/decrypt";
      // 
      // richTextBoxVernamInput
      // 
      this.richTextBoxVernamInput.Location = new System.Drawing.Point(0, 21);
      this.richTextBoxVernamInput.Name = "richTextBoxVernamInput";
      this.richTextBoxVernamInput.Size = new System.Drawing.Size(426, 222);
      this.richTextBoxVernamInput.TabIndex = 1;
      this.richTextBoxVernamInput.Text = "";
      // 
      // labelVernamResult
      // 
      this.labelVernamResult.AutoSize = true;
      this.labelVernamResult.Location = new System.Drawing.Point(4, 246);
      this.labelVernamResult.Name = "labelVernamResult";
      this.labelVernamResult.Size = new System.Drawing.Size(88, 13);
      this.labelVernamResult.TabIndex = 0;
      this.labelVernamResult.Text = "The resulting text";
      // 
      // richTextBoxVernamResult
      // 
      this.richTextBoxVernamResult.Location = new System.Drawing.Point(0, 263);
      this.richTextBoxVernamResult.Name = "richTextBoxVernamResult";
      this.richTextBoxVernamResult.Size = new System.Drawing.Size(426, 217);
      this.richTextBoxVernamResult.TabIndex = 1;
      this.richTextBoxVernamResult.Text = "";
      // 
      // textBoxVernamOpenFile
      // 
      this.textBoxVernamOpenFile.Location = new System.Drawing.Point(111, 7);
      this.textBoxVernamOpenFile.Multiline = true;
      this.textBoxVernamOpenFile.Name = "textBoxVernamOpenFile";
      this.textBoxVernamOpenFile.Size = new System.Drawing.Size(330, 25);
      this.textBoxVernamOpenFile.TabIndex = 0;
      this.textBoxVernamOpenFile.WordWrap = false;
      // 
      // buttonVernamOpenFile
      // 
      this.buttonVernamOpenFile.ImageIndex = 31;
      this.buttonVernamOpenFile.ImageList = this.imageList;
      this.buttonVernamOpenFile.Location = new System.Drawing.Point(362, 10);
      this.buttonVernamOpenFile.Name = "buttonVernamOpenFile";
      this.buttonVernamOpenFile.Size = new System.Drawing.Size(75, 20);
      this.buttonVernamOpenFile.TabIndex = 1;
      this.buttonVernamOpenFile.UseVisualStyleBackColor = true;
      this.buttonVernamOpenFile.Click += new System.EventHandler(this.buttonVernamOpenFile_Click);
      // 
      // labelVernamOpenFile
      // 
      this.labelVernamOpenFile.AutoSize = true;
      this.labelVernamOpenFile.Location = new System.Drawing.Point(3, 14);
      this.labelVernamOpenFile.Name = "labelVernamOpenFile";
      this.labelVernamOpenFile.Size = new System.Drawing.Size(101, 13);
      this.labelVernamOpenFile.TabIndex = 2;
      this.labelVernamOpenFile.Text = "Select or enter a file";
      // 
      // labelVernamSaveTo
      // 
      this.labelVernamSaveTo.AutoSize = true;
      this.labelVernamSaveTo.Location = new System.Drawing.Point(4, 47);
      this.labelVernamSaveTo.Name = "labelVernamSaveTo";
      this.labelVernamSaveTo.Size = new System.Drawing.Size(89, 13);
      this.labelVernamSaveTo.TabIndex = 2;
      this.labelVernamSaveTo.Text = "Set save location";
      // 
      // textBoxVernamSaveTo
      // 
      this.textBoxVernamSaveTo.Location = new System.Drawing.Point(111, 40);
      this.textBoxVernamSaveTo.Multiline = true;
      this.textBoxVernamSaveTo.Name = "textBoxVernamSaveTo";
      this.textBoxVernamSaveTo.Size = new System.Drawing.Size(330, 25);
      this.textBoxVernamSaveTo.TabIndex = 0;
      this.textBoxVernamSaveTo.WordWrap = false;
      // 
      // buttonVernamSaveTo
      // 
      this.buttonVernamSaveTo.ImageIndex = 32;
      this.buttonVernamSaveTo.ImageList = this.imageList;
      this.buttonVernamSaveTo.Location = new System.Drawing.Point(362, 43);
      this.buttonVernamSaveTo.Name = "buttonVernamSaveTo";
      this.buttonVernamSaveTo.Size = new System.Drawing.Size(75, 20);
      this.buttonVernamSaveTo.TabIndex = 1;
      this.buttonVernamSaveTo.UseVisualStyleBackColor = true;
      this.buttonVernamSaveTo.Click += new System.EventHandler(this.buttonVernamOpenFile_Click);
      // 
      // panelVernamHeader
      // 
      this.panelVernamHeader.Controls.Add(this.groupBoxStringOrFile);
      this.panelVernamHeader.Controls.Add(this.buttonVernamKeyStore);
      this.panelVernamHeader.Controls.Add(this.labelVernamKeyStore);
      this.panelVernamHeader.Controls.Add(this.textBoxVernamKeyStore);
      this.panelVernamHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelVernamHeader.Location = new System.Drawing.Point(0, 0);
      this.panelVernamHeader.Name = "panelVernamHeader";
      this.panelVernamHeader.Size = new System.Drawing.Size(878, 57);
      this.panelVernamHeader.TabIndex = 2;
      // 
      // buttonVernamKeyStore
      // 
      this.buttonVernamKeyStore.ImageIndex = 31;
      this.buttonVernamKeyStore.ImageList = this.imageList;
      this.buttonVernamKeyStore.Location = new System.Drawing.Point(351, 18);
      this.buttonVernamKeyStore.Name = "buttonVernamKeyStore";
      this.buttonVernamKeyStore.Size = new System.Drawing.Size(75, 20);
      this.buttonVernamKeyStore.TabIndex = 3;
      this.buttonVernamKeyStore.UseVisualStyleBackColor = true;
      this.buttonVernamKeyStore.Click += new System.EventHandler(this.buttonVernamKeyStore_Click);
      // 
      // textBoxVernamKeyStore
      // 
      this.textBoxVernamKeyStore.Location = new System.Drawing.Point(112, 15);
      this.textBoxVernamKeyStore.Multiline = true;
      this.textBoxVernamKeyStore.Name = "textBoxVernamKeyStore";
      this.textBoxVernamKeyStore.Size = new System.Drawing.Size(330, 25);
      this.textBoxVernamKeyStore.TabIndex = 2;
      this.textBoxVernamKeyStore.WordWrap = false;
      // 
      // labelVernamKeyStore
      // 
      this.labelVernamKeyStore.AutoSize = true;
      this.labelVernamKeyStore.Location = new System.Drawing.Point(3, 18);
      this.labelVernamKeyStore.Name = "labelVernamKeyStore";
      this.labelVernamKeyStore.Size = new System.Drawing.Size(101, 13);
      this.labelVernamKeyStore.TabIndex = 2;
      this.labelVernamKeyStore.Text = "Set the key location";
      // 
      // groupBoxStringOrFile
      // 
      this.groupBoxStringOrFile.Controls.Add(this.radioButtonFromFile);
      this.groupBoxStringOrFile.Controls.Add(this.radioButtonFromText);
      this.groupBoxStringOrFile.Location = new System.Drawing.Point(531, 3);
      this.groupBoxStringOrFile.Name = "groupBoxStringOrFile";
      this.groupBoxStringOrFile.Size = new System.Drawing.Size(342, 51);
      this.groupBoxStringOrFile.TabIndex = 4;
      this.groupBoxStringOrFile.TabStop = false;
      this.groupBoxStringOrFile.Text = "Encrypt from";
      // 
      // radioButtonFromText
      // 
      this.radioButtonFromText.AutoSize = true;
      this.radioButtonFromText.Checked = true;
      this.radioButtonFromText.Location = new System.Drawing.Point(12, 20);
      this.radioButtonFromText.Name = "radioButtonFromText";
      this.radioButtonFromText.Size = new System.Drawing.Size(46, 17);
      this.radioButtonFromText.TabIndex = 0;
      this.radioButtonFromText.TabStop = true;
      this.radioButtonFromText.Text = "Text";
      this.radioButtonFromText.UseVisualStyleBackColor = true;
      // 
      // radioButtonFromFile
      // 
      this.radioButtonFromFile.AutoSize = true;
      this.radioButtonFromFile.Location = new System.Drawing.Point(131, 20);
      this.radioButtonFromFile.Name = "radioButtonFromFile";
      this.radioButtonFromFile.Size = new System.Drawing.Size(41, 17);
      this.radioButtonFromFile.TabIndex = 1;
      this.radioButtonFromFile.TabStop = true;
      this.radioButtonFromFile.Text = "File";
      this.radioButtonFromFile.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(892, 563);
      this.Controls.Add(this.tabControlMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Encryption";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.tabControlMain.ResumeLayout(false);
      this.tabPageVernam.ResumeLayout(false);
      this.lcVernam.ResumeLayout(false);
      this.panelBernamButtons.ResumeLayout(false);
      this.tabPageVigenere.ResumeLayout(false);
      this.lcVigenere.ResumeLayout(false);
      this.panelVigenereButtons.ResumeLayout(false);
      this.tabPageColumnarTransposition.ResumeLayout(false);
      this.lcCT.ResumeLayout(false);
      this.panelCTButtons.ResumeLayout(false);
      this.splitContainerVernam.Panel1.ResumeLayout(false);
      this.splitContainerVernam.Panel1.PerformLayout();
      this.splitContainerVernam.Panel2.ResumeLayout(false);
      this.splitContainerVernam.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerVernam)).EndInit();
      this.splitContainerVernam.ResumeLayout(false);
      this.panelVernamHeader.ResumeLayout(false);
      this.panelVernamHeader.PerformLayout();
      this.groupBoxStringOrFile.ResumeLayout(false);
      this.groupBoxStringOrFile.PerformLayout();
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
    private System.Windows.Forms.SplitContainer splitContainerVernam;
    private System.Windows.Forms.RichTextBox richTextBoxVernamResult;
    private System.Windows.Forms.Label labelVernamResult;
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
    private System.Windows.Forms.Panel panelVernamHeader;
    private System.Windows.Forms.Button buttonVernamKeyStore;
    private System.Windows.Forms.Label labelVernamKeyStore;
    private System.Windows.Forms.TextBox textBoxVernamKeyStore;
    private System.Windows.Forms.GroupBox groupBoxStringOrFile;
    private System.Windows.Forms.RadioButton radioButtonFromFile;
    private System.Windows.Forms.RadioButton radioButtonFromText;
  }
}

