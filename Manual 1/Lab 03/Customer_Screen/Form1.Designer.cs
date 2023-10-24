namespace Customer_Screen
{
    partial class frmCustomerPreview
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
            lblName = new TextBox();
            lblCountry = new ComboBox();
            label2 = new Label();
            chkReading = new CheckBox();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            chkPainting = new CheckBox();
            radioMarried = new RadioButton();
            radioUnmarried = new RadioButton();
            btnPreview = new Button();
            lblGender = new GroupBox();
            lblStatus = new GroupBox();
            lblHobby = new GroupBox();
            lblGender.SuspendLayout();
            lblStatus.SuspendLayout();
            lblHobby.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 55);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name :";
            label1.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.Location = new Point(267, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(191, 27);
            lblName.TabIndex = 1;
            // 
            // lblCountry
            // 
            lblCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            lblCountry.FormattingEnabled = true;
            lblCountry.Items.AddRange(new object[] { "Bangladesh", "United State", "Japan" });
            lblCountry.Location = new Point(267, 127);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(191, 28);
            lblCountry.TabIndex = 2;
            lblCountry.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 130);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Country";
            label2.Click += label2_Click;
            // 
            // chkReading
            // 
            chkReading.AutoSize = true;
            chkReading.Location = new Point(139, 0);
            chkReading.Name = "chkReading";
            chkReading.Size = new Size(86, 24);
            chkReading.TabIndex = 4;
            chkReading.Text = "Reading";
            chkReading.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(139, 0);
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
            radioFemale.Location = new Point(273, 0);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(78, 24);
            radioFemale.TabIndex = 7;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            radioFemale.CheckedChanged += radioFemale_CheckedChanged;
            // 
            // chkPainting
            // 
            chkPainting.AutoSize = true;
            chkPainting.Location = new Point(273, 0);
            chkPainting.Name = "chkPainting";
            chkPainting.Size = new Size(84, 24);
            chkPainting.TabIndex = 9;
            chkPainting.Text = "Painting";
            chkPainting.UseVisualStyleBackColor = true;
            // 
            // radioMarried
            // 
            radioMarried.AutoSize = true;
            radioMarried.Location = new Point(139, 0);
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
            radioUnmarried.Location = new Point(273, 0);
            radioUnmarried.Name = "radioUnmarried";
            radioUnmarried.Size = new Size(100, 24);
            radioUnmarried.TabIndex = 12;
            radioUnmarried.TabStop = true;
            radioUnmarried.Text = "Unmarried";
            radioUnmarried.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(228, 461);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(190, 38);
            btnPreview.TabIndex = 13;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // lblGender
            // 
            lblGender.Controls.Add(radioMale);
            lblGender.Controls.Add(radioFemale);
            lblGender.Location = new Point(128, 201);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(373, 41);
            lblGender.TabIndex = 14;
            lblGender.TabStop = false;
            lblGender.Text = "Gender";
            // 
            // lblStatus
            // 
            lblStatus.Controls.Add(radioMarried);
            lblStatus.Controls.Add(radioUnmarried);
            lblStatus.Location = new Point(128, 366);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(373, 50);
            lblStatus.TabIndex = 15;
            lblStatus.TabStop = false;
            lblStatus.Text = "Status";
            // 
            // lblHobby
            // 
            lblHobby.Controls.Add(chkReading);
            lblHobby.Controls.Add(chkPainting);
            lblHobby.Location = new Point(128, 286);
            lblHobby.Name = "lblHobby";
            lblHobby.Size = new Size(373, 45);
            lblHobby.TabIndex = 16;
            lblHobby.TabStop = false;
            lblHobby.Text = "Hobbies";
            lblHobby.Enter += groupBox2_Enter;
            // 
            // frmCustomerPreview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 572);
            Controls.Add(lblHobby);
            Controls.Add(lblStatus);
            Controls.Add(lblGender);
            Controls.Add(btnPreview);
            Controls.Add(label2);
            Controls.Add(lblCountry);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "frmCustomerPreview";
            Text = "Customer Data Entry Screen";
            Load += Form1_Load;
            lblGender.ResumeLayout(false);
            lblGender.PerformLayout();
            lblStatus.ResumeLayout(false);
            lblStatus.PerformLayout();
            lblHobby.ResumeLayout(false);
            lblHobby.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lblName;
        private ComboBox lblCountry;
        private Label label2;
        private CheckBox chkReading;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private CheckBox chkPainting;
        private RadioButton radioMarried;
        private RadioButton radioUnmarried;
        private Button btnPreview;
        private GroupBox lblGender;
        private GroupBox lblStatus;
        private GroupBox lblHobby;
    }
}