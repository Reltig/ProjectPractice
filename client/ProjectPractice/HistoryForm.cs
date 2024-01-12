using System.Diagnostics;
using System.Net;
using System.Text.Json;
using System.Windows.Forms;

namespace ProjectPractice;

public partial class HistoryForm : Form
{
    private Form mainForm;
    public HistoryForm()
    {
        InitializeComponent();
    }

    public HistoryForm(Form mainForm)
    {
        this.mainForm = mainForm;
        InitializeComponent();
    }

    private void HistoryFrom_Loaded(object sender, EventArgs e)
    {
        var request = HttpWebRequest.Create("http://localhost:8000/history");
        request.Method = "GET";
        var test = String.Empty;
        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        {
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            test = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
        }
        var data = JsonSerializer.Deserialize<DTOHistory[]>(test);
        listBox1.Items.AddRange(data);
    }

    private void HistoryForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        mainForm.Show();
    }

    private void return_Btn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var listbox = (ListBox)sender;
        //listbox.Items.Add(listbox.SelectedItem);
    }
}