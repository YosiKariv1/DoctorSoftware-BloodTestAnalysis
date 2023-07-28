using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorSoftware
{
    public partial class DiagnosticForm : Form
    {
        List<string> diseases;
        List<string> recommendation;

        public DiagnosticForm(List<string> diseases, List<string> recommendation)
        {
            InitializeComponent();
            this.diseases = diseases;
            this.recommendation = recommendation;
        }

        private void DiagnosticForm_Load(object sender, EventArgs e)
        {
            exit_bt.Parent = diagnostic_pic;
            for (int i = 0; i < diseases.Count; i++)
            {
                richTextBox1.Text += "- " + diseases[i] + "\n";
            }
            for (int i = 0; i < recommendation.Count; i++)
            {
                richTextBox2.Text += "- " + recommendation[i] + "\n";
            }
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
