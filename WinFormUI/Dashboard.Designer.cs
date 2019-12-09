namespace WinFormUI
{
  partial class Dashboard
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.messageBoxDemoButton = new System.Windows.Forms.Button();
      this.textBoxDemoButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.subtotalTextBox = new System.Windows.Forms.TextBox();
      this.totalTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // messageBoxDemoButton
      // 
      this.messageBoxDemoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.messageBoxDemoButton.Location = new System.Drawing.Point(68, 248);
      this.messageBoxDemoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.messageBoxDemoButton.Name = "messageBoxDemoButton";
      this.messageBoxDemoButton.Size = new System.Drawing.Size(244, 105);
      this.messageBoxDemoButton.TabIndex = 0;
      this.messageBoxDemoButton.Text = "MessageBox Demo";
      this.messageBoxDemoButton.UseVisualStyleBackColor = true;
      this.messageBoxDemoButton.Click += new System.EventHandler(this.messageBoxDemoButton_Click);
      // 
      // textBoxDemoButton
      // 
      this.textBoxDemoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxDemoButton.Location = new System.Drawing.Point(388, 248);
      this.textBoxDemoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxDemoButton.Name = "textBoxDemoButton";
      this.textBoxDemoButton.Size = new System.Drawing.Size(244, 105);
      this.textBoxDemoButton.TabIndex = 1;
      this.textBoxDemoButton.Text = "TextBox Demo";
      this.textBoxDemoButton.UseVisualStyleBackColor = true;
      this.textBoxDemoButton.Click += new System.EventHandler(this.textBoxDemoButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(384, 63);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 21);
      this.label1.TabIndex = 2;
      this.label1.Text = "Subtotal";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(384, 140);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 21);
      this.label2.TabIndex = 3;
      this.label2.Text = "Total";
      // 
      // subtotalTextBox
      // 
      this.subtotalTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.subtotalTextBox.Location = new System.Drawing.Point(388, 98);
      this.subtotalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.subtotalTextBox.Name = "subtotalTextBox";
      this.subtotalTextBox.Size = new System.Drawing.Size(244, 29);
      this.subtotalTextBox.TabIndex = 4;
      // 
      // totalTextBox
      // 
      this.totalTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.totalTextBox.Location = new System.Drawing.Point(388, 166);
      this.totalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.totalTextBox.Name = "totalTextBox";
      this.totalTextBox.Size = new System.Drawing.Size(244, 29);
      this.totalTextBox.TabIndex = 5;
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(695, 397);
      this.Controls.Add(this.totalTextBox);
      this.Controls.Add(this.subtotalTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxDemoButton);
      this.Controls.Add(this.messageBoxDemoButton);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Dashboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Delegate Demo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button messageBoxDemoButton;
    private System.Windows.Forms.Button textBoxDemoButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox subtotalTextBox;
    private System.Windows.Forms.TextBox totalTextBox;
  }
}

