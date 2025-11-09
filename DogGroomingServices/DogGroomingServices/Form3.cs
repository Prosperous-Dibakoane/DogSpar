namespace DoggyParlour_24020613
{
    // Prosperous Dibakoane, 24020613
    public partial class Form3 : Form
    {
        private string _date, _radio, _checkboxes, _combo, _total;

        public Form3(string date, string radio, string checkboxes, string combo, string total)
        {
            InitializeComponent();
            _date = date;
            _radio = radio;
            _checkboxes = checkboxes;
            _combo = combo;
            _total = total;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            nameText.Text = "Test Name";
            telText.Text = "0123456789";
            emailText.Text = "test@example.com";
            idText.Text = "9901011234567";

            selectedInfoLabel.Text = $"Date: {_date}\nSize: {_radio}\nServices: {_checkboxes}\nHair Type: {_combo}\nTotal: R{_total}";

            Label studentLabel = new Label();
            studentLabel.Text = "(c) Prosperous Dibakoane, 24020613";
            studentLabel.Font = new Font("Rockwell", 9F);
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(10, ClientSize.Height - 30);
            Controls.Add(studentLabel);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string line = $"{_date}|{_radio}|{_checkboxes}|{_combo}|{_total}|{nameText.Text}|{telText.Text}|{emailText.Text}|{idText.Text}";
            string dir = @"c:\mydata\";
            Directory.CreateDirectory(dir);
            File.AppendAllText(Path.Combine(dir, "OrderInfo.txt"), line + Environment.NewLine);
            MessageBox.Show("Order saved successfully.");
            Close();
        }

        private bool ValidateInputs()
        {
            if (nameText.Text.Length < 2 || !Regex.IsMatch(nameText.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Name must be at least 2 characters (a-Z, spaces).");
                return false;
            }
            if (!Regex.IsMatch(telText.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Telephone: 10 digits starting with 0.");
                return false;
            }
            if (!Regex.IsMatch(emailText.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                MessageBox.Show("Invalid email.");
                return false;
            }
            string id = idText.Text;
            if (!Regex.IsMatch(id, @"^\d{13}$"))
            {
                MessageBox.Show("ID: 13 digits.");
                return false;
            }
            if (!DateTime.TryParseExact(id.Substring(0, 6), "yyMMdd", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Invalid ID date (YYMMDD).");
                return false;
            }
            if (!IsLuhnValid(id))
            {
                MessageBox.Show("ID fails Luhn algorithm.");
                return false;
            }
            return true;
        }

        private bool IsLuhnValid(string number)
        {
            int sum = 0;
            bool alt = true;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int d = int.Parse(number[i].ToString());
                if (alt)
                {
                    d *= 2;
                    if (d > 9) d -= 9;
                }
                sum += d;
                alt = !alt;
            }
            return sum % 10 == 0;
        }
    }
}