namespace ProjectPractice;

partial class MainForm : Form
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = SystemColors.ControlLightLight;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(468, 552);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(226, 49);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        pictureBox1.Click += upload_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = SystemColors.ControlLightLight;
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(468, 619);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(226, 44);
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        pictureBox2.Click += button2_Click_1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        ClientSize = new Size(1134, 685);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Name = "MainForm";
        Text = "Main";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
}