namespace AulaWindowsForm1;

partial class Form1
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
        components = new System.ComponentModel.Container();
        this.button1 = new System.Windows.Forms.Button();
        this.texte1 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(104, 84);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(97, 41);
        this.button1.TabIndex = 0;
        this.button1.Text = "entrar";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        this.button1.Visible = true;
        // 
        // label1
        // 
        this.texte1.AutoSize = true;
        this.texte1.Location = new System.Drawing.Point(50, 150);
        this.texte1.Name = "texte1";
        this.texte1.Size = new System.Drawing.Size(38, 15);
        this.texte1.TabIndex = 1;
        this.texte1.Text = "usuario:";
        this.texte1.Click += new System.EventHandler(this.label1_Click);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(110, 147);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(100, 23);
        this.textBox1.TabIndex = 2;
        this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.texte1);
        this.Controls.Add(this.button1);
        this.Name = "Form1";
        Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.BackColor = System.Drawing.Color.White;
        this.ForeColor = System.Drawing.Color.Black;
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.textBox2.Location = new System.Drawing.Point(110, 178);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(100, 23);
        this.textBox2.TabIndex = 2;
        this.textBox2.Visible = true;
        this.textBox2.PasswordChar = '@';
        this.Controls.Add(this.textBox2);
        this.label1 = new System.Windows.Forms.Label();
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(55, 178);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(38, 15);
        this.label1.TabIndex = 1;
        this.label1.Text = "senha: ";
        this.Controls.Add(this.label1);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label texte1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
}
