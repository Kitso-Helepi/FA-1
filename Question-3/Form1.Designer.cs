namespace Question_3
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
            panel1 = new Panel();
            textInput = new TextBox();
            label2 = new Label();
            statusLabel = new Label();
            removeButton = new Button();
            addButton = new Button();
            display = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textInput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(statusLabel);
            panel1.Controls.Add(removeButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(display);
            panel1.Location = new Point(75, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 403);
            panel1.TabIndex = 0;
            // 
            // textInput
            // 
            textInput.Location = new Point(32, 246);
            textInput.Name = "textInput";
            textInput.Size = new Size(336, 27);
            textInput.TabIndex = 5;
            textInput.PlaceholderText = "Enter your favorite programming language";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 28);
            label2.Name = "label2";
            label2.Size = new Size(338, 38);
            label2.TabIndex = 4;
            label2.Text = "My Favorite Programme";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(182, 352);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(50, 20);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "";
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Red;
            removeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeButton.ForeColor = SystemColors.Control;
            removeButton.Location = new Point(217, 312);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(151, 37);
            removeButton.TabIndex = 2;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += RemoveButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.DodgerBlue;
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.Control;
            addButton.Location = new Point(32, 312);
            addButton.Name = "addButton";
            addButton.Size = new Size(164, 37);
            addButton.TabIndex = 1;
            addButton.Text = "Add Language";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // display
            // 
            display.FormattingEnabled = true;
            display.Location = new Point(32, 69);
            display.Name = "display";
            display.Size = new Size(466, 124);
            display.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox display;
        private Button addButton;
        private Button removeButton;
        private Label label2;
        private Label statusLabel;
        private TextBox textInput;
    }
}
