namespace ProjectPractice;

partial class HistoryForm : Form
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
        listBox1 = new ListBox();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 19;
        listBox1.Location = new Point(423, 135);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(298, 99);
        listBox1.TabIndex = 0;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(472, 615);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(224, 44);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        pictureBox1.Click += return_Btn_Click;
        // 
        // HistoryForm
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        ClientSize = new Size(1134, 685);
        Controls.Add(pictureBox1);
        Controls.Add(listBox1);
        Name = "HistoryForm";
        Text = "History";
        FormClosed += HistoryForm_FormClosed;
        Load += HistoryFrom_Loaded;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBox1;
    private PictureBox pictureBox1;
}