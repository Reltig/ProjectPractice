namespace ProjectPractice;

partial class Form2 : Form
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
        label1 = new Label();
        button2 = new Button();
        listBox1 = new ListBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(269, 246);
        label1.Name = "label1";
        label1.Size = new Size(0, 20);
        label1.TabIndex = 1;
        // 
        // button2
        // 
        button2.Location = new Point(343, 407);
        button2.Name = "button2";
        button2.Size = new Size(143, 28);
        button2.TabIndex = 3;
        button2.Text = "Home";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 19;
        listBox1.Location = new Point(214, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(410, 384);
        listBox1.TabIndex = 4;
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(listBox1);
        Controls.Add(button2);
        Controls.Add(label1);
        Name = "Form2";
        Text = "History";
        Load += Form2_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private Button button2;
    private ListBox listBox1;
}