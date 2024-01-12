using System.Diagnostics;
using System.Net;
using System.Text.Json;
using System.Windows.Forms;

namespace ProjectPractice;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void upload_Click(object sender, EventArgs e)
    {
        var form = new UploadedForm(this);
        Hide();
        form.ShowDialog();
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
        var form = new HistoryForm(this);
        Hide();
        form.ShowDialog();
    }
}