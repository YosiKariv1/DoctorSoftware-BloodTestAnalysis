using IronXL;
using System.IO;

namespace DoctorSoftware
{
    static class DataBase
    {
        public static int counter = 2;
        public static string path = "DataBase _ Users.xlsx";
        public static WorkBook workbook = WorkBook.Load(path);
        public static WorkSheet sheet = workbook.WorkSheets.First();
        public static string userName = "";
        public static int chack = 0;

        public static bool Login(string username, string password, string id)
        {
            bool user = false, pass = false, d = false;

            for (int i = 1; i <= sheet.Rows.Count(); i++)
            {
                if (username == sheet["A" + i].Value.ToString())
                    user = true;

                if (password == sheet["B" + i].Value.ToString())
                    pass = true;

                if (id == sheet["C" + i].Value.ToString())
                    d = true;

                if(user && pass && d)
                {
                    return true;
                }
            }

            if(user == false)
            {
                MessageBox.Show("User Name  Incorrect", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            if(pass == false)
            {
                MessageBox.Show("Password  Incorrect", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            if(d == false)
            {
                MessageBox.Show("ID Incorrect", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static void Register(string username, string password, string id)
        {
            counter = int.Parse(sheet["D2"].Value.ToString()) + 1;
            sheet["D2"].Value = counter.ToString();
            sheet["A" + counter].Value = username;
            sheet["B" + counter].Value = password;
            sheet["C" + counter].Value = id;
            workbook.SaveAs(path);

        }

        public static void SaveMeeting(string[] data, string id, string[] nameData, List<string> diseases, List<string> recommendation)
        {

            WorkSheet newSheet = workbook.CreateWorkSheet(id);
            var rowFirstLine = newSheet[$"A{1}:U{1}"].ToList();
            var rowSecondLine = newSheet[$"A{2}:R{2}"].ToList();

            for (int i = 0; i < data.Length; i++)
            {
                rowFirstLine[i].Text = nameData[i];
                rowSecondLine[i].Text = data[i];
            }

            var ColomnsDiseases = newSheet[$"P{2}:P{diseases.Count + 1}"].ToList();
            var ColomnsRecommendation = newSheet[$"Q{2}:Q{recommendation.Count + 1}"].ToList();

            newSheet[$"P{1}"].Value = "Diseases";
            newSheet[$"Q{1}"].Value = "Recommendation";

            for (int i = 0; i < diseases.Count; i++)
            {
                ColomnsDiseases[i].Text = diseases[i];
            }

            for (int i = 0; i < recommendation.Count; i++)
            {
                ColomnsRecommendation[i].Text = recommendation[i];
            }

            newSheet["A1:U1"].Style.Font.Bold = true;
            workbook.SaveAs(path);

        }

        public static RichTextBox SearchMeeting(string id, RichTextBox text)
        {
            if (workbook.GetWorkSheet(id) != null)
            {
                var cells = workbook.GetWorkSheet(id)[$"A{1}:O{1}"].ToList();
                var cells2 = workbook.GetWorkSheet(id)[$"A{2}:O{2}"].ToList();

                for (int i = 0; i < cells.Count; i++)
                {
                    text.SelectionFont = new Font(text.Font, FontStyle.Bold);
                    text.AppendText(cells[i].Text);
                    text.AppendText(" :  ");
                    text.SelectionFont = new Font(text.Font, FontStyle.Regular);
                    text.AppendText(cells2[i].Text);
                    text.AppendText("\n");
                }


                text.SelectionFont = new Font(text.Font, FontStyle.Bold);
                text.AppendText("Diseases :  ");
                var cells3 = workbook.GetWorkSheet(id).GetRange("P2:P" + workbook.GetWorkSheet(id).GetColumn("P").Count().ToString()).ToList();
                for (int i = 0; i < cells3.Count; i++)
                {
                    text.AppendText("\n");
                    text.AppendText(cells3[i].Value.ToString());

                }

                text.SelectionFont = new Font(text.Font, FontStyle.Bold);
                text.AppendText("recommendation :  ");
                var cells4 = workbook.GetWorkSheet(id).GetRange("Q2:Q" + workbook.GetWorkSheet(id).GetColumn("Q").Count().ToString()).ToList();
                for (int j = 0; j < cells4.Count; j++)
                {
                    text.AppendText("\n");
                    text.AppendText(cells4[j].Value.ToString());

                }
            }

            else
            {
                MessageBox.Show("There Is No Patient: " + " " + id, "Search Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text.Text = "";
            }

            return text;
        }
    }
}
