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
    public partial class AssignProject_Group : Form
    {
        public AssignProject_Group()
        {
            InitializeComponent();
        }
        int cpid;
        int cgid;
        public void show_groups()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select * From dbo.[Group]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_groups.DataSource = dt;
            dgv_groups.AllowUserToAddRows = false;
        }
        public void show_projects()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select * From dbo.Project";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_project.DataSource = dt;
            dgv_project.AllowUserToAddRows = false;
        }
        private void dgv_project_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AssignProject_Group f = new AssignProject_Group();
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

        private void assignproject_button_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("1. Select the any row from Project table to select Project." +
                    "  2. Select the any row from groups table to select group." +
                    "  3. At end click on Assign Button..");
                show_groups();
                show_projects();
                tableLayoutPanel1.Visible = true;
                tableLayoutPanel2.Visible = true;
                dgv_groups.Visible = true;
                dgv_project.Visible = true;
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select ProjectId from GroupProject where ProjectId = @PId";
            string query2 = "Select GroupId from GroupProject where GroupId = @GId";
            SqlCommand commandtocheckpid = new SqlCommand(query, con);
            commandtocheckpid.Parameters.AddWithValue("@PId", cpid);
            int checkpid = Convert.ToInt32(commandtocheckpid.ExecuteScalar());
            SqlCommand commandtocheckgid = new SqlCommand(query2, con);
            commandtocheckgid.Parameters.AddWithValue("@GId", cgid);
            int checkgid = Convert.ToInt32(commandtocheckgid.ExecuteScalar());
            if (checkpid == cpid || checkgid == cgid)
            {

                MessageBox.Show("Project or Group already Assigned. Choose another one...!");
            }

            else
            {
                if (MessageBox.Show(string.Format(" Are you sure you want to select this group and project"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("Insert into GroupProject values (@ProjectId,@GroupId,@AssignmentDate)",con);
                    cmd.Parameters.AddWithValue("@ProjectId", cpid);
                    cmd.Parameters.AddWithValue("GroupId", cgid);
                    cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project Assigned to Group !");
                }
            }
        }

        private void dgv_project_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cpid = int.Parse(dgv_project.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgv_groups_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cgid = int.Parse(dgv_groups.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
