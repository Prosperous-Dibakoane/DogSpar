namespace DogGroomingServices
{
    partial class Form3
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
            this.nameText = new TextBox();
            this.telText = new TextBox();
            this.emailText = new TextBox();
            this.idText = new TextBox();
            this.saveButton = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.selectedInfoLabel = new Label();
            this.SuspendLayout();
            // nameText
            this.nameText.Location = new Point(150, 50);
            this.nameText.Name = "nameText";
            this.nameText.Size = new Size(200, 31);
            this.nameText.TabIndex = 0;
            // telText
            this.telText.Location = new Point(150, 100);
            this.telText.Name = "telText";
            this.telText.Size = new Size(200, 31);
            this.telText.TabIndex = 1;
            // emailText
            this.emailText.Location = new Point(150, 150);
            this.emailText.Name = "emailText";
            this.emailText.Size = new Size(200, 31);
            this.emailText.TabIndex = 2;
            // idText
            this.idText.Location = new Point(150, 200);
            this.idText.Name = "idText";
            this.idText.Size = new Size(200, 31);
            this.idText.TabIndex = 3;
            // saveButton
            this.saveButton.Location = new Point(150, 300);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new Size(200, 40);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += saveButton_Click;
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new Size(60, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new Size(90, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telephone:";
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new Point(50, 155);
            this.label3.Name = "label3";
            this.label3.Size = new Size(60, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new Point(50, 205);
            this.label4.Name = "label4";
            this.label4.Size = new Size(35, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID:";
            // selectedInfoLabel
            this.selectedInfoLabel.AutoSize = true;
            this.selectedInfoLabel.Location = new Point(400, 50);
            this.selectedInfoLabel.Name = "selectedInfoLabel";
            this.selectedInfoLabel.Size = new Size(300, 200);
            this.selectedInfoLabel.TabIndex = 9;
            // Form3
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.selectedInfoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.nameText);
            this.Name = "Form3";
            this.Text = "Customer Info";
            this.Load += Form3_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox nameText;
        private TextBox telText;
        private TextBox emailText;
        private TextBox idText;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label selectedInfoLabel;
    }
}