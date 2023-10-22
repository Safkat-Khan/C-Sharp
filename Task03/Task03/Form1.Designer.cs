namespace Task03
{
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiplication = new Button();
            btnDivision = new Button();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(60, 116);
            txtNumber1.Margin = new Padding(4, 4, 4, 4);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(155, 31);
            txtNumber1.TabIndex = 0;
            txtNumber1.TextChanged += txtNumber1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(541, 116);
            txtNumber2.Margin = new Padding(4, 4, 4, 4);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(155, 31);
            txtNumber2.TabIndex = 1;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(192, 262);
            btnPlus.Margin = new Padding(4, 4, 4, 4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(118, 36);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(441, 264);
            btnMinus.Margin = new Padding(4, 4, 4, 4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(118, 36);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Location = new Point(708, 262);
            btnMultiplication.Margin = new Padding(4, 4, 4, 4);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(118, 36);
            btnMultiplication.TabIndex = 4;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(441, 344);
            btnDivision.Margin = new Padding(4, 4, 4, 4);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(118, 36);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplication);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiplication;
        private Button btnDivision;
    }
}