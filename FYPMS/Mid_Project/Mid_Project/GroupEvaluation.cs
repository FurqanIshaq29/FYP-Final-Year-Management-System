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
    public partial class GroupEvaluation : Form
    {
        public GroupEvaluation()
        {
            InitializeComponent();
        }
        int groupid;
        int evaluationid;
        int marks;
        int uid;
        bool flag = true;
        public void showevaluation()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Evaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_evaluation.DataSource = dt;
            dgv_evaluation.AllowUserToAddRows = false;
        }
        public void showgroups()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select G.Id GroupId,P.Id ProjectId,P.title ProjectTitle from Project P Join ProjectAdvisor P1 On P.Id = P1.ProjectId Join GroupProject G1 On P.Id = G1.ProjectId Join dbo.[Group] G On G1.GroupId = G.Id Group By G.Id,P.Id,P.title", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_groups.DataSource = dt;
            dgv_groups.AllowUserToAddRows = false;
        }
        public void showgroup_evaluation()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select G.GroupId,G.EvaluationId,G.ObtainedMarks,E.TotalMarks from GroupEvaluation G Join Evaluation E on G.EvaluationId = E.Id";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            group_evaluation.DataSource = dt;
            group_evaluation.AllowUserToAddRows = false;

        }
        private void home_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GroupEvaluation f = new GroupEvaluation();
                f.Show();
                this.Hide();
            }
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

        private void mark_evaluations_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Click on the row of groups and click on the row of evaluation table to start marking....!");
                button1.Text = "Mark";
                flag = true;
                group_evaluation.Visible = false;
                dgv_evaluation.Visible = true;
                dgv_groups.Visible = true;
                showevaluation();
                showgroups();
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query2 = "Select EvaluationId From GroupEvaluation  where EvaluationId = @id and GroupId = @gid";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@id", evaluationid);
            cmd2.Parameters.AddWithValue("@gid", groupid);
            int id = Convert.ToInt32(cmd2.ExecuteScalar());
            if (id == evaluationid)
            {
                MessageBox.Show("This Evaluation already done... Choose another one ...!");
            }
            else
            {
                button2.Visible = false;
                flag = false;
                MessageBox.Show("Group Id and Evaluation Id selected and now enter the obtained marks");
                tableLayoutPanel3.Visible = true;
                button1.Visible = true;
            }
        }

        private void dgv_groups_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == true)
            {
                groupid = int.Parse(dgv_groups.CurrentRow.Cells[0].Value.ToString());
            }
            
        }

        private void dgv_evaluation_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == true)
            {
                evaluationid = int.Parse(dgv_evaluation.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Mark")
            {
                bool check = true;
                if (marks_tbox.TextLength > 0)
                {
                    var con = Configuration.getInstance().getConnection();
                    string query3 = "Select TotalMarks From Evaluation  where Id = @id";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.Parameters.AddWithValue("@id", evaluationid);
                    int marks = Convert.ToInt32(cmd3.ExecuteScalar());
                    if (marks < int.Parse(marks_tbox.Text))
                    {
                        check = false;
                        MessageBox.Show("Obtained Marks should be Less than Total Marks....");
                    }
                    if (check == true)
                    {
                        string query = "Insert into dbo.[GroupEvaluation] (GroupId,EvaluationId,ObtainedMarks,EvaluationDate)  Values (@GroupId,@EvaluationId,@Marks,@Date)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@GroupId", groupid);
                        cmd.Parameters.AddWithValue("@EvaluationId", evaluationid);
                        cmd.Parameters.AddWithValue("@Marks", int.Parse(marks_tbox.Text));
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Evaluation Marked successfully....!");
                        GroupEvaluation f = new GroupEvaluation();
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Marks");
                }
            }
            if (button1.Text == "UPDATE")
            {
                if (marks_tbox.TextLength > 0)
                {
                    var con = Configuration.getInstance().getConnection();
                    string query3 = "Select TotalMarks From Evaluation  where Id = @id";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.Parameters.AddWithValue("@id", uid);
                    int marks = Convert.ToInt32(cmd3.ExecuteScalar());
                    if (marks < int.Parse(marks_tbox.Text))
                    {

                        MessageBox.Show("Obtained Marks should be Less than Total Marks....");
                    }
                    else
                    {
                        var con1 = Configuration.getInstance().getConnection();
                        string query = "UPDATE GroupEvaluation SET ObtainedMarks = @Marks where EvaluationId = @id";
                        SqlCommand cmd = new SqlCommand(query, con1);
                        cmd.Parameters.AddWithValue("@id", uid);
                        cmd.Parameters.AddWithValue("@Marks", int.Parse(marks_tbox.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Marks Updated Successfully... Click on Ok to Continue.");
                        GroupEvaluation f = new GroupEvaluation();
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Marks...!");
                }
            }
        }
        private void edit_evaluation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Click on the row of groups and click on the row of evaluation table to update marking....!");
                button2.Visible = false;
                button1.Visible = true;
                tableLayoutPanel3.Visible = true;
                group_evaluation.Visible = true;
                dgv_groups.Visible = false;
                dgv_evaluation.Visible = false;
                button1.Text = "UPDATE";
                showgroup_evaluation();
            }
        }

        private void group_evaluation_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (button1.Text == "UPDATE")
            {
                marks = int.Parse(group_evaluation.CurrentRow.Cells[2].Value.ToString());
                uid = int.Parse(group_evaluation.CurrentRow.Cells[1].Value.ToString());
                marks_tbox.Text = marks.ToString();
            }
        }
    }
}
