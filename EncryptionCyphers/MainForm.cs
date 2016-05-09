using EncryptionCyphers.Cyphers;
using System.Windows.Forms;

namespace EncryptionCyphers
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    public void LoadControl()
    {
      var vigenere = new VigenereCypher();
    }

    private void MainForm_Load(object sender, System.EventArgs e)
    {
      try
      {
        LoadControl();
      }
      catch
      {
        Application.Exit();
        this.Close();
      }
    }
  }
}
