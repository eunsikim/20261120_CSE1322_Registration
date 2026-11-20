namespace _20261120_CSE1322_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void register_bt_Click_1(object sender, EventArgs e)
        {
            string email = email_tb.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;
            string firstName = textBox4.Text;
            string lastName = textBox5.Text;

            if (password != confirmPassword)
            {
                text_label.Text = "Passwords do not match!";
                return;
            }
            else if(password.Length < 8)
            {
                text_label.Text = "Password must be at least 8 characters long!";
                return;
            }

            bool contains_number = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '0' || password[i] == '1' || password[i] == '2' || password[i] == '3' || password[i] == '4' || password[i] == '5' || password[i] == '6' || password[i] == '7' || password[i] == '8' || password[i] == '9')
                {
                    contains_number = true;
                    return;
                }
            }

            bool contains_special = false; // !, @, or #

            for(int i = 0; i < password.Length; i++)
            {
                if (password[i] == '!' || password[i] == '@' || password[i] == '#')
                {
                    contains_special = true;
                    return;
                }
            }

            if(!contains_number)
            {
                text_label.Text = "Password must contain at least one number!";
                return;
            }
            else if (!contains_special)
            {
                text_label.Text = "Password must contain at least one special character (!, @, or #)!";
                return;
            }

            text_label.Text = "Welcome, " + firstName + " " + lastName + "!" + " Your Email is " + email + " and your passwor is " + password;
        }
    }
}
