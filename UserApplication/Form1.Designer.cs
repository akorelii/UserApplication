namespace UserApplication
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
            dataGridView1 = new DataGridView();
            kullaniciAdi = new DataGridViewTextBoxColumn();
            parola = new DataGridViewTextBoxColumn();
            hesapOlusturmaTarihi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            usernameTextBox = new TextBox();
            parolaTextBox = new TextBox();
            label2 = new Label();
            addUserButton = new Button();
            goToTestFormButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kullaniciAdi, parola, hesapOlusturmaTarihi });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 214);
            dataGridView1.TabIndex = 0;
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.HeaderText = "Kullanici Adi";
            kullaniciAdi.MinimumWidth = 6;
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Width = 200;
            // 
            // parola
            // 
            parola.HeaderText = "Parola";
            parola.MinimumWidth = 6;
            parola.Name = "parola";
            parola.Width = 200;
            // 
            // hesapOlusturmaTarihi
            // 
            hesapOlusturmaTarihi.HeaderText = "Hesap Olusturma Tarihi";
            hesapOlusturmaTarihi.MinimumWidth = 6;
            hesapOlusturmaTarihi.Name = "hesapOlusturmaTarihi";
            hesapOlusturmaTarihi.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 217);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "Kullanici Adi";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(12, 240);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(729, 27);
            usernameTextBox.TabIndex = 2;
            // 
            // parolaTextBox
            // 
            parolaTextBox.BorderStyle = BorderStyle.FixedSingle;
            parolaTextBox.Location = new Point(12, 308);
            parolaTextBox.Name = "parolaTextBox";
            parolaTextBox.Size = new Size(729, 27);
            parolaTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 285);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Parola";
            // 
            // addUserButton
            // 
            addUserButton.BackColor = SystemColors.ActiveBorder;
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.Location = new Point(12, 360);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(729, 47);
            addUserButton.TabIndex = 5;
            addUserButton.Text = "Kullaniciyi Sisteme Ekle";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // goToTestFormButton
            // 
            goToTestFormButton.BackColor = SystemColors.ActiveBorder;
            goToTestFormButton.FlatStyle = FlatStyle.Flat;
            goToTestFormButton.Location = new Point(12, 413);
            goToTestFormButton.Name = "goToTestFormButton";
            goToTestFormButton.Size = new Size(729, 47);
            goToTestFormButton.TabIndex = 6;
            goToTestFormButton.Text = "Kullanici Test Formuna Git";
            goToTestFormButton.UseVisualStyleBackColor = false;
            goToTestFormButton.Click += goToTestFormButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 465);
            Controls.Add(goToTestFormButton);
            Controls.Add(addUserButton);
            Controls.Add(parolaTextBox);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanici Ekleme Formu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kullaniciAdi;
        private DataGridViewTextBoxColumn parola;
        private DataGridViewTextBoxColumn hesapOlusturmaTarihi;
        private Label label1;
        private TextBox usernameTextBox;
        private TextBox parolaTextBox;
        private Label label2;
        private Button addUserButton;
        private Button goToTestFormButton;
    }
}
