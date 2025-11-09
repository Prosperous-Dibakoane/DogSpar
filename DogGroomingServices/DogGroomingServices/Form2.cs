namespace DogGroomingServices
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MaxDate = DateTime.Today.AddMonths(1);

            Label studentLabel = new Label();
            studentLabel.Text = "(c) Prosperous Dibakoane, 1234567";
            studentLabel.Font = new Font("Rockwell", 9F);
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(497, 628);
            this.Controls.Add(studentLabel);

            UpdateTotal();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTextBox.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(UpdateTotal));
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private double ExtractPrice(string text)
        {
            Match match = Regex.Match(text, @"R(\d+)");
            return match.Success ? double.Parse(match.Groups[1].Value) : 0;
        }

        private void UpdateTotal()
        {
            double total = 0;
            foreach (string item in checkedListBox1.CheckedItems)
            {
                total += ExtractPrice(item);
            }
            RadioButton selectedRadio = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (selectedRadio != null)
            {
                total += ExtractPrice(selectedRadio.Text);
            }
            textBox1.Text = total.ToString("F2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateTextBox.Text))
            {
                MessageBox.Show("Please select a date from the calendar.");
                return;
            }
            string dateSelected = dateTextBox.Text;
            string totalItem = textBox1.Text;
            string radioItem = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? "";
            string checkboxItems = string.Join(",", checkedListBox1.CheckedItems.Cast<string>());
            string comboItem = comboBox1.SelectedItem?.ToString() ?? "";
            new Form3(dateSelected, radioItem, checkboxItems, comboItem, totalItem).Show();
        }
    }
}