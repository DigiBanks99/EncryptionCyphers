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
      var key = "ZEBRAS";
      var expectedResult = "EVLNQACDTQESEAQROFOQDEECQWIREE";
      var cipher = new ColumnarTranspositionCypher();
      cipher.Decrypt(key, expectedResult);
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
