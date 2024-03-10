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
using Mid_Project.Bl;
using Mid_Project.Dl;

namespace Mid_Project
{
    public partial class Manage_Groups : Form
    {
        public Manage_Groups()
        {
            InitializeComponent();
        }
        int count = 0;
        string name;
        string id;
        string regno;
        string lname;
        string contact;
        string email;
        string gender;
        bool flag = false;
        public void showdata()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select S.Id,S.RegistrationNo,P.FirstName,P.LastName,P.Contact,P.Email,P.DateOfBirth,L.Value Gender From Student S Join Person P On S.Id = P.Id Join Lookup L On L.Id = P.Gender", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_stu.DataSource = dt;
            dgv_stu.AllowUserToAddRows = false;
        }
        public void show_groupmembers()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select G.Id,G1.StudentId,S.RegistrationNo,P.FirstName,P.LastName,L.Value Status From dbo.[Group] G Join dbo.[GroupStudent] G1 On G.Id = G1.GroupId Join Lookup L On G1.Status = L.Id Join dbo.[Student] S On G1.StudentId = S.Id Join Person P On S.Id = P.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_groupmembers.DataSource = dt;
            dgv_groupmembers.AllowUserToAddRows = false;

        }
        private void addproject_button_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Note...   "    +
                    "1.You have to click on the row of table for the student you want to add and after that click on Add button    "    +
                    "2. Click on the Save and Back Button for the creation of Group otherwise the group could not be created");
                dgv_groupmembers.Visible = false;
                dgv_stu.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                Search.Visible = false;
                Search_tbox.Visible = false;
                showdata();
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Manage_Groups f = new Manage_Groups();
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

        private void dgv_stu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = dgv_stu.CurrentRow.Cells[0].Value.ToString();
            regno = dgv_stu.CurrentRow.Cells[1].Value.ToString();
            name = dgv_stu.CurrentRow.Cells[2].Value.ToString();
            lname = dgv_stu.CurrentRow.Cells[3].Value.ToString();
            contact = dgv_stu.CurrentRow.Cells[4].Value.ToString();
            email = dgv_stu.CurrentRow.Cells[5].Value.ToString();
            if(dgv_stu.CurrentRow.Cells[7].Value.ToString() == "Male")
            {
                gender = "1";
            }
            if(dgv_stu.CurrentRow.Cells[7].Value.ToString() == "Female")
            {
                gender = "2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var con = Configuration.getInstance().getConnection();
            string query = "Select StudentId from GroupStudent where StudentId = @param ";
            string query2 = "Select Status from GroupStudent where   StudentId = @StudentId";
            SqlCommand cmdtocheckstatus = new SqlCommand(query2, con);
            cmdtocheckstatus.Parameters.AddWithValue("@StudentId", int.Parse(dgv_stu.CurrentRow.Cells[0].Value.ToString())); 
            int status = Convert.ToInt32(cmdtocheckstatus.ExecuteScalar());
            SqlCommand commandtocheckid = new SqlCommand(query, con);
            commandtocheckid.Parameters.AddWithValue("@param", int.Parse(dgv_stu.CurrentRow.Cells[0].Value.ToString()));
            
            int check = Convert.ToInt32(commandtocheckid.ExecuteScalar());
            if(check == int.Parse(dgv_stu.CurrentRow.Cells[0].Value.ToString()) && status == 3)
            {
                MessageBox.Show("Student already added in Group");
            }
      
            else
            {
                
                if (count < 4)
                {
                    if (Stu_DL.check(int.Parse(id)))
                    {
                        count = count + 1;
                        Student s = new Student(name, lname, regno, int.Parse(id), contact, email, int.Parse(gender));
                        Stu_DL.stu_list.Add(s);
                        MessageBox.Show("Student added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Student just added Choose another one...");
                    }
                }
                else
                {
                    MessageBox.Show("Group should not contain more than 3 students");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count > 1 )
            {
                flag = true;
                int id = 0;
                string mydate = DateTime.Now.ToString("yyy/MM/dd");
                DateTime date = DateTime.Parse(mydate);
                var con = Configuration.getInstance().getConnection();
                if (flag == true)
                {
                    SqlCommand cmd = new SqlCommand("Insert into [dbo].[Group](Created_On) VALUES (@Created_On); Select SCOPE_IDENTITY()", con);
                    cmd.Parameters.AddWithValue("@Created_On", date);
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    flag = false;
                }
                for (int x = 0; x < Stu_DL.stu_list.Count; x++)
                {
                    SqlCommand cmd = new SqlCommand("Insert into [dbo].[GroupStudent](GroupId,StudentId,Status,AssignmentDate) VALUES (@id,(Select Id From Student where Id = @stuid),@Status,@AssignmentDate)", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@stuid", Stu_DL.stu_list[x].id);
                    cmd.Parameters.AddWithValue("@Status", 3);
                    cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                flag = false;
                Stu_DL.stu_list.Clear();
                count = 0;
                if(MessageBox.Show(string.Format("Group Created Successfully ! Do you want to go back"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Manage_Groups f = new Manage_Groups();
                    f.Show();
                    this.Hide();
                }

            }
            else
            {

               if (MessageBox.Show(string.Format("Group should contain at least two students ! Do you want to exit ?"),"Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Manage_Groups f = new Manage_Groups();
                    f.Show();
                    this.Hide();
                }

                
            }
        }

        private void searchgroup_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Search.Visible = true;
                Search_tbox.Visible = true;
                dgv_stu.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                dgv_groupmembers.Visible = true;
                dgv_stu.Visible = false;
                show_groupmembers();
            }
        }

        private void removestu_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Click on any row of the table for the student you want to remove from the group an then click on Remove Button...!");
                dgv_stu.Visible = false;
                dgv_groupmembers.Visible = true;
                button3.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                show_groupmembers();
            }
        }

        private void dgv_groupmembers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Update GroupStudent Set Status = @Status Where StudentId = @StudentId ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Status", 4);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(dgv_groupmembers.CurrentRow.Cells[1].Value.ToString()));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student left the group Check the status updated.");
            show_groupmembers();

        }

        private void Search_tbox_TextChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
             string query = "Select G.Id,G1.StudentId,S.RegistrationNo,P.FirstName,P.LastName,L.Value Status From dbo.[Group] G Join dbo.[GroupStudent] G1 On G.Id = G1.GroupId Join Lookup L On G1.Status = L.Id Join dbo.[Student] S On G1.StudentId = S.Id Join Person P On S.Id = P.Id Where G.Id Like '%' +@param + '%' Or G1.StudentId Like '%' +@param + '%' Or S.RegistrationNo Like '%' +@param + '%' Or P.FirstName Like '%' +@param + '%' Or P.LastName Like '%' +@param + '%' Or L.value Like '%' +@param + '%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@param", Search_tbox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_groupmembers.DataSource = dt;
        }
    }
}
