namespace DogGroomingServices
{
    public partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {
            Label studentLabel = new Label();
            studentLabel.Text = "(c) Prosperous Dibakoane, 1234567";
            studentLabel.Font = new Font("Rockwell", 9F);
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(497, 500);
            this.Controls.Add(studentLabel);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}