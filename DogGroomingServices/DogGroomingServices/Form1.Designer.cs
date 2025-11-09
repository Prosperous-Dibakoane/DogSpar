namespace DogGroomingServices
{
    partial class Form1
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
            this.pictureBox1 = new PictureBox();
            this.label2 = new Label();
            this.menuStrip1 = new MenuStrip();
            this.aboutToolStripMenuItem = new ToolStripMenuItem();
            this.optionsToolStripMenuItem = new ToolStripMenuItem();
            this.extractDataToolStripMenuItem = new ToolStripMenuItem();
            this.descriptionLabel = new Label();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // pictureBox1
            this.pictureBox1.Image = Properties.Resources.dog1;  // Add your image to Resources
            this.pictureBox1.Location = new Point(436, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(346, 306);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(32, 123);
            this.label2.Name = "label2";
            this.label2.Size = new Size(308, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOGGY GROOMING SERVICES WELCOMES YOU....";
            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.aboutToolStripMenuItem, this.optionsToolStripMenuItem, this.extractDataToolStripMenuItem });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(830, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // aboutToolStripMenuItem
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // optionsToolStripMenuItem
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // extractDataToolStripMenuItem
            this.extractDataToolStripMenuItem.Name = "extractDataToolStripMenuItem";
            this.extractDataToolStripMenuItem.Size = new Size(120, 29);
            this.extractDataToolStripMenuItem.Text = "Extract Data";
            this.extractDataToolStripMenuItem.Click += extractDataToolStripMenuItem_Click;
            // descriptionLabel
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new Point(32, 160);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new Size(400, 100);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Book grooming services for your dog. Select size, hair type, services, date, and more.";
            // Form1
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(255, 192, 192);
            this.ClientSize = new Size(830, 491);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Dog Grooming Services";
            this.Load += Form1_Load;
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private PictureBox pictureBox1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem extractDataToolStripMenuItem;
        private Label descriptionLabel;
    }
}