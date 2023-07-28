using IronXL;


namespace DoctorSoftware
{
    public partial class NewPatient : Form
    {
        string fileName;
        WorkBook workbook;
        WorkSheet workSheet;
        TextBox[] bloodResult;
        string[] personalData;
        string[] NameData;
        Patient patient;

        public NewPatient()
        {
            InitializeComponent();
        }
        private void NewPatient_Load(object sender, EventArgs e)
        {
            import_bt.Parent = newPatient_pic;
            done_bt.Parent = newPatient_pic;
            exit_bt.Parent = newPatient_pic;
            NameData = new string[] { "First Name", "Last Name", "ID", "Age", "WBC", "Neut", "Lymph", "RBC", "HCT", "Urea", "Hb", "Crtn", "Iron", "HDL", "AP", "Diagnosis", "Recommendation" };
            bloodResult = new TextBox[] { wbc_tb, neut_tb, lymph_tb, rbc_tb, hct_tb, urea_tb, hb_tb, crtn_tb, iron_tb, hdl_tb, ap_tb };
        }
        private void done_bt_Click(object sender, EventArgs e)
        {
            if(int.Parse(age_tb.Text) > 0) 
            {
                personalData = new string[] { name_tb.Text, lastname_tb.Text, id_tb.Text, age_tb.Text, wbc_tb.Text,
                    neut_tb.Text, lymph_tb.Text, rbc_tb.Text, hct_tb.Text, urea_tb.Text + "%", hb_tb.Text + "%", 
                    crtn_tb.Text + "%", iron_tb.Text + "%", hdl_tb.Text + "%", ap_tb.Text };
                Hide();
                patient = new Patient(name_tb.Text, lastname_tb.Text, id_tb.Text, sex_cb.Text, int.Parse(age_tb.Text),
                    int.Parse(wbc_tb.Text), int.Parse(neut_tb.Text), int.Parse(lymph_tb.Text), float.Parse(rbc_tb.Text), int.Parse(hct_tb.Text),
                    int.Parse(urea_tb.Text), float.Parse(hb_tb.Text),
                    float.Parse(crtn_tb.Text), int.Parse(iron_tb.Text), int.Parse(hdl_tb.Text), int.Parse(ap_tb.Text),
                    fever.Checked, medicionSensivity.Checked, smoker.Checked, mizrahi.Checked, pregnent.Checked, ethiopian.Checked, dav.Checked);

                DataBase.SaveMeeting(personalData, id_tb.Text, NameData, patient.diseases, patient.recommendation);
                (new DiagnosticForm(patient.diseases, patient.recommendation)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Age Must Be Above Zero, Please Try Again", "Patient Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                age_tb.Text = "";
            }
        }

        private void import_bt_Click(object sender, EventArgs e)
        {
            importFile();
        }
        private void importFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                workbook = WorkBook.Load(fileName);
                workSheet = workbook.DefaultWorkSheet;
                var cells = workSheet[$"A{2}:K{2}"].ToList();

                for (int i = 0; i < cells.Count; i++)
                {
                    bloodResult[i].Text = cells[i].ToString();
                }
            }
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}
