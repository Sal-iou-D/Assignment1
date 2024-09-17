namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            summarizeButton = new Button();
            clearButton = new Button();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            hoursWorkedLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            hoursWorkedTextBox = new TextBox();
            displayTextLabel = new Label();
            SuspendLayout();
            // 
            // summarizeButton
            // 
            summarizeButton.Location = new Point(45, 160);
            summarizeButton.Name = "summarizeButton";
            summarizeButton.Size = new Size(112, 34);
            summarizeButton.TabIndex = 10;
            summarizeButton.TabStop = false;
            summarizeButton.Text = "&Summarize";
            summarizeButton.UseVisualStyleBackColor = true;
            summarizeButton.Click += summarizeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(181, 160);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 11;
            clearButton.TabStop = false;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(45, 47);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 25);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "&First Name";
            
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(319, 47);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "&Last Name";

            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.AutoSize = true;
            hoursWorkedLabel.Location = new Point(578, 47);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new Size(127, 25);
            hoursWorkedLabel.TabIndex = 4;
            hoursWorkedLabel.Text = "&Hours Worked";
            
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(45, 75);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.ShortcutsEnabled = false;
            firstNameTextBox.Size = new Size(195, 31);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.Tag = "";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(319, 75);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(195, 31);
            lastNameTextBox.TabIndex = 3;
           
            // 
            // hoursWorkedTextBox
            // 
            hoursWorkedTextBox.Location = new Point(578, 75);
            hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            hoursWorkedTextBox.Size = new Size(195, 31);
            hoursWorkedTextBox.TabIndex = 5;
            // 
            // displayTextLabel
            // 
            displayTextLabel.BorderStyle = BorderStyle.FixedSingle;
            displayTextLabel.Location = new Point(45, 236);
            displayTextLabel.Name = "displayTextLabel";
            displayTextLabel.Size = new Size(728, 170);
            displayTextLabel.TabIndex = 11;
            displayTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(818, 464);
            Controls.Add(displayTextLabel);
            Controls.Add(hoursWorkedTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(hoursWorkedLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(clearButton);
            Controls.Add(summarizeButton);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assignment1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button summarizeButton;
        private Button clearButton;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label hoursWorkedLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox hoursWorkedTextBox;
        private Label displayTextLabel;
    }
}
