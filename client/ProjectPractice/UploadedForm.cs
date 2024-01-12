using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json;

namespace ProjectPractice;

public partial class UploadedForm : Form
{
    Form mainForm;

    public UploadedForm()
    {
        InitializeComponent();
    }

    public UploadedForm(Form mainForm)
    {
        InitializeComponent();
        this.mainForm = mainForm;
        UploadPicture();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        UploadPicture();
    }

    private void UploadPicture()
    {
        if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            foreach (string fileName in openFileDialog1.FileNames)
            {
                pictureBox1.Image = Image
                    .FromFile(fileName)
                    .Resize(pictureBox1.Width, pictureBox1.Height);
                using (WebClient client = new WebClient())
                {
                    var res = client.UploadFile("http://localhost:8000/upload", fileName);
                    var rawJson = System.Text.Encoding.Default.GetString(res);
                    var data = JsonSerializer.Deserialize<DTO>(rawJson);
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox1.Text = data?.ToString() ?? "Error";

                }
            }
        }
    }

    public void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        mainForm.Show();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }
}