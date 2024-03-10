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
    public partial class ManageStu_Form : Form
    {
        public ManageStu_Form()
        {
            InitializeComponent();
        }
      
        public void showdata()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select S.Id,S.RegistrationNo,P.FirstName,P.LastName,P.Contact,P.Email,P.DateOfBirth,L.value Gender From Student S Join Person P On S.Id = P.Id Join Lookup L On P.gender = L.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_stu.DataSource = dt;
            dgv_stu.AllowUserToAddRows = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gender_cbox.Items.Add("Male");
            gender_cbox.Items.Add("Female");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv_stu.Visible = true;
                panel1.Visible = true;
                tableLayoutPanel1.Visible = true;
                button1.Visible = true;
                Search.Visible = false;
                Search_tbox.Visible = false;
                button1.Text = "Insert";
                button1.ForeColor = Color.Red;
                regno_tbox.Text = null;
                fname_tbox.Text = null;
                lname_tbox.Text = null;
                contact_tbox.Text = null;
                email_tbox.Text = null;
                gender_cbox.SelectedItem = null;
                showdata();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ManageStu_Form f = new ManageStu_Form();
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

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                panel1.Visible = true;
                tableLayoutPanel1.Visible = false;
                Search.Visible = true;
                Search_tbox.Visible = true;
                button1.Visible = false;
                showdata();
                dgv_stu.Visible = true;
            }
        }

        private void updatestu_button_Click(object sender, EventArgs e)
        {
            
               if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"),"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show(string.Format("Click on the row of Data Grid View You want to Update"), "Confirmation", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                        dgv_stu.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Insert")
            {

                if (regno_tbox.Text != null && fname_tbox.Text != null && lname_tbox.Text != null && contact_tbox.Text != null && email_tbox.Text != null && gender_cbox.SelectedItem != null)
                {

                    var con = Configuration.getInstance().getConnection();
                    string query = "Select RegistrationNo from Student where RegistrationNo = @param";
                    SqlCommand commandtocheckregno = new SqlCommand(query, con);
                    commandtocheckregno.Parameters.AddWithValue("@param", regno_tbox.Text);
                    string check = (string)commandtocheckregno.ExecuteScalar();
                    if (check == regno_tbox.Text)
                    {
                        MessageBox.Show("Already exists this RegistrationNo,See table");
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

                        string date = dateTimePicker1.Text;
                        DateTime cdate = DateTime.Parse(date);
                        SqlCommand cmd = new SqlCommand("Insert into Person values (@FirstName, @LastName, @Contact,@Email,@DateOfBirth,@Gender)", con);
                        SqlCommand cmd1 = new SqlCommand("Insert into [dbo].[Student](Id,RegistrationNo) VALUES ((SELECT Id FROM Person WHERE FirstName = @FirstName AND LastName=@LastName AND Contact=@Contact AND Email=@Email AND DateOfBirth=@DateOfBirth AND Gender=@Gender) ,@RegistrationNo)", con);
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
                        cmd1.Parameters.AddWithValue("@RegistrationNo", regno_tbox.Text);
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
                if (regno_tbox.Text != null && fname_tbox.Text != null && lname_tbox.Text != null && contact_tbox.Text != null && email_tbox.Text != null && gender_cbox.SelectedItem != null)
                {

                    if (gender_cbox.Text == "Male")
                    {
                        gender_cbox.Text = "1";
                    }
                    if (gender_cbox.Text == "Female")
                    {
                        gender_cbox.Text = "2";
                    }

                    string date = dateTimePicker1.Text;
                    DateTime cdate = DateTime.Parse(date);
                    var con = Configuration.getInstance().getConnection();
                    string query = "UPDATE Person  SET FirstName = @FirstName,LastName=@LastName,Contact=@Contact,Email = @Email,DateOfBirth = @DateOfBirth,Gender = @Gender   Where  Id = @Id";
                    string query1 = "UPDATE Student SET RegistrationNo = @RegNo Where Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(dgv_stu.CurrentRow.Cells[0].Value.ToString()));
                    cmd.Parameters.AddWithValue("@FirstName", fname_tbox.Text);
                    cmd.Parameters.AddWithValue("@LastName", lname_tbox.Text);
                    cmd.Parameters.AddWithValue("@Contact", contact_tbox.Text);
                    cmd.Parameters.AddWithValue("@Email", email_tbox.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", cdate);
                    cmd.Parameters.AddWithValue("@Gender", int.Parse(gender_cbox.Text));
                    cmd1.Parameters.AddWithValue("@RegNo", regno_tbox.Text);
                    cmd1.Parameters.AddWithValue("@Id", int.Parse(dgv_stu.CurrentRow.Cells[0].Value.ToString()));
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Updated. You can check the data grid view");
                    showdata();
                }

                else
                {
                    MessageBox.Show("Please fill all the Fields...");
                }
            }
            }
     
        private void dgv_stu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(button1.Text == "Update" )
            {
                regno_tbox.Text = dgv_stu.CurrentRow.Cells[1].Value.ToString();
                fname_tbox.Text = dgv_stu.CurrentRow.Cells[2].Value.ToString();
                lname_tbox.Text =  dgv_stu.CurrentRow.Cells[3].Value.ToString();
                contact_tbox.Text = dgv_stu.CurrentRow.Cells[4].Value.ToString();
                email_tbox.Text = dgv_stu.CurrentRow.Cells[5].Value.ToString();
                gender_cbox.Text = dgv_stu.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker1.Text = dgv_stu.CurrentRow.Cells[6].Value.ToString();
            }
        }

      

        private void Search_tbox_TextChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select S.Id,S.RegistrationNo,P.FirstName,P.LastName,P.Contact,P.Email,P.DateOfBirth,L.Value Gender from Student S Join Person P On S.Id = P.Id Join Lookup L On P.Gender = L.Id where S.Id  Like '%' +@param + '%' Or P.Id Like '%' +@param + '%' Or RegistrationNo Like '%' +@param + '%' Or FirstName Like '%' +@param + '%' Or LastName Like '%' +@param + '%' Or Contact Like '%' +@param + '%' Or Email Like '%' +@param + '%' Or DateOfBirth Like '%' +@param + '%' Or L.Value Like '%' +@param + '%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@param", Search_tbox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_stu.DataSource = dt;

        }


    }
}
