namespace DogGroomingServices
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new DataGridView();
            this.extractButton = new Button();
            this.totalSalesText = new TextBox();
            this.label1 = new Label();
            this.fromDatePicker = new DateTimePicker();
            this.toDatePicker = new DateTimePicker();
            this.label2 = new Label();
            this.label3 = new Label();
            this.specificDatePicker = new DateTimePicker();
            this.showSpecificButton = new Button();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            this.SuspendLayout();
            // dataGridView1
            this.dataGridView1.Location = new Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(776, 300);
            this.dataGridView1.TabIndex = 0;
            // extractButton
            this.extractButton.Location = new Point(12, 350);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new Size(150, 40);
            this.extractButton.TabIndex = 1;
            this.extractButton.Text = "Extract Data";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += extractButton_Click;
            // totalSalesText
            this.totalSalesText.Enabled = false;
            this.totalSalesText.Location = new Point(200, 400);
            this.totalSalesText.Name = "totalSalesText";
            this.totalSalesText.Size = new Size(150, 31);
            this.totalSalesText.TabIndex = 2;
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Sales: R";
            // fromDatePicker
            this.fromDatePicker.Location = new Point(200, 350);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new Size(200, 31);
            this.fromDatePicker.TabIndex = 4;
            // toDatePicker
            this.toDatePicker.Location = new Point(450, 350);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new Size(200, 31);
            this.toDatePicker.TabIndex = 5;
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(170, 355);
            this.label2.Name = "label2";
            this.label2.Size = new Size(24, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new Point(420, 355);
            this.label3.Name = "label3";
            this.label3.Size = new Size(20, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "To:";
            // specificDatePicker
            this.specificDatePicker.Location = new Point(200, 450);
            this.specificDatePicker.Name = "specificDatePicker";
            this.specificDatePicker.Size = new Size(200, 31);
            this.specificDatePicker.TabIndex = 8;
            // showSpecificButton
            this.showSpecificButton.Location = new Point(450, 450);
            this.showSpecificButton.Name = "showSpecificButton";
            this.showSpecificButton.Size = new Size(200, 40);
            this.showSpecificButton.TabIndex = 10;
            this.showSpecificButton.Text = "Show for Specific Date";
            this.showSpecificButton.UseVisualStyleBackColor = true;
            this.showSpecificButton.Click += showSpecificButton_Click;
            // Form4
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 500);
            this.Controls.Add(this.showSpecificButton);
            this.Controls.Add(this.specificDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalSalesText);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Extract Data";
            this.Load += Form4_Load;
            ((ISupportInitialize)this.dataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private DataGridView dataGridView1;
        private Button extractButton;
        private TextBox totalSalesText;
        private Label label1;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private Label label2;
        private Label label3;
        private DateTimePicker specificDatePicker;
        private Button showSpecificButton;
    }
}