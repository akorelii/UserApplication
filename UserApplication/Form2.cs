using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void goToUserCreationForm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();
        }

        private void testUserButton_Click(object sender, EventArgs e)
        {
            int usernamelineFound = 0;
            int passwordLineFound = 0;

            bool isUsernameCorrect = false;
            bool isPasswordCorrect = false;

            string username = usernameTextBox.Text;
            string password = parolaTextBox.Text;

            for (int i = 0; i < Form1.userIndex; i++)
            {
                if(username == Form1.usernames[i])
                {
                    usernamelineFound = i;
                    isUsernameCorrect = true;
                    break;
                }
            }

            for (int i = 0; i < Form1.userIndex; i++)
            {
                if (password == Form1.passwords[i])
                {
                    passwordLineFound = i;
                    isPasswordCorrect = true;
                    break;
                }
            }

            if(isUsernameCorrect && isPasswordCorrect)
            {
                if (usernamelineFound == passwordLineFound)
                {
                    richTextBox1.Text = "Kullanici Sistemde Tanimlidir.";
                    MessageBox.Show("Kullanici Sistemde Tanimlidir.");
                }else
                {
                    richTextBox1.Text = "Kullanici Sistemde Tanimli Değildir.";
                    MessageBox.Show("Kullanici Sistemde Tanimli Değildir.");
                }
            } else
            {
                richTextBox1.Text = "Kullanici Sistemde Tanimli Değildir.";
                MessageBox.Show("Kullanici Sistemde Tanimli Değildir.");
            }


        }
    }
}
