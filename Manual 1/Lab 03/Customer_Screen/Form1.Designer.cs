namespace Customer_Screen
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
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            chkReading = new CheckBox();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            label4 = new Label();
            chkPainting = new CheckBox();
            radioMarried = new RadioButton();
            radioUnmarried = new RadioButton();
            btnPreview = new Button();
            Gender = new GroupBox();
            groupBox1 = new GroupBox();
            Gender.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 54);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bangladesh", "United State", "Japan" });
            comboBox1.Location = new Point(267, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 122);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Country";
            label2.Click += label2_Click;
            // 
            // chkReading
            // 
            chkReading.AutoSize = true;
            chkReading.Location = new Point(267, 246);
            chkReading.Name = "chkReading";
            chkReading.Size = new Size(86, 24);
            chkReading.TabIndex = 4;
            chkReading.Text = "Reading";
            chkReading.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(129, 0);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(63, 24);
            radioMale.TabIndex = 6;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(242, 0);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(78, 24);
            radioFemale.TabIndex = 7;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 246);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Hobbies";
            // 
            // chkPainting
            // 
            chkPainting.AutoSize = true;
            chkPainting.Location = new Point(381, 246);
            chkPainting.Name = "chkPainting";
            chkPainting.Size = new Size(84, 24);
            chkPainting.TabIndex = 9;
            chkPainting.Text = "Painting";
            chkPainting.UseVisualStyleBackColor = true;
            // 
            // radioMarried
            // 
            radioMarried.AutoSize = true;
            radioMarried.Location = new Point(129, 0);
            radioMarried.Name = "radioMarried";
            radioMarried.Size = new Size(82, 24);
            radioMarried.TabIndex = 11;
            radioMarried.TabStop = true;
            radioMarried.Text = "Married";
            radioMarried.UseVisualStyleBackColor = true;
            // 
            // radioUnmarried
            // 
            radioUnmarried.AutoSize = true;
            radioUnmarried.Location = new Point(243, 0);
            radioUnmarried.Name = "radioUnmarried";
            radioUnmarried.Size = new Size(100, 24);
            radioUnmarried.TabIndex = 12;
            radioUnmarried.TabStop = true;
            radioUnmarried.Text = "Unmarried";
            radioUnmarried.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(246, 374);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(190, 38);
            btnPreview.TabIndex = 13;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            Gender.Controls.Add(radioMale);
            Gender.Controls.Add(radioFemale);
            Gender.Location = new Point(138, 176);
            Gender.Name = "Gender";
            Gender.Size = new Size(363, 41);
            Gender.TabIndex = 14;
            Gender.TabStop = false;
            Gender.Text = "Gender";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioMarried);
            groupBox1.Controls.Add(radioUnmarried);
            groupBox1.Location = new Point(138, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 50);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(Gender);
            Controls.Add(btnPreview);
            Controls.Add(chkPainting);
            Controls.Add(label4);
            Controls.Add(chkReading);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Customer Data Entry Screen";
            Load += Form1_Load;
            Gender.ResumeLayout(false);
            Gender.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private CheckBox chkReading;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private Label label4;
        private CheckBox chkPainting;
        private RadioButton radioMarried;
        private RadioButton radioUnmarried;
        private Button btnPreview;
        private GroupBox Gender;
        private GroupBox groupBox1;
    }
}