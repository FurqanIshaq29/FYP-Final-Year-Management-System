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
using Mid_Project.Dl;
using Mid_Project.Bl;

namespace Mid_Project
{
    public partial class AssignProject_Advisor : Form
    {


        public AssignProject_Advisor()
        {
            InitializeComponent();
        }
        int id;

        bool flag = true;

        string mainadvisor;
        string coadvisor;
        string iadvisor;
        int madvisor = 11;
        int cadvisor = 12;
        int iadvisors = 14;
        List<int> adrole = new List<int>();
        public void show_groupproject()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select G.GroupId,P.Id ProjectId,P.Title,P.Description From Project P Join GroupProject G On P.Id = G.ProjectId";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_gproject.DataSource = dt;
            dgv_gproject.AllowUserToAddRows = false;
        }
        private void home_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AssignProject_Advisor f = new AssignProject_Advisor();
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

        private void assigngproject_advisor_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(string.Format(" Do you want to continue exiting this page"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("1. Select any row from Group Project Table to select project and then click on Select button.." +
                    "  2. Select the advisors from three boxex shown.." +
                    "  3. Click on Assign Button..");
                show_groupproject();
                adrole.Add(madvisor);
                adrole.Add(cadvisor);
                adrole.Add(iadvisors);
                dgv_gproject.Visible = true;
                tableLayoutPanel1.Visible = true;
                button1.Visible = true;
                if (Advisor_Role.count == 1)
                {
                    Advisor_DL.add_tolist();
                    Advisor_Role.count = 0;
                }
                    for (int x = 0; x < Advisor_DL.advisor_data.Count; x++)
                    {
                        mainadvisor_cbox.Items.Add(Advisor_DL.advisor_data[x].fname + Advisor_DL.advisor_data[x].lname);
                        coadvisor_cbox.Items.Add(Advisor_DL.advisor_data[x].fname + Advisor_DL.advisor_data[x].lname);
                        iadvsior_cbox.Items.Add(Advisor_DL.advisor_data[x].fname + Advisor_DL.advisor_data[x].lname);
                    }                  
                
            }
        }

        private void AssignProject_Advisor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select ProjectId from ProjectAdvisor where ProjectId = @param";
            SqlCommand commandtocheckpid = new SqlCommand(query, con);
            commandtocheckpid.Parameters.AddWithValue("@param", id);
            int check = Convert.ToInt32(commandtocheckpid.ExecuteScalar());
            if (check == id)
            {
                MessageBox.Show("Advisors Already Assigned to this project");
            }
            else
            {
                if (MessageBox.Show(string.Format(" Do you want to select  this Project"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Now select the Main,Co and Industry Advisors from below");
                    button1.Visible = false;
                    flag = false;
                    tableLayoutPanel2.Visible = true;
                    selectmadvisor.Visible = true;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (mainadvisor_cbox.SelectedItem == null)
            {
                MessageBox.Show("Please Select the Main Advisor First");
            }
            else
            {
                mainadvisor = mainadvisor_cbox.Text;
                for (int x = 0; x < coadvisor_cbox.Items.Count; x++)
                {
                    if (coadvisor_cbox.Items[x].ToString() == mainadvisor)
                    {
                        coadvisor_cbox.Items.RemoveAt(x);
                        x--;
                        break;
                    }
                }
                for (int x = 0; x < iadvsior_cbox.Items.Count; x++)
                {
                    if (iadvsior_cbox.Items[x].ToString() == mainadvisor)
                    {
                        iadvsior_cbox.Items.RemoveAt(x);
                        x--;
                        break;
                    }
                }
                Advisor_Role a = new Advisor_Role(mainadvisor);
                Advisor_RoleDl.alist.Add(a);
                selectmadvisor.Visible = false;
                selectcadvisor.Visible = true;
            }
        }

        private void dgv_gproject_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == true)
            {
                id = int.Parse(dgv_gproject.CurrentRow.Cells[1].Value.ToString());
            }
        }

        private void selectcadvisor_Click(object sender, EventArgs e)
        {
            if (coadvisor_cbox.SelectedItem == null)
            {
                MessageBox.Show("Please Select the Co Advisor First");
            }
            else
            {
                coadvisor = coadvisor_cbox.Text;
                for (int x = 0; x < iadvsior_cbox.Items.Count; x++)
                {
                    if (iadvsior_cbox.Items[x].ToString() == coadvisor)
                    {
                        iadvsior_cbox.Items.RemoveAt(x);
                        x--;
                        break;
                    }
                }
                Advisor_Role a = new Advisor_Role(coadvisor);
                Advisor_RoleDl.alist.Add(a);
                selectcadvisor.Visible = false;
                selectiadvisor.Visible = true;
            }

        }

        private void selectiadvisor_Click(object sender, EventArgs e)
        {
            if (iadvsior_cbox.SelectedItem == null)
            {
                MessageBox.Show("Please Select the Main Advisor First");
            }
            else
            {
                
                iadvisor = iadvsior_cbox.Text;
                Advisor_Role a = new Advisor_Role(iadvisor);
                Advisor_RoleDl.alist.Add(a);
                selectiadvisor.Visible = false;
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            for (int x = 0; x < 3; x++)
            {

                var con = Configuration.getInstance().getConnection();
                string query = "INSERT INTO dbo.[ProjectAdvisor] (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) " +
                   " Values ((SELECT P.Id FROM Advisor A JOIN Person P ON A.Id = P.Id " +
                   "WHERE P.FirstName + P.LastName = @name ),@id,@AdvisorRole,@Date)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", Advisor_RoleDl.alist[x].aname);
                cmd.Parameters.AddWithValue("@AdvisorRole", adrole[x]);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.ExecuteNonQuery();
            }

            Advisor_RoleDl.alist.Clear();
            adrole.Clear();
            flag = true;
            MessageBox.Show("Project Assigned to Advisors... Click ok to continue");
            AssignProject_Advisor f = new AssignProject_Advisor();
            f.Show();
            this.Hide();
        }
    }
}
