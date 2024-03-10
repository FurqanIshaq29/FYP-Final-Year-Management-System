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
    public partial class ManageAdvisors : Form
    {
        public ManageAdvisors()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select A.Id,L1.Value Designation,A.Salary,P.FirstName,P.LastName,P.Contact,P.Email,P.DateOfBirth,L.Value Gender From Advisor A Join Person P On A.Id = P.Id Join Lookup L On P.gender = L.Id Join Lookup L1 On A.Designation = L1.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_advisor.DataSource = dt;
            dgv_advisor.AllowUserToAddRows = false;
        }
        private void addadvisor_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv_advisor.Visible = true;
                panel1.Visible = true;
                tableLayoutPanel1.Visible = true;
                button1.Visible = true;
                Search.Visible = false;
                Search_tbox.Visible = false;
                button1.Text = "Insert";
                button1.ForeColor = Color.Red;
                d_cbox.SelectedItem = null;
                fname_tbox.Text = null;
                lname_tbox.Text = null;
                contact_tbox.Text = null;
                email_tbox.Text = null;
                gender_cbox.SelectedItem = null;
                salary_tbox.Text = null;
                showdata();
            }
        }

        private void updateadvisor_button_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show(string.Format("Click on the row of Data Grid View You want to Update"), "Confirmation", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                        dgv_advisor.Visible = true;
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

        private void searchadvisor_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                panel1.Visible = true;
                tableLayoutPanel1.Visible = false;
                Search.Visible = true;
                Search_tbox.Visible = true;
                button1.Visible = false;
                showdata();
                dgv_advisor.Visible = true;
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

        private void home_button_Click(object sender, EventArgs e)
        {

            ManageAdvisors f = new ManageAdvisors();
            f.Show();
            this.Hide();
        }

        private void dgv_stu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (button1.Text == "Update")
            {
 
                fname_tbox.Text = dgv_advisor.CurrentRow.Cells[3].Value.ToString();
                lname_tbox.Text = dgv_advisor.CurrentRow.Cells[4].Value.ToString();
                contact_tbox.Text = dgv_advisor.CurrentRow.Cells[5].Value.ToString();
                email_tbox.Text = dgv_advisor.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker1.Text = dgv_advisor.CurrentRow.Cells[7].Value.ToString();
                salary_tbox.Text = dgv_advisor.CurrentRow.Cells[2].Value.ToString();
                gender_cbox.Text = dgv_advisor.CurrentRow.Cells[8].Value.ToString();
                d_cbox.Text = dgv_advisor.CurrentRow.Cells[1].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Insert")
            {

                if (d_cbox.SelectedItem != null && fname_tbox.Text != null && lname_tbox.Text != null && contact_tbox.Text != null && email_tbox.Text != null && gender_cbox.SelectedItem != null && salary_tbox.Text != null)
                {

                    var con = Configuration.getInstance().getConnection();

                    string query = "Select P.FirstName,P.LastName from Advisor A Join Person P ON  P.Id = A.Id where P.FirstName+P.LastName = @param";
                    SqlCommand commandtocheckadvisor = new SqlCommand(query, con);
                    commandtocheckadvisor.Parameters.AddWithValue("@param", fname_tbox.Text + lname_tbox.Text);
                    string check = (string)commandtocheckadvisor.ExecuteScalar();
                    if (check == fname_tbox.Text + lname_tbox.Text)
                    {
                        MessageBox.Show("Already exists this Advisor,See table");
                    }
                    else
                    {
                        if (gender_cbox.Text == "Male")
                        {
                            gender_cbox.Text = "1";
                        }
                        if (gender_cbox.Text == "Female")
                        {
                            gender_cbox.Text = "2";
                        }

                        if (d_cbox.Text == "Professor")
                        {
                            d_cbox.Text = "6";
                        }
                        if (d_cbox.Text == "Associate Professor")
                        {
                            d_cbox.Text = "7";
                        }
                        if (d_cbox.Text == "Assistant Professor")
                        {
                            d_cbox.Text = "8";
                        }
                        if (d_cbox.Text == "Lecturer")
                        {
                            d_cbox.Text = "9";
                        }
                        if (d_cbox.Text == "Industry Professional")
                        {
                            d_cbox.Text = "10";
                        }

                        string date = dateTimePicker1.Text;
                        DateTime cdate = DateTime.Parse(date);
                        SqlCommand cmd = new SqlCommand("Insert into Person values (@FirstName, @LastName, @Contact,@Email,@DateOfBirth,@Gender)", con);
                        SqlCommand cmd1 = new SqlCommand("Insert into [dbo].[Advisor](Id,Designation,Salary) VALUES ((SELECT Id FROM Person WHERE FirstName = @FirstName AND LastName=@LastName AND Contact=@Contact AND Email=@Email AND DateOfBirth=@DateOfBirth AND Gender=@Gender) ,@Designation,@Salary)", con);
                        cmd.Parameters.AddWithValue("@FirstName", fname_tbox.Text);
                        cmd.Parameters.AddWithValue("@LastName", lname_tbox.Text);
                        cmd.Parameters.AddWithValue("@Contact", contact_tbox.Text);
                        cmd.Parameters.AddWithValue("@Email", email_tbox.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", cdate);
                        cmd.Parameters.AddWithValue("@Gender", int.Parse(gender_cbox.Text));
                        cmd1.Parameters.AddWithValue("@FirstName", fname_tbox.Text);
                        cmd1.Parameters.AddWithValue("@LastName", lname_tbox.Text);
                        cmd1.Parameters.AddWithValue("@Contact", contact_tbox.Text);
                        cmd1.Parameters.AddWithValue("@Email", email_tbox.Text);
                        cmd1.Parameters.AddWithValue("@DateOfBirth", cdate);
                        cmd1.Parameters.AddWithValue("@Gender", int.Parse(gender_cbox.Text));
                        cmd1.Parameters.AddWithValue("@Designation", int.Parse(d_cbox.Text));
                        cmd1.Parameters.AddWithValue("@Salary", float.Parse(salary_tbox.Text));
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data Successfully saved");
                        showdata();

                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }
            }
            if (button1.Text == "Update")
            {
                if (d_cbox.SelectedItem != null && fname_tbox.Text != null && lname_tbox.Text != null && contact_tbox.Text != null && email_tbox.Text != null && gender_cbox.SelectedItem != null && salary_tbox.Text != null)
                {

                    if (gender_cbox.Text == "Male")
                    {
                        gender_cbox.Text = "1";
                    }
                    if (gender_cbox.Text == "Female")
                    {
                        gender_cbox.Text = "2";
                    }
                    if (d_cbox.Text == "Professor")
                    {
                        d_cbox.Text = "6";
                    }
                    if (d_cbox.Text == "AssociateProfessor")
                    {
                        d_cbox.Text = "7";
                    }
                    if (d_cbox.Text == "Assistant Professor")
                    {
                        d_cbox.Text = "8";
                    }
                    if (d_cbox.Text == "Lecturer")
                    {
                        d_cbox.Text = "9";
                    }
                    if (d_cbox.Text == "Industry Professional")
                    {
                        d_cbox.Text = "10";
                    }
                    string date = dateTimePicker1.Text;
                    DateTime cdate = DateTime.Parse(date);
                    var con = Configuration.getInstance().getConnection();
                    string query = "UPDATE Person  SET FirstName = @FirstName,LastName=@LastName,Contact=@Contact,Email = @Email,DateOfBirth = @DateOfBirth,Gender = @Gender   Where  Id = @Id";
                    string query1 = "UPDATE Advisor SET Designation = @Designation,Salary = @Salary Where Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(dgv_advisor.CurrentRow.Cells[0].Value.ToString()));
                    cmd.Parameters.AddWithValue("@FirstName", fname_tbox.Text);
                    cmd.Parameters.AddWithValue("@LastName", lname_tbox.Text);
                    cmd.Parameters.AddWithValue("@Contact", contact_tbox.Text);
                    cmd.Parameters.AddWithValue("@Email", email_tbox.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", cdate);
                    cmd.Parameters.AddWithValue("@Gender", int.Parse(gender_cbox.Text));
                    cmd1.Parameters.AddWithValue("@Id", int.Parse(dgv_advisor.CurrentRow.Cells[0].Value.ToString()));
                    cmd1.Parameters.AddWithValue("@Designation", int.Parse(d_cbox.Text));
                    cmd1.Parameters.AddWithValue("@Salary", float.Parse(salary_tbox.Text));
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Updated. You can check the data grid view");
                    showdata();
                }

                else
                {
                    MessageBox.Show("Please Fill all the Fields....!");
                }
            }
        }
        

        private void Search_tbox_TextChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select A.Id,L1.Value Designation,A.Salary,P.FirstName,P.LastName,P.Contact,P.Email,P.DateOfBirth,L.Value Gender from Advisor A Join Person P On A.Id = P.Id Join Lookup L1 On A.Designation = L1.Id Join Lookup L on P.Gender = L.Id where A.Id Like '%' +@param + '%' Or P.Id Like '%' +@param + '%' Or L1.Value  Like '%' +@param + '%' Or Salary Like '%' +@param + '%' Or FirstName Like '%' +@param + '%' Or LastName Like '%' +@param + '%' Or Contact Like '%' +@param + '%' Or Email Like '%' +@param + '%' Or DateOfBirth Like '%' +@param + '%' Or L.Value Like '%' +@param + '%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@param", Search_tbox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_advisor.DataSource = dt;
        }
    }
}
