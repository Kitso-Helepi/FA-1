namespace Question2_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nameBox = new TextBox();
            idBox = new TextBox();
            citizenBox = new ComboBox();
            validationButton = new Button();
            generateButton = new Button();
            displayBox = new ListBox();
            label2 = new Label();
            label3 = new Label();
            citiLabel = new Label();
            idLabel = new Label();
            nameLabel = new Label();
            validationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Salmon;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 620);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(653, 43);
            label1.Name = "label1";
            label1.Size = new Size(575, 41);
            label1.TabIndex = 1;
            label1.Text = "Home Affairs digital identity  Processor";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(928, 104);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(151, 27);
            nameBox.TabIndex = 2;
            // 
            // idBox
            // 
            idBox.Location = new Point(928, 169);
            idBox.Name = "idBox";
            idBox.Size = new Size(151, 27);
            idBox.TabIndex = 3;
            // 
            // citizenBox
            // 
            citizenBox.FormattingEnabled = true;
            citizenBox.Location = new Point(928, 220);
            citizenBox.Name = "citizenBox";
            citizenBox.Size = new Size(151, 28);
            citizenBox.TabIndex = 4;
            // 
            // validationButton
            // 
            validationButton.Location = new Point(963, 276);
            validationButton.Name = "validationButton";
            validationButton.Size = new Size(94, 29);
            validationButton.TabIndex = 5;
            validationButton.Text = "ValidateID";
            validationButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(985, 550);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(131, 29);
            generateButton.TabIndex = 6;
            generateButton.Text = "Generate Profile";
            generateButton.UseVisualStyleBackColor = true;
            // 
            // displayBox
            // 
            displayBox.FormattingEnabled = true;
            displayBox.Location = new Point(880, 403);
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(299, 124);
            displayBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 8);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // citiLabel
            // 
            citiLabel.AutoSize = true;
            citiLabel.Location = new Point(710, 223);
            citiLabel.Name = "citiLabel";
            citiLabel.Size = new Size(84, 20);
            citiLabel.TabIndex = 10;
            citiLabel.Text = "Citizenship:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(710, 169);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(65, 20);
            idLabel.TabIndex = 11;
            idLabel.Text = "Enter ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(710, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(90, 20);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Enter Name:";
            nameLabel.Click += Label6_Click;
            // 
            // validationLabel
            // 
            validationLabel.AutoSize = true;
            validationLabel.Location = new Point(959, 342);
            validationLabel.Name = "validationLabel";
            validationLabel.Size = new Size(0, 20);
            validationLabel.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1814, 623);
            Controls.Add(validationLabel);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Controls.Add(citiLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(displayBox);
            Controls.Add(generateButton);
            Controls.Add(validationButton);
            Controls.Add(citizenBox);
            Controls.Add(idBox);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox nameBox;
        private TextBox idBox;
        private ComboBox citizenBox;
        private Button validationButton;
        private Button generateButton;
        private ListBox displayBox;
        private Label label2;
        private Label label3;
        private Label citiLabel;
        private Label idLabel;
        private Label nameLabel;
        private Label validationLabel;
    }
}
