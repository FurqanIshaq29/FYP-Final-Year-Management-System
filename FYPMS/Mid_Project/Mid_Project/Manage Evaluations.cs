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

namespace Mid_Project
{
    public partial class Manage_Evaluations : Form
    {
        public Manage_Evaluations()
        {
            InitializeComponent();
        }
        
        public void showdata()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Evaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_evaluation.DataSource = dt;
            dgv_evaluation.AllowUserToAddRows = false;
        }
        private void home_button_Click(object sender, EventArgs e)
        {
            Manage_Evaluations f = new Manage_Evaluations();
            f.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainUI_Form f = new MainUI_Form();
                f.Show();
                this.Hide();
            }
        }

        private void addevaluation_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv_evaluation.Visible = true;
                panel1.Visible = true;
                tableLayoutPanel1.Visible = true;
                button1.Visible = true;
                Search.Visible = false;
                Search_tbox.Visible = false;
                button1.Text = "Insert";
                button1.ForeColor = Color.Red;
                name_tbox.Text = null;
                marks_cbox.Text = null;
                weightage_cbox.Text = null;
                showdata();
            }
        }

        private void updateevaluation_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show(string.Format("Click on the row of Data Grid View You want to Update"), "Confirmation", MessageBoxButtons.OK) == DialogResult.OK)
                {

                    dgv_evaluation.Visible = true;
                    panel1.Visible = true;
                    tableLayoutPanel1.Visible = true;
                    button1.Visible = true;
                    Search.Visible = false;
                    Search_tbox.Visible = false;
                    button1.Text = "Update";
                    button1.ForeColor = Color.Yellow;
                    showdata();
                }
            }
        }

        private void searchevaluation_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                panel1.Visible = true;
                tableLayoutPanel1.Visible = false;
                Search.Visible = true;
                Search_tbox.Visible = true;
                button1.Visible = false;
                dgv_evaluation.Visible = true;
                showdata();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Insert")
            {
                
                if (name_tbox.Text.Length > 0 && marks_cbox.SelectedItem != null && weightage_cbox.SelectedItem != null)
                {
                    var con = Configuration.getInstance().getConnection();
                    string query = "Select Name from Evaluation where Name = @param";
                    SqlCommand commandtocheckregno = new SqlCommand(query, con);
                    commandtocheckregno.Parameters.AddWithValue("@param", name_tbox.Text);
                    string check = (string)commandtocheckregno.ExecuteScalar();
                    if (check == name_tbox.Text)
                    {
                        MessageBox.Show("Evaluation Name already present there");
                    }
                    else
                    {
                        string query2 = "Select SUM(TotalWeightage) From evaluation";
                        SqlCommand commandtocheckweightage = new SqlCommand(query2, con);
                        int checkmarks = Convert.ToInt32(commandtocheckweightage.ExecuteScalar());
                        if (checkmarks + int.Parse(weightage_cbox.Text) > 100)
                        {

                            MessageBox.Show("Evaluation exceeding the Percentage....");
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("Insert into Evaluation values (@Name, @TotalMarks,@TotalWeightage)", con);
                            cmd.Parameters.AddWithValue("@Name", name_tbox.Text);
                            cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(marks_cbox.Text));
                            cmd.Parameters.AddWithValue("@TotalWeightage", int.Parse(weightage_cbox.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show(" Evaluation for Project created SuccessFully");
                            showdata();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }

            }
            if (button1.Text == "Update")
            {
                if (name_tbox.Text.Length > 0 && marks_cbox.SelectedItem != null && weightage_cbox.SelectedItem != null)
                {
                    var con = Configuration.getInstance().getConnection();
                    string query2 = "Select SUM(TotalWeightage) From evaluation";
                    SqlCommand commandtocheckweightage = new SqlCommand(query2, con);
                    int checkmarks = Convert.ToInt32(commandtocheckweightage.ExecuteScalar());
                    if (checkmarks + int.Parse(weightage_cbox.Text) > 100)
                    {

                        MessageBox.Show("Evaluation exceeding the Percentage....");
                    }
                    else
                    {
                        string query = "Update  Evaluation Set Name = @Name,TotalMarks = @TotalMarks,TotalWeightage = @TotalWeightage Where Id = @Id";
                        
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", int.Parse(dgv_evaluation.CurrentRow.Cells[0].Value.ToString()));
                        cmd.Parameters.AddWithValue("@Name", name_tbox.Text);
                        cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(marks_cbox.Text));
                        cmd.Parameters.AddWithValue("@TotalWeightage", int.Parse(weightage_cbox.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Successfully Updated. You can check the data grid view");
                        showdata();
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all the Fields...");
                }
            }
        }
            
            
        

        private void dgv_evaluation_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (button1.Text == "Update")
            {
                name_tbox.Text = dgv_evaluation.CurrentRow.Cells[1].Value.ToString();
                marks_cbox.Text = dgv_evaluation.CurrentRow.Cells[2].Value.ToString();
                weightage_cbox.Text = dgv_evaluation.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void Search_tbox_TextChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select Id,Name,TotalMarks,TotalWeightage from Evaluation   where Id Like '%' +@param + '%' Or Name Like '%' +@param + '%' Or TotalMarks Like '%' +@param + '%' Or TotalWeightage Like '%'+@param +'%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@param", Search_tbox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_evaluation.DataSource = dt;
        }
    }
}
