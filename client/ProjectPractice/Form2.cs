using System.Diagnostics;
using System.Net;
using System.Text.Json;
using System.Windows.Forms;

namespace ProjectPractice;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private async void Form2_Load(object sender, EventArgs e)
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
}