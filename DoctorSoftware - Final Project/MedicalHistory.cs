using IronXL;

namespace DoctorSoftware
{
    public partial class MadicalHistory : Form
    {
        public MadicalHistory()
        {
            InitializeComponent();
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            historyshow.Text = "";
            historyshow = DataBase.SearchMeeting(searce_tb.Text, historyshow);
        }

        private void MadicalHistory_Load(object sender, EventArgs e)
        {
            search_bt.Parent = medicalHistory_pic;
            exit_bt.Parent = medicalHistory_pic;
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void medicalHistory_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
