namespace UserApplication
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            parolaTextBox = new TextBox();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label1 = new Label();
            testUserButton = new Button();
            goToUserCreationForm = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(538, 120);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // parolaTextBox
            // 
            parolaTextBox.BorderStyle = BorderStyle.FixedSingle;
            parolaTextBox.Location = new Point(12, 223);
            parolaTextBox.Name = "parolaTextBox";
            parolaTextBox.Size = new Size(514, 27);
            parolaTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 200);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Parola";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(12, 155);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(514, 27);
            usernameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "Kullanici Adi";
            // 
            // testUserButton
            // 
            testUserButton.BackColor = SystemColors.ActiveBorder;
            testUserButton.FlatStyle = FlatStyle.Flat;
            testUserButton.Location = new Point(12, 276);
            testUserButton.Name = "testUserButton";
            testUserButton.Size = new Size(514, 49);
            testUserButton.TabIndex = 9;
            testUserButton.Text = "Kullaniciyi Test Et";
            testUserButton.UseVisualStyleBackColor = false;
            testUserButton.Click += testUserButton_Click;
            // 
            // goToUserCreationForm
            // 
            goToUserCreationForm.BackColor = SystemColors.ActiveBorder;
            goToUserCreationForm.FlatStyle = FlatStyle.Flat;
            goToUserCreationForm.Location = new Point(12, 331);
            goToUserCreationForm.Name = "goToUserCreationForm";
            goToUserCreationForm.Size = new Size(514, 49);
            goToUserCreationForm.TabIndex = 10;
            goToUserCreationForm.Text = "Kullaniciyi Olusturma Formuna Git";
            goToUserCreationForm.UseVisualStyleBackColor = false;
            goToUserCreationForm.Click += goToUserCreationForm_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 404);
            Controls.Add(goToUserCreationForm);
            Controls.Add(testUserButton);
            Controls.Add(parolaTextBox);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanici Test Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox parolaTextBox;
        private Label label2;
        private TextBox usernameTextBox;
        private Label label1;
        private Button testUserButton;
        private Button goToUserCreationForm;
    }
}