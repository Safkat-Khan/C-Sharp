using static System.Net.Mime.MediaTypeNames;

namespace Form1
{
    partial class Form1 : Form1Base
    {
        private const string V = "Form1";

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Name = V;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox1;

        public AutoScaleMode AutoScaleMode { get; private set; }
        public Size ClientSize { get; private set; }
    }
}