namespace UserApplication
{
    public partial class Form1 : Form
    {
        public static string[] usernames = new string[128];
        public static string[] passwords = new string[128];
        public static int userIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = parolaTextBox.Text;

            dataGridView1.Rows.Add(username, password, DateTime.Now);

            usernames[userIndex] = username;
            passwords[userIndex] = password;

            userIndex++;


            MessageBox.Show($"Kullanici sisteme basariyla eklendi.[Kullanici No: {userIndex.ToString()}]", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void goToTestFormButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            /* show form2 */
            form2.Show();

            /* hide this form */
            this.Hide();
        }
    }
}
