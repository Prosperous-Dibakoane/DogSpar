namespace DogGroomingServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label studentLabel = new Label();
            studentLabel.Text = "(c) Prosperous Dibakoane, 1234567";
            studentLabel.Font = new Font("Rockwell", 9F);
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(561, 457);
            this.Controls.Add(studentLabel);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void extractDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}