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
    public partial class Manage_Projects : Form
    {
        public Manage_Projects()
        {
            InitializeComponent();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Manage_Projects f = new Manage_Projects();
            f.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MainUI_Form f = new MainUI_Form();
            f.Show();
            this.Hide();
        }
        public void showdata()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id,Title,Description from Project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_project.DataSource = dt;
            dgv_project.AllowUserToAddRows = false;
        }
        private void addproject_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv_project.Visible = true;
                panel1.Visible = true;
                tableLayoutPanel1.Visible = true;
                button1.Visible = true;
                Search.Visible = false;
                Search_tbox.Visible = false;
                button1.Text = "Insert";
                button1.ForeColor = Color.Red;
                title_tbox.Text = null;
                des_tbox.Text = null;
                showdata();
            }
        }

        private void updateproject_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show(string.Format("Click on the row of Data Grid View You want to Update"), "Confirmation", MessageBoxButtons.OK) == DialogResult.OK)
                {

                    dgv_project.Visible = true;
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

        private void searchproject_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                panel1.Visible = true;
                tableLayoutPanel1.Visible = false;
                Search.Visible = true;
                Search_tbox.Visible = true;
                button1.Visible = false;
                dgv_project.Visible = true;
                showdata();            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Insert")
            {

                if (title_tbox.Text.Length > 0 && des_tbox.Text.Length > 0)
                {
                    var con1 = Configuration.getInstance().getConnection();
                    string query2 = "Select Title from Project where Title = @Title";
                    SqlCommand commandtocheckregno = new SqlCommand(query2, con1);
                    commandtocheckregno.Parameters.AddWithValue("@Title", title_tbox.Text);
                    string check = (string)commandtocheckregno.ExecuteScalar();
                    if (check == title_tbox.Text)
                    {
                        MessageBox.Show("Project of Same Title already added...!");
                    }
                    else
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("Insert into Project values (@Description, @Title)", con);
                        cmd.Parameters.Add("@Title", SqlDbType.VarChar, 50).Value = title_tbox.Text;
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar, -1).Value = des_tbox.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Project created SuccessFully");
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
                if (title_tbox.Text.Length > 0 && des_tbox.Text.Length > 0)
                {
               
                        string query = "Update  Project Set Title = @Title,Description = @Description Where Id = @Id";
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", int.Parse(dgv_project.CurrentRow.Cells[0].Value.ToString()));
                        cmd.Parameters.AddWithValue("@Title", title_tbox.Text);
                        cmd.Parameters.AddWithValue("@Description", des_tbox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Successfully Updated. You can check the data grid view");
                        showdata();
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all the Fields...!");
                }
                }

        private void dgv_project_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(button1.Text == "Update")
            {
                title_tbox.Text = dgv_project.CurrentRow.Cells[1].Value.ToString();
                des_tbox.Text = dgv_project.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void Search_tbox_TextChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select Id,Description,Title from Project   where Id Like '%' +@param + '%' Or Description Like '%' +@param + '%' Or Title Like '%' +@param + '%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@param", Search_tbox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_project.DataSource = dt;
        }
    }
}
