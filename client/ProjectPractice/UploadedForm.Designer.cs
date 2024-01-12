namespace ProjectPractice;

partial class UploadedForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadedForm));
        openFileDialog1 = new OpenFileDialog();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        richTextBox1 = new RichTextBox();
        pictureBox2 = new PictureBox();
        pictureBox3 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        openFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(269, 246);
        label1.Name = "label1";
        label1.Size = new Size(0, 20);
        label1.TabIndex = 1;
        label1.Click += label1_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(499, 182);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(158, 157);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // richTextBox1
        // 
        richTextBox1.BackColor = Color.White;
        richTextBox1.BorderStyle = BorderStyle.None;
        richTextBox1.Location = new Point(407, 406);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(356, 140);
        richTextBox1.TabIndex = 4;
        richTextBox1.Text = "";
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = SystemColors.ControlLightLight;
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(468, 552);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(224, 56);
        pictureBox2.TabIndex = 5;
        pictureBox2.TabStop = false;
        pictureBox2.Click += button2_Click;
        // 
        // pictureBox3
        // 
        pictureBox3.BackColor = SystemColors.ControlLightLight;
        pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
        pictureBox3.InitialImage = null;
        pictureBox3.Location = new Point(467, 614);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(232, 53);
        pictureBox3.TabIndex = 6;
        pictureBox3.TabStop = false;
        pictureBox3.Click += button1_Click;
        // 
        // UploadedForm
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        ClientSize = new Size(1134, 679);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox2);
        Controls.Add(richTextBox1);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        Name = "UploadedForm";
        Text = "Detector";
        FormClosed += Form1_FormClosed;
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private OpenFileDialog openFileDialog1;
    private Label label1;
    private PictureBox pictureBox1;
    private RichTextBox richTextBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
}