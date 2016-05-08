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
      var vernam = new VernamCypher();
    }
  }
}
