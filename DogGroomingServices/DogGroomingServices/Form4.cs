namespace DogGroomingServices
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Label studentLabel = new Label();
            studentLabel.Text = "(c) Prosperous, 1234567";
            studentLabel.Font = new Font("Rockwell", 9F);
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(10, ClientSize.Height - 30);
            Controls.Add(studentLabel);

            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Size", "Size");
            dataGridView1.Columns.Add("Services", "Services");
            dataGridView1.Columns.Add("HairType", "Hair Type");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Telephone", "Telephone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("ID", "ID");

            fromDatePicker.Value = DateTime.Today.AddMonths(-1);
            toDatePicker.Value = DateTime.Today;
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            LoadData(null, fromDatePicker.Value, toDatePicker.Value);
        }

        private void showSpecificButton_Click(object sender, EventArgs e)
        {
            LoadData(specificDatePicker.Value, null, null);
        }

        private void LoadData(DateTime? specific, DateTime? from, DateTime? to)
        {
            dataGridView1.Rows.Clear();
            double grandTotal = 0;
            string path = @"c:\mydata\OrderInfo.txt";
            if (!File.Exists(path)) return;

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split('|');
                if (parts.Length != 9) continue;

                if (!DateTime.TryParse(parts[0], out DateTime orderDate)) continue;

                bool match = specific.HasValue ? orderDate.Date == specific.Value.Date 
                             : from.HasValue && to.HasValue ? orderDate.Date >= from.Value.Date && orderDate.Date <= to.Value.Date 
                             : true;

                if (match)
                {
                    dataGridView1.Rows.Add(parts);
                    if (double.TryParse(parts[4], out double itemTotal)) grandTotal += itemTotal;
                }
            }
            totalSalesText.Text = grandTotal.ToString("F2");
        }
    }
}