using System;                    
using System.Drawing;            
using System.Windows.Forms;
using HomeAffairsDigitalIdentityProcessor;

namespace Question2_B
{
    public partial class Form1 : Form
    {
        private CitizenProfile? currentProfile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (citizenBox.Items.Count > 0)
                citizenBox.SelectedIndex = 0;
        }

        private void validationButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Please enter an ID number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentProfile = new CitizenProfile(
                nameBox.Text!.Trim(),
                idBox.Text!.Trim(),
                citizenBox.SelectedItem!.ToString()!
            );

            validationLabel.Text = currentProfile.ValidationResult;

            if (currentProfile.ValidationResult.StartsWith("Valid"))
            {
                validationLabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                validationLabel.ForeColor = Color.Red;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (currentProfile == null)
            {
                MessageBox.Show("Please validate the ID first before generating a profile.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string summary = currentProfile.GenerateProfileSummary();

            displayBox.Items.Clear();
            string[] lines = summary.Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                displayBox.Items.Add(line);
            }
        }
    }
}

