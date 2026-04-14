namespace Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string input = textInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a programming language.");

            }
            if (display.Items.Contains(input))
            {
                MessageBox.Show("This programming language is already in the list.");
            }
            else
            {
                display.Items.Add(input);
                statusLabel.Text = $"Added:{input} at {DateTime.Now:dd/MM/yyy HH:mm:ss}";
                textInput.Clear();

            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (display.SelectedItem == null)
            {
                MessageBox.Show("Please select a programming language to remove.");
                
            }
            string removedItem = display.SelectedItem.ToString();
            display.Items.Remove(removedItem);
            statusLabel.Text = $"Removed: {removedItem} on {DateTime.Now: dd/MM/yyyy HH:mm:ss}";
        }
    }
}
