using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Project
{
    public partial class MainUI_Form : Form
    {
        public MainUI_Form()
        {
            InitializeComponent();
        }

        

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ManageStu_Form f = new ManageStu_Form();
            this.Hide();
            f.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MainUI_Form f = new MainUI_Form();
            f.Show();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ManageAdvisors f = new ManageAdvisors();
            f.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Manage_Projects f = new Manage_Projects();
            f.Show();
            this.Hide();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Manage_Evaluations f = new Manage_Evaluations();
            f.Show();
            this.Hide();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Manage_Groups f = new Manage_Groups();
            f.Show();
            this.Hide();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            AssignProject_Group f = new AssignProject_Group();
            f.Show();
            this.Hide();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            AssignProject_Advisor f = new AssignProject_Advisor();
            f.Show();
            this.Hide();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            GroupEvaluation f = new GroupEvaluation();
            f.Show();
            this.Hide();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            GeneratePdf f = new GeneratePdf();
            f.Show();
            this.Hide();
        }
    }
}
