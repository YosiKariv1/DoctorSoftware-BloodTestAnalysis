
namespace DoctorSoftware
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            login_bt.Parent = login_pic;
            register_bt.Parent = login_pic;
            exit_bt.Parent = login_pic;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            if (user_tb.Text == "" || password_tb.Text == "" || id_tb.Text == "")
            {
                MessageBox.Show("All Fields Must Be Filled", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (user_tb.Text != "" && password_tb.Text != "" && id_tb.Text != "")
            {
                try
                {
                    if (DataBase.Login(user_tb.Text, password_tb.Text, id_tb.Text))
                    {
                        MessageBox.Show("You Connected", "Login success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        (new Menu()).Show();
                        Program.LoginPageClosed = true;
                        Close();
                    }
                }
                catch (TypeInitializationException)
                {
                    MessageBox.Show("The File Is Open And Must Be Closed", "IOException Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
        }
        private void register_bt_Click(object sender, EventArgs e)
        {
            Hide();
            (new Register(this)).ShowDialog();
        }

        private void login_pic_Click(object sender, EventArgs e)
        {

        }
    }
}