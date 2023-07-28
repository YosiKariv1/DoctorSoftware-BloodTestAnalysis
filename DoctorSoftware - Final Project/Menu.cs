
namespace DoctorSoftware
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Text = DataBase.userName;
            np_bt.Parent = menu_pic;
            mh_bt.Parent = menu_pic;
            logout_bt.Parent = menu_pic;
            exit_bt.Parent = menu_pic;
        }

        private void np_bt_Click(object sender, EventArgs e)
        {
            (new NewPatient()).ShowDialog();
        }

        private void mh_bt_Click(object sender, EventArgs e)
        {
            (new MadicalHistory()).ShowDialog();
        }

        private void logout_bt_Click(object sender, EventArgs e)
        {
            Program.MenuClosed = true;
            Program.LoginPageClosed = false;
            (new Login()).Show();
            Close();
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
