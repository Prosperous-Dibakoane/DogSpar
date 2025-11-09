namespace DogGroomingServices
{
    partial class AboutBox1
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
            this.tableLayoutPanel = new TableLayoutPanel();
            this.logoPictureBox = new PictureBox();
            this.labelProductName = new Label();
            this.labelVersion = new Label();
            this.labelCopyright = new Label();
            this.labelCompanyName = new Label();
            this.textBoxDescription = new TextBox();
            this.okButton = new Button();
            this.servicesLabel = new Label();
            this.tableLayoutPanel.SuspendLayout();
            ((ISupportInitialize)this.logoPictureBox).BeginInit();
            this.SuspendLayout();
            // tableLayoutPanel
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = DockStyle.Fill;
            this.tableLayoutPanel.Location = new Point(15, 17);
            this.tableLayoutPanel.Margin = new Padding(5, 6, 5, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new Size(695, 510);
            this.tableLayoutPanel.TabIndex = 0;
            // logoPictureBox
            this.logoPictureBox.Dock = DockStyle.Fill;
            this.logoPictureBox.Image = Properties.Resources.dog1;
            this.logoPictureBox.Location = new Point(5, 6);
            this.logoPictureBox.Margin = new Padding(5, 6, 5, 6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new Size(219, 498);
            this.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // labelProductName
            this.labelProductName.Dock = DockStyle.Fill;
            this.labelProductName.Location = new Point(239, 0);
            this.labelProductName.Margin = new Padding(10, 0, 5, 0);
            this.labelProductName.MaximumSize = new Size(0, 33);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new Size(451, 33);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Doggy Parlour Booking System";
            this.labelProductName.TextAlign = ContentAlignment.MiddleLeft;
            // labelVersion
            this.labelVersion.Dock = DockStyle.Fill;
            this.labelVersion.Location = new Point(239, 51);
            this.labelVersion.Margin = new Padding(10, 0, 5, 0);
            this.labelVersion.MaximumSize = new Size(0, 33);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new Size(451, 33);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version 1.0";
            this.labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            // labelCopyright
            this.labelCopyright.Dock = DockStyle.Fill;
            this.labelCopyright.Location = new Point(239, 102);
            this.labelCopyright.Margin = new Padding(10, 0, 5, 0);
            this.labelCopyright.MaximumSize = new Size(0, 33);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new Size(451, 33);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright © 2025";
            this.labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
            // labelCompanyName
            this.labelCompanyName.Dock = DockStyle.Fill;
            this.labelCompanyName.Location = new Point(239, 153);
            this.labelCompanyName.Margin = new Padding(10, 0, 5, 0);
            this.labelCompanyName.MaximumSize = new Size(0, 33);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new Size(451, 33);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Pet Grooming Services Inc.";
            this.labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // textBoxDescription
            this.textBoxDescription.Dock = DockStyle.Fill;
            this.textBoxDescription.Location = new Point(239, 210);
            this.textBoxDescription.Margin = new Padding(10, 6, 5, 6);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = ScrollBars.Both;
            this.textBoxDescription.Size = new Size(451, 243);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "System for booking dog grooming services.";
            // okButton
            this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.okButton.DialogResult = DialogResult.Cancel;
            this.okButton.Location = new Point(565, 465);
            this.okButton.Margin = new Padding(5, 6, 5, 6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new Size(125, 39);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += okButton_Click;
            // servicesLabel
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Location = new Point(239, 270);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new Size(451, 100);
            this.servicesLabel.TabIndex = 25;
            this.servicesLabel.Text = "Services include: Bathing, Brushing, Nail trimming, Ear cleaning, Blow drying, Fur styling, Tick and flea removal, Skin and coat assessment.";
            // AboutBox1
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(725, 544);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Margin = new Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new Padding(15, 17, 15, 17);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "About Doggy Parlour";
            this.Load += AboutBox1_Load;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((ISupportInitialize)this.logoPictureBox).EndInit();
            this.ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox logoPictureBox;
        private Label labelProductName;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompanyName;
        private TextBox textBoxDescription;
        private Button okButton;
        private Label servicesLabel;
    }
}