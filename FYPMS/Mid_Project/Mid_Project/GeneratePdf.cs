using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Mid_Project
{
    public partial class GeneratePdf : Form
    {
        public GeneratePdf()
        {
            InitializeComponent();
        }
        public void show_students()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select S.Id,S.RegistrationNo,P.FirstName,P.LastName,P.Contact,P.Email,P.DateOfBirth,L.value Gender From Student S Join Person P On S.Id = P.Id Join Lookup L On P.gender = L.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.AllowUserToAddRows = false;
            
        }
        
        public void show_marks()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select P.FirstName,P.LastName,G1.GroupId,P3.Title,E.Name EvaluationName,G1.ObtainedMarks,E.TotalMarks EvaluationMarks,E.TotalWeightage EvaluationWeightage From GroupEvaluation G1 Join Evaluation E On G1.EvaluationId = E.Id Join GroupStudent G2 On G1.GroupId = G2.GroupId Join Student S On S.Id = G2.StudentId Join Person P on S.Id = P.Id Join GroupProject G3 On G2.GroupId = G3.GroupId Join Project P3 On G3.ProjectId = P3.Id where G2.Status = 3 Group By P.FirstName,P.LastName,G1.GroupId,P3.Title,E.Name,G1.ObtainedMarks,E.TotalMarks,E.TotalWeightage",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.AllowUserToAddRows = false;
        }
        public void show_advisors()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select A.Id,L1.Value Designation,A.Salary,P.FirstName,P.LastName,P.Contact,P.Email,P.DateOfBirth,L.Value Gender From Advisor A Join Person P On A.Id = P.Id Join Lookup L On P.gender = L.Id Join Lookup L1 On A.Designation = L1.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.AllowUserToAddRows = false;
        }
        public void show_evaluations()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Evaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.AllowUserToAddRows = false;
        }
        public void show_projectwadvisor()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select P1.Id,P1.Title,P1.Description,P2.FirstName + P2.LastName AdvisorName,L.Value Role From ProjectAdvisor p JOIN Project p1 on p.ProjectId = p1.Id Join Lookup L On P.AdvisorRole = L.Id Join Person P2 On P.AdvisorId = P2.Id Group By P1.Id,P1.Title,P1.Description,L.Value ,P2.FirstName + P2.LastName ",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.AllowUserToAddRows = false;
        }
        private void iconButton8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv.Visible = true;
                show_marks();
                ExportToPDF(dgv);
                MainUI_Form f = new MainUI_Form();
                f.Show();
                this.Hide();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GeneratePdf f = new GeneratePdf();
                f.Show();
                this.Hide();
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainUI_Form f = new MainUI_Form();
                f.Show();
                this.Hide();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv.Visible = true;
                show_students();
                ExportToPDF(dgv);
                MainUI_Form f = new MainUI_Form();
                f.Show();
                this.Hide();
            }
           
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv.Visible = true;
                show_advisors();
                ExportToPDF(dgv);
                MainUI_Form f = new MainUI_Form();
                f.Show();
                this.Hide();
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv.Visible = true;
                show_projectwadvisor();
                ExportToPDF(dgv);
                MainUI_Form f = new MainUI_Form();
                f.Show();
                this.Hide();
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv.Visible = true;
                show_evaluations();
                ExportToPDF(dgv);
                MainUI_Form f = new MainUI_Form();
                f.Show();
                this.Hide();
            }
            }
            private void ExportToPDF(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
            saveFileDialog.Title = "Export to PDF";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                document.Open();

                PdfPTable pdfTable = new PdfPTable(dataGridView.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                document.Add(pdfTable);

                document.Close();

                MessageBox.Show("PDF file has been created!");
            }
        }
    }
}
