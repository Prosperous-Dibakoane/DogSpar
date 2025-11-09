namespace DogGroomingServices
{
    partial class Form2
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
            this.groupBox1 = new GroupBox();
            this.radioButton4 = new RadioButton();
            this.radioButton3 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.radioButton1 = new RadioButton();
            this.checkedListBox1 = new CheckedListBox();
            this.label2 = new Label();
            this.textBox1 = new TextBox();
            this.comboBox1 = new ComboBox();
            this.monthCalendar1 = new MonthCalendar();
            this.label3 = new Label();
            this.dateTextBox = new TextBox();
            this.button1 = new Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // groupBox1
            this.groupBox1.BackColor = Color.LightGray;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new Point(414, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(300, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size of dog";
            // radioButton4
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new Point(16, 157);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new Size(193, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Large (>25kg) R140";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += radioButton_CheckedChanged;
            // radioButton3
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new Point(16, 117);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new Size(273, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Medium (>11kg - 25kg) R130";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += radioButton_CheckedChanged;
            // radioButton2
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new Point(16, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(254, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Small (4.5kg - 11kg) R120";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // radioButton1
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new Point(16, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(194, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tiny (<4.5kg) R100";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // checkedListBox1
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] { "Bathing R30", "Brushing and combing R70", "Nail trimming R80", "Ear cleaning R30", "Blow drying R30", "Fur styling R90", "Tick and flea removal R90", "Skin and coat assessment R89" });
            this.checkedListBox1.Location = new Point(36, 70);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(329, 228);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(36, 587);
            this.label2.Name = "label2";
            this.label2.Size = new Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "TOTAL: R";
            // textBox1
            this.textBox1.Enabled = false;
            this.textBox1.Location = new Point(135, 588);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(140, 31);
            this.textBox1.TabIndex = 5;
            // comboBox1
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Short hair dog", "Long hair dog" });
            this.comboBox1.Location = new Point(36, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(319, 33);
            this.comboBox1.TabIndex = 6;
            // monthCalendar1
            this.monthCalendar1.Location = new Point(414, 366);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            this.label3.Location = new Point(34, 5);
            this.label3.Name = "label3";
            this.label3.Size = new Size(552, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please select your options from the following ...";
            // dateTextBox
            this.dateTextBox.Enabled = false;
            this.dateTextBox.Location = new Point(414, 320);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new Size(300, 31);
            this.dateTextBox.TabIndex = 9;
            // button1
            this.button1.Location = new Point(36, 520);
            this.button1.Name = "button1";
            this.button1.Size = new Size(329, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Next: Customer Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += button1_Click;
            // Form2
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Gainsboro;
            this.ClientSize = new Size(800, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Options";
            this.Load += Form2_Load;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private TextBox dateTextBox;
        private Button button1;
    }
}