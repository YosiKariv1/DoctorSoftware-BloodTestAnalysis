

using System.Text.RegularExpressions;

namespace DoctorSoftware
{
    public partial class Register : Form
    {
        Login loginPage;
        public Register(Login loginPage)
        {
            this.loginPage = loginPage;
            InitializeComponent();

        }
        private void RegisterPage_Load(object sender, EventArgs e)
        {
            login_bt.Parent = register_pic;
            register_bt.Parent = register_pic;
            exit_bt.Parent = register_pic;
        }

        private void register_bt_Click(object sender, EventArgs e)
        {
            if (fieldsCheck() && UsernamePassRangeCheck() && usernameDigitCheck(user_tb.Text) && usernameLetterCheck(user_tb.Text) && equalPasswords() && passwordFinalCheck(password_tb.Text))
            {
                loginPage.Visible = true;
                Close();
                DataBase.Register(user_tb.Text, password_tb.Text, id_tb.Text);
                MessageBox.Show("done", "", MessageBoxButtons.OK);
            }
        }

        private bool UsernamePassRangeCheck()
        {
            if (user_tb.Text.Length < 6 || user_tb.Text.Length > 8)
            {
                MessageBox.Show("Username has to contain 6-8 characters.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                user_tb.Text = "";
                user_tb.Focus();
                return false;
            }
            if (password_tb.Text.Length < 8 || password_tb.Text.Length > 10)
            {
                MessageBox.Show("Password has to contain 8-10 characters.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_tb.Text = "";
                passwordAgain_tb.Text = "";
                password_tb.Focus();
                return false;
            }
            return true;
        }

        //Returns true if Username contains maximum 2 digits. Otherwise false.
        private bool usernameDigitCheck(string username)
        {
            int digit = 0;

            foreach (char x in user_tb.Text)
            {
                if (char.IsDigit(x))
                {
                    digit++;
                }
            }
            if (digit > 2)
            {
                MessageBox.Show("Username has to contain maximum 2 numbers.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                user_tb.Text = "";
                return false;
            }
            return true;
        }

        //Returns true if Password contains atleast 1 digit. Otherwise false.
        private bool passwordDigitCheck(string password)
        {
            foreach (char x in password)
            {
                if (char.IsDigit(x))
                {
                    return true;
                }
            }
            MessageBox.Show("Password has to contain atleast 1 number.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            password_tb.Text = "";
            passwordAgain_tb.Text = "";
            return false;
        }

        //Returns true if Password contains atleast 1 special character.
        private bool hasSpecialChars(string password)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (password.Contains(item)) return true;
            }
            MessageBox.Show("Password has to contain atleast 1 special character.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            password_tb.Text = "";
            passwordAgain_tb.Text = "";
            password_tb.Focus();
            return false;
        }

        //Returns true if the Username contains only letters and numbers.
        private bool usernameLetterCheck(string username)
        {
            foreach (char x in username)
            {
                if (!char.IsLetterOrDigit(x))
                {

                    MessageBox.Show("Username has to contain only English letters in addition to maximum 2 digits.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user_tb.Text = "";
                    return false;
                }
            }
            return true;
        }

        //Returns true if the Password contains atleast 1 letter.
        private bool passLetterCheck(string password)
        {
            foreach (char x in password)
            {
                if (char.IsLetter(x))
                {
                    return true;
                }
            }
            return false;
        }

        //Returns true if the password has atleast 1 letter, 1 special char and 1 digit.
        private bool passwordFinalCheck(string password)
        {
            if (passwordDigitCheck(password) && hasSpecialChars(password) && passLetterCheck(password))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password has to contain atleast 1 English letter, 1 special char and 1 digit.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_tb.Text = "";
                passwordAgain_tb.Text = "";
                return false;
            }
        }

        //Returns true if Username and Password fields are not empty. Otherwise false.
        private bool fieldsCheck()
        {
            if (user_tb.Text == "" || passwordAgain_tb.Text == "" || password_tb.Text == "")
            {
                MessageBox.Show("Username / Password fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_tb.Text = "";
                user_tb.Text = "";
                passwordAgain_tb.Text = "";
                return false;
            }
            return true;
        }

        //Returns true if the Password equals to the Confirmed Password. Otherwise false.
        private bool equalPasswords()
        {
            if (passwordAgain_tb.Text == password_tb.Text)
            {
                return true;
            }
            MessageBox.Show("Passwords does not match, please re-enter it properly", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            password_tb.Text = "";
            passwordAgain_tb.Text = "";
            return false;
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            loginPage.Visible = true;
            Close();
        }

        private void register_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
